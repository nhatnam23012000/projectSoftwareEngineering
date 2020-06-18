using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFCS
{
    public partial class Cook : Form
    {
        private StaffAccount account;
        private OrderDatabase orderDatabase;
        public Cook(StaffAccount account, OrderDatabase orderDatabase)
        {
            InitializeComponent();
            this.account = account;
            this.orderDatabase = orderDatabase;
            lblName.Text = account.getName();

            //View order
            lbl1.Hide();
            lbl2.Hide();
            lbl3.Hide();
            cbSearchName.Hide();
            btnView.Hide();
            vbOrderInfo.Hide();
            vbOrderList.Hide();
            lblNotification.Hide();
            lblNotification.Text = "";
            lbList.Hide();
            //Update state
            lbl4.Hide();
            lbl5.Hide();
            lbl6.Hide();
            cbState.Hide();
            lblStateNotification.Hide();
            lblStateNotification.Text = "";
            lblCurrentState.Hide();
            lblCurrentState.Text = "";
            btnOK.Hide();

            for (int i = 0; i < orderDatabase.getCount(); i++)
            {
                string[] arr = new string[1];
                arr[0] = orderDatabase.getOrderList(i).getName();
                ListViewItem l1 = new ListViewItem(arr);
                vbOrderList.Items.Add(l1);
                cbSearchName.Items.Add(orderDatabase.getOrderList(i).getName());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cbSearchName.Text == "")
            {
                lblNotification.ForeColor = Color.Red;
                lblNotification.Text = "Vui lòng nhập tên \nkhách hàng!";
            }
            else
            {
                viewOrder(cbSearchName.Text);
                getState(cbSearchName.Text);
            }
        }
        public void logout()
        {
            this.Close();
        }
        public void viewOrder(String name)
        {
            Order order = orderDatabase.getOrder(name);
            if (order == null)
            {
                lblNotification.ForeColor = Color.Red;
                lblNotification.Text = "Đơn hàng không tồn tại!";                
            }
            else
            {
                lblNotification.Text = "";
                for (int i = 0; i < order.getFoodList().Count; i++)
                {
                    Food food = order.getFoodList().ElementAt<Food>(i);
                    string[] arr = new string[3];
                    arr[0] = food.id.ToString();
                    arr[1] = food.name;
                    arr[2] = food.amount.ToString();
                    ListViewItem l1 = new ListViewItem(arr);
                    vbOrderInfo.Items.Add(l1);
                }
            }
        }
        public void getState(String name)
        {
            Order order = orderDatabase.getOrder(name);
            if (order == null)
            {
                lblNotification.ForeColor = Color.Red;
                lblNotification.Text = "Đơn hàng không tồn tại!";
            }
            else
            {
                lblNotification.Text = "";
                switch (order.getState())
                {
                    case State.WAITING:
                        lblCurrentState.Text = "WAITING";
                        break;
                    case State.DOING:
                        lblCurrentState.Text = "DOING";
                        break;
                    case State.READY:
                        lblCurrentState.Text = "READY";
                        break;
                }
            }
        }
        public void updateState(String name)
        {
            switch (cbState.Text)
            {
                case "WAITING":
                    orderDatabase.getOrder(name).setState(State.WAITING);
                    break;
                case "DOING":
                    orderDatabase.getOrder(name).setState(State.DOING);
                    break;
                case "READY":
                    orderDatabase.getOrder(name).setState(State.READY);
                    break;
            }
            lblStateNotification.ForeColor = Color.Green;
            lblStateNotification.Text = "Đã cập nhật trạng thái đơn hàng";
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            //View order
            lbl1.Show();
            lbl2.Show();
            lbl3.Show();
            cbSearchName.Show();
            btnView.Show();
            vbOrderInfo.Show();
            vbOrderList.Show();
            lblNotification.Show();
            lbList.Show();
            //State
            lbl4.Hide();
            lbl5.Hide();
            lbl6.Hide();
            cbState.Hide();
            lblStateNotification.Hide();
            lblStateNotification.Text = "";
            lblCurrentState.Hide();
            btnOK.Hide();
        }

        private void btnUpdateState_Click(object sender, EventArgs e)
        {
            //View order
            lbl3.Hide();
            vbOrderInfo.Hide();
            lblNotification.Text = "";

            lbl1.Show();
            lbl2.Show();
            cbSearchName.Show();
            btnView.Show();
            vbOrderList.Show();
            lblNotification.Show();
            lbList.Show();
            //State
            lbl4.Show();
            lbl5.Show();
            lbl6.Show();
            cbState.Show();
            lblStateNotification.Show();
            lblStateNotification.Text = "";
            lblCurrentState.Show();
            btnOK.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            updateState(cbSearchName.Text);
            getState(cbSearchName.Text);
        }
    }
}
