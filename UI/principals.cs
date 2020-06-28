using PadraoDeProjetoEmCamadas.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class principals : Form
    {

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        private Color SelectThemeColor()
        {
            int index = random.Next(cor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(cor.ColorList.Count);
            }
            tempIndex = index;
            string color = cor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                 

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(childForm);
            this.panelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbttitle.Text = childForm.Text;
        }
        public principals()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void principals_Load(object sender, EventArgs e)
        {
           
         }

        private void botaoPessoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Pessoa(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Empresa(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Eleicao(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Urna(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Voto(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Eleitor(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Candidato(), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lbttitle.Text = "HOME";
            
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            buttonClose.Visible = true;
        }

        private void principals_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void relempresa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Relatorio(), sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Relatorio2(), sender);
        }
    }
}
