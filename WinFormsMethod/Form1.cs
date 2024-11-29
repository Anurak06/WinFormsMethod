namespace WinFormsMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ยินดีต้อนรับ", "โปรแกรมทดสอบความอ้วนผอม");
            clearForm();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            //ปุ่ม "คำนวณ BMI"
            //in put รับค่า textbox
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            //1 double height = Convert.ToDouble(txtHeight.Text);
            //2 double height = 0;
            //2 if (double.TryParse(txtHeight.Text, out height)==false)
            //2 {
            //2  MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            //2    return; //ถ้าค่าใน if เป็นจริง ให้จบการทำงาน
            //2 }
            //1 double weight = Convert.ToDouble(txtWeight.Text);
            //2 double weight = 0;
            //2 if (double.TryParse(txtWeight.Text, out weight) == false)
            //2 {
            //2   MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            //2    return; //ถ้าค่าใน if เป็นจริง ให้จบการทำงาน
            //2 }
            double height = 0;
            double weight = 0;
            if(CheckDouble(txtWeight,txtHeight))
            {
                height = Convert.ToDouble(txtWeight.Text);
                weight = Convert.ToDouble(txtWeight.Text);
            }
            //Process คำนวณแล้ว BMi
            //double bmi = weight / Math.Pow(height / 100, 2);
            double bmi = BMI(height, weight);  //เรียกใช้ Method BMI
            //Output แปลผล โดยนำค่า BMI มาเทียบกับค่ามาตรฐาน
            lblResult.Text = bmi.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
        private void clearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;  //จัดชิดขวา
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            txtName.Text = "";
            txtAge.Text = "0";
            txtHeight.Text = "0";
            txtWeight.Text = "0";
            txtName.Focus();

        }
        private void IntputDataValid(TextBox name, TextBox age) //ทดสอบ TextBox ใน Method
        {
            if (name.Text.Length != 0)      //.length ความยาวของ string
            {
                name.ForeColor = Color.DarkGreen;
            }
            else
            {
                name.ForeColor = Color.Black;
            }
            if (Convert.ToInt32(age.Text) > 0)
            {
                age.ForeColor = Color.DarkGreen;
            }
            else
            {
                age.ForeColor = Color.Black;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            IntputDataValid(txtName, txtAge);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            IntputDataValid(txtName, txtAge);
        }
        private double BMI(double h,double w)  //คำนวณ bmi ส่งค่าเข้า 2 ค่าคือน้ำหนักและส่วนสูง
        {
           double bmi = w/Math.Pow(h/100,2);
           return bmi; 
           //return w / Math.Pow(h/100, 2);
        }
        private bool CheckDouble(TextBox txtW, TextBox txtH)  
        {
            double w = 0;
            double h = 0;
            if ((double.TryParse(txtW.Text, out w) == false) || (double.TryParse(txtW.Text, out h) == false))
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                return false;
            }
            return true;
        }
    }
}

