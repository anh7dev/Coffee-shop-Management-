using Microsoft.SqlServer.Server;
using QuanLyQuanCaPhe.DAO;
using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = QuanLyQuanCaPhe.DTO.Menu;

namespace QuanLyQuanCaPhe
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get => loginAccount;
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadTable();
            LoadCategory();
            LoadComboboxTable(cbSwitchTable);
            this.LoginAccount = LoginAccount;
        }

        #region Method

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text = " (" + LoginAccount.DisplayName + ")";
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.GetLoadTableList();
            foreach (Table item in tableList)
            {
                Button button = new Button()
                {
                    Width = TableDAO.TableWidth, Height = TableDAO.TableHeight

                };

                button.Text = item.Name + Environment.NewLine + item.Status + Environment.NewLine;
                button.Click += button_Click;
                button.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        button.BackColor = Color.AliceBlue;
                        break;
                    default:
                        button.BackColor = Color.LawnGreen;
                        break;
                }

                flpTable.Controls.Add(button);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        void ShowBill(int id)
        {
            float totalPrice = 0;
            lsvBill.Items.Clear();
            List<QuanLyQuanCaPhe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);

            foreach (QuanLyQuanCaPhe.DTO.Menu item in listBillInfo)
            {
                ListViewItem listViewItem = new ListViewItem(item.FoodName.ToString());
                listViewItem.SubItems.Add(item.Count.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(listViewItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
           // Thread.CurrentThread.CurrentCulture = culture;
            txbTotalPrice.Text = totalPrice.ToString("c",culture);

            
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodListByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }
        
        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.GetLoadTableList();
            cb.DisplayMember = "Name";
        }

        #endregion

        #region Events

       
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile accountProfile = new fAccountProfile(LoginAccount);
            accountProfile.UpdateAccount += accountProfile_UpdateAccount;
            accountProfile.ShowDialog();
        }

        void accountProfile_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin admin = new fAdmin();
            admin.loginAccount = LoginAccount;
            admin.InsertFood += admin_InsertFood;
            admin.DeleteFood += admin_DeleteFood;
            admin.UpdateFood += admin_UpdateFood;
            
            admin.ShowDialog();

        }

        private void admin_DeleteFood(object sender, EventArgs e)
        {
            
        }

        void admin_UpdateFood(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)   
        {
            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.ID);

            LoadTable();

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);
            int discount = (int)nmDiscount.Value;
            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
            double finalPrice = totalPrice - (totalPrice / 100) * discount;


            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có muốn thanh toán hóa đơn cho bàn {0} \n" +
                    "Tổng tiền - (Tổng tiền / 100) x Giảm giá " +
                    "= {1} - ({1} / 100) x {2} = {3}000 ", 
                    table.Name, totalPrice, discount, finalPrice), "Thông báo",
                    MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalPrice);
                    ShowBill(table.ID);
                    LoadTable();
                } 
            }
            
        }

        

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {

            int id1 = (lsvBill.Tag as Table).ID;
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có muốn chuyển bàn {0} sang bàn {1}", (lsvBill.Tag as Table).Name,
                (cbSwitchTable.SelectedItem as Table).Name),
                "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.CombineTable(id1, id2);
                LoadTable();
            }
        }

        #endregion

        private void btnCTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID;
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có muốn chuyển bàn {0} sang bàn {1}", (lsvBill.Tag as Table).Name,
                (cbSwitchTable.SelectedItem as Table).Name),
                "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);
                LoadTable();
            }
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCheckOut_Click(this, new EventArgs());
        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddFood_Click(this, new EventArgs());
        }

        private void admin_InsertFood(object sender, EventArgs e)
        {

        }

        private void saoLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog backUpFolder = new FolderBrowserDialog();
            backUpFolder.Description = "Chọn thư mục lưu trữ";
            if (backUpFolder.ShowDialog() == DialogResult.OK)
            {
                string sLink = backUpFolder.SelectedPath;
                if (DataBaseDAO.BackupData(sLink) == true)
                {
                    MessageBox.Show("Dữ liệu hệ thông đã được lưu vào " + sLink);
                }
                else
                {
                    MessageBox.Show("Sao lưu không thành công. Vui lòng thử lại");
                }
            }
        }

        private void phụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog restoreData = new OpenFileDialog();
            restoreData.Filter = "*bak|*bak";
            restoreData.Title = "Chọn tập tin muốn khôi phục(.bak)";
            if (restoreData.ShowDialog() == DialogResult.OK && restoreData.CheckFileExists == true)
            {
                string sLink = restoreData.FileName;
                MessageBox.Show(sLink);
                if (DataBaseDAO.RestoreData(sLink) == true)
                    MessageBox.Show("Phục hồi dữ liệu thành công!");
                else
                    MessageBox.Show("Phục hồi dữ liệu thất bại!");
            }
              
        }

        private void bánHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fHelpBanHang fHelp = new fHelpBanHang();
            fHelp.ShowDialog();
        }

        private void chuyểnHoặcGộpBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHelpChuyenGopBan helpChuyenGopBan = new fHelpChuyenGopBan();
            helpChuyenGopBan.ShowDialog();
        }

        private void thanhToánToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fHelpThanhToan fHelpThanhToan = new fHelpThanhToan();
            fHelpThanhToan.ShowDialog();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHelpBaoCao fHelpBaoCao = new fHelpBaoCao();
            fHelpBaoCao.ShowDialog();
        }
    }
}
