namespace Comandas
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dreamForm1 = new ReaLTaiizor.Forms.DreamForm();
            button1 = new ReaLTaiizor.Controls.Button();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            btnPedidosCozinha = new ReaLTaiizor.Controls.Button();
            btnUsuarios = new ReaLTaiizor.Controls.Button();
            btnCardapio = new ReaLTaiizor.Controls.Button();
            btnComanda = new ReaLTaiizor.Controls.Button();
            button2 = new ReaLTaiizor.Controls.Button();
            dreamForm1.SuspendLayout();
            foreverGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dreamForm1
            // 
            dreamForm1.BackColor = Color.Black;
            dreamForm1.ColorA = Color.FromArgb(40, 218, 255);
            dreamForm1.ColorB = Color.FromArgb(63, 63, 63);
            dreamForm1.ColorC = Color.Teal;
            dreamForm1.ColorD = Color.FromArgb(27, 27, 27);
            dreamForm1.ColorE = Color.FromArgb(0, 0, 0, 0);
            dreamForm1.ColorF = Color.FromArgb(25, 255, 255, 255);
            dreamForm1.Controls.Add(button2);
            dreamForm1.Controls.Add(button1);
            dreamForm1.Controls.Add(foreverGroupBox1);
            dreamForm1.Dock = DockStyle.Fill;
            dreamForm1.ForeColor = Color.Black;
            dreamForm1.Location = new Point(0, 0);
            dreamForm1.Name = "dreamForm1";
            dreamForm1.Size = new Size(790, 448);
            dreamForm1.TabIndex = 0;
            dreamForm1.TabStop = false;
            dreamForm1.Text = "Sistema de Comandas";
            dreamForm1.TitleAlign = HorizontalAlignment.Left;
            dreamForm1.TitleHeight = 25;
            dreamForm1.Enter += dreamForm1_Enter;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.Transparent;
            button1.EnteredBorderColor = Color.Transparent;
            button1.EnteredColor = Color.Transparent;
            button1.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.Transparent;
            button1.Location = new Point(718, 0);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.Transparent;
            button1.PressedColor = Color.Transparent;
            button1.Size = new Size(66, 26);
            button1.TabIndex = 4;
            button1.Text = "X";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click;
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.FromArgb(60, 70, 73);
            foreverGroupBox1.ArrowColorH = Color.FromArgb(60, 70, 73);
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.FromArgb(42, 52, 52);
            foreverGroupBox1.Controls.Add(btnPedidosCozinha);
            foreverGroupBox1.Controls.Add(btnUsuarios);
            foreverGroupBox1.Controls.Add(btnCardapio);
            foreverGroupBox1.Controls.Add(btnComanda);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(21, 209);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(738, 165);
            foreverGroupBox1.TabIndex = 4;
            foreverGroupBox1.TextColor = Color.FromArgb(35, 168, 109);
            // 
            // btnPedidosCozinha
            // 
            btnPedidosCozinha.BackColor = Color.Transparent;
            btnPedidosCozinha.BorderColor = Color.FromArgb(32, 34, 37);
            btnPedidosCozinha.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnPedidosCozinha.EnteredColor = Color.FromArgb(32, 34, 37);
            btnPedidosCozinha.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPedidosCozinha.Image = null;
            btnPedidosCozinha.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidosCozinha.InactiveColor = Color.FromArgb(61, 94, 94);
            btnPedidosCozinha.Location = new Point(358, 40);
            btnPedidosCozinha.Name = "btnPedidosCozinha";
            btnPedidosCozinha.PressedBorderColor = Color.Transparent;
            btnPedidosCozinha.PressedColor = Color.Transparent;
            btnPedidosCozinha.Size = new Size(151, 72);
            btnPedidosCozinha.TabIndex = 2;
            btnPedidosCozinha.Text = "Pedidos Cozinha";
            btnPedidosCozinha.TextAlignment = StringAlignment.Center;
            btnPedidosCozinha.Click += btnPedidosCozinha_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.Transparent;
            btnUsuarios.BorderColor = Color.FromArgb(32, 34, 37);
            btnUsuarios.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnUsuarios.EnteredColor = Color.FromArgb(32, 34, 37);
            btnUsuarios.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuarios.Image = null;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.InactiveColor = Color.FromArgb(61, 94, 94);
            btnUsuarios.Location = new Point(515, 40);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.PressedBorderColor = Color.Transparent;
            btnUsuarios.PressedColor = Color.Transparent;
            btnUsuarios.Size = new Size(151, 72);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.TextAlignment = StringAlignment.Center;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.BackColor = Color.Transparent;
            btnCardapio.BorderColor = Color.FromArgb(32, 34, 37);
            btnCardapio.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnCardapio.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCardapio.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCardapio.Image = null;
            btnCardapio.ImageAlign = ContentAlignment.MiddleLeft;
            btnCardapio.InactiveColor = Color.FromArgb(61, 94, 94);
            btnCardapio.Location = new Point(44, 40);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.PressedBorderColor = Color.Transparent;
            btnCardapio.PressedColor = Color.Transparent;
            btnCardapio.Size = new Size(151, 72);
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardapio";
            btnCardapio.TextAlignment = StringAlignment.Center;
            btnCardapio.Click += btnCardapio_Click;
            // 
            // btnComanda
            // 
            btnComanda.BackColor = Color.Transparent;
            btnComanda.BorderColor = Color.FromArgb(32, 34, 37);
            btnComanda.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnComanda.EnteredColor = Color.FromArgb(32, 34, 37);
            btnComanda.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComanda.Image = null;
            btnComanda.ImageAlign = ContentAlignment.MiddleLeft;
            btnComanda.InactiveColor = Color.FromArgb(61, 94, 94);
            btnComanda.Location = new Point(201, 40);
            btnComanda.Name = "btnComanda";
            btnComanda.PressedBorderColor = Color.Transparent;
            btnComanda.PressedColor = Color.Transparent;
            btnComanda.Size = new Size(151, 72);
            btnComanda.TabIndex = 1;
            btnComanda.Text = "Comanda";
            btnComanda.TextAlignment = StringAlignment.Center;
            btnComanda.Click += btnComanda_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BorderColor = Color.Transparent;
            button2.EnteredBorderColor = Color.Transparent;
            button2.EnteredColor = Color.Transparent;
            button2.Font = new Font("Segoe UI Symbol", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = null;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.InactiveColor = Color.Transparent;
            button2.Location = new Point(660, 0);
            button2.Name = "button2";
            button2.PressedBorderColor = Color.Transparent;
            button2.PressedColor = Color.Transparent;
            button2.Size = new Size(66, 26);
            button2.TabIndex = 5;
            button2.Text = "-";
            button2.TextAlignment = StringAlignment.Center;
            button2.Click += button2_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 448);
            Controls.Add(dreamForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1020);
            MinimumSize = new Size(261, 65);
            Name = "FrmPrincipal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dungeonForm1";
            TransparencyKey = Color.Fuchsia;
            dreamForm1.ResumeLayout(false);
            foreverGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DreamForm dreamForm1;
        private ReaLTaiizor.Controls.Button btnPedidosCozinha;
        private ReaLTaiizor.Controls.Button btnComanda;
        private ReaLTaiizor.Controls.Button btnCardapio;
        private ReaLTaiizor.Controls.Button btnUsuarios;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.Button button2;
    }
}
