﻿namespace AutoResende.View
{
    partial class frmCadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCliente));
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.Cad_clientes = new System.Windows.Forms.Label();
            this.Btn_Gravar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbltppessoa = new System.Windows.Forms.Label();
            this.lblcep = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblfantasia = new System.Windows.Forms.Label();
            this.txtfantasia = new System.Windows.Forms.TextBox();
            this.lbllogradouro = new System.Windows.Forms.Label();
            this.txtlogradouro = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.txt_inscEstadual = new System.Windows.Forms.TextBox();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.lblrg = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.lblbairro = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblpais = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txttel1 = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.cmbpais = new System.Windows.Forms.ComboBox();
            this.cmbtppessoa = new System.Windows.Forms.ComboBox();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.txtcel = new System.Windows.Forms.TextBox();
            this.lblcel = new System.Windows.Forms.Label();
            this.picimg_cliente = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Apagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picimg_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.Transparent;
            this.btnFechar.Location = new System.Drawing.Point(1329, 24);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(43, 37);
            this.btnFechar.TabIndex = 36;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFechar_MouseClick);
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.Location = new System.Drawing.Point(223, 139);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(65, 20);
            this.lblCódigo.TabIndex = 37;
            this.lblCódigo.Text = "Código";
            this.lblCódigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cad_clientes
            // 
            this.Cad_clientes.AutoSize = true;
            this.Cad_clientes.BackColor = System.Drawing.Color.Brown;
            this.Cad_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cad_clientes.ForeColor = System.Drawing.Color.White;
            this.Cad_clientes.Location = new System.Drawing.Point(214, 25);
            this.Cad_clientes.Name = "Cad_clientes";
            this.Cad_clientes.Size = new System.Drawing.Size(311, 36);
            this.Cad_clientes.TabIndex = 38;
            this.Cad_clientes.Text = "Cadastro de Clientes";
            this.Cad_clientes.Click += new System.EventHandler(this.label2_Click);
            // 
            // Btn_Gravar
            // 
            this.Btn_Gravar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_Gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Gravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Gravar.Location = new System.Drawing.Point(227, 690);
            this.Btn_Gravar.Name = "Btn_Gravar";
            this.Btn_Gravar.Size = new System.Drawing.Size(172, 39);
            this.Btn_Gravar.TabIndex = 40;
            this.Btn_Gravar.Text = "Gravar";
            this.Btn_Gravar.UseVisualStyleBackColor = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(335, 136);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(114, 26);
            this.txtCodigo.TabIndex = 41;
            // 
            // lbltppessoa
            // 
            this.lbltppessoa.AutoSize = true;
            this.lbltppessoa.BackColor = System.Drawing.Color.Transparent;
            this.lbltppessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltppessoa.Location = new System.Drawing.Point(225, 176);
            this.lbltppessoa.Name = "lbltppessoa";
            this.lbltppessoa.Size = new System.Drawing.Size(73, 20);
            this.lbltppessoa.TabIndex = 43;
            this.lbltppessoa.Text = "Fis / Jur";
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.BackColor = System.Drawing.Color.Transparent;
            this.lblcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcep.Location = new System.Drawing.Point(224, 254);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(41, 20);
            this.lblcep.TabIndex = 44;
            this.lblcep.Text = "Cep";
            this.lblcep.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.BackColor = System.Drawing.Color.Transparent;
            this.lblcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcidade.Location = new System.Drawing.Point(223, 292);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(65, 20);
            this.lblcidade.TabIndex = 46;
            this.lblcidade.Text = "Cidade";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.BackColor = System.Drawing.Color.Transparent;
            this.lbltel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.Location = new System.Drawing.Point(224, 365);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(88, 20);
            this.lbltel.TabIndex = 47;
            this.lbltel.Text = "Telefones";
            this.lbltel.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(716, 136);
            this.txtnome.MaxLength = 40;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(637, 26);
            this.txtnome.TabIndex = 49;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.Transparent;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(582, 142);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(55, 20);
            this.lblnome.TabIndex = 50;
            this.lblnome.Text = "Nome";
            this.lblnome.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblfantasia
            // 
            this.lblfantasia.AutoSize = true;
            this.lblfantasia.BackColor = System.Drawing.Color.Transparent;
            this.lblfantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfantasia.Location = new System.Drawing.Point(582, 218);
            this.lblfantasia.Name = "lblfantasia";
            this.lblfantasia.Size = new System.Drawing.Size(83, 20);
            this.lblfantasia.TabIndex = 55;
            this.lblfantasia.Text = "Dat Nasc";
            // 
            // txtfantasia
            // 
            this.txtfantasia.Location = new System.Drawing.Point(1070, 212);
            this.txtfantasia.MaxLength = 40;
            this.txtfantasia.Name = "txtfantasia";
            this.txtfantasia.Size = new System.Drawing.Size(281, 26);
            this.txtfantasia.TabIndex = 54;
            // 
            // lbllogradouro
            // 
            this.lbllogradouro.AutoSize = true;
            this.lbllogradouro.BackColor = System.Drawing.Color.Transparent;
            this.lbllogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogradouro.Location = new System.Drawing.Point(580, 294);
            this.lbllogradouro.Name = "lbllogradouro";
            this.lbllogradouro.Size = new System.Drawing.Size(101, 20);
            this.lbllogradouro.TabIndex = 57;
            this.lbllogradouro.Text = "Logradouro";
            // 
            // txtlogradouro
            // 
            this.txtlogradouro.Location = new System.Drawing.Point(716, 289);
            this.txtlogradouro.MaxLength = 40;
            this.txtlogradouro.Name = "txtlogradouro";
            this.txtlogradouro.Size = new System.Drawing.Size(637, 26);
            this.txtlogradouro.TabIndex = 56;
            this.txtlogradouro.TextChanged += new System.EventHandler(this.txt_endereço_TextChanged);
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(716, 176);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(217, 26);
            this.txt_cpf.TabIndex = 59;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.BackColor = System.Drawing.Color.Transparent;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(582, 179);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(43, 20);
            this.lblcpf.TabIndex = 58;
            this.lblcpf.Text = "CPF";
            // 
            // txt_inscEstadual
            // 
            this.txt_inscEstadual.Location = new System.Drawing.Point(335, 212);
            this.txt_inscEstadual.Name = "txt_inscEstadual";
            this.txt_inscEstadual.Size = new System.Drawing.Size(194, 26);
            this.txt_inscEstadual.TabIndex = 61;
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(1070, 176);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(217, 26);
            this.txt_rg.TabIndex = 63;
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.BackColor = System.Drawing.Color.Transparent;
            this.lblrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrg.Location = new System.Drawing.Point(1000, 179);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(36, 20);
            this.lblrg.TabIndex = 62;
            this.lblrg.Text = "RG";
            this.lblrg.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(1139, 329);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(217, 26);
            this.txtbairro.TabIndex = 67;
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.BackColor = System.Drawing.Color.Transparent;
            this.lblbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbairro.Location = new System.Drawing.Point(1061, 335);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(57, 20);
            this.lblbairro.TabIndex = 66;
            this.lblbairro.Text = "Bairro";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(225, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 64;
            this.label14.Text = "E-mail";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // lblpais
            // 
            this.lblpais.AutoSize = true;
            this.lblpais.BackColor = System.Drawing.Color.Transparent;
            this.lblpais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpais.Location = new System.Drawing.Point(1112, 368);
            this.lblpais.Name = "lblpais";
            this.lblpais.Size = new System.Drawing.Size(43, 20);
            this.lblpais.TabIndex = 70;
            this.lblpais.Text = "País";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.BackColor = System.Drawing.Color.Transparent;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(876, 373);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(66, 20);
            this.lblestado.TabIndex = 68;
            this.lblestado.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(222, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 26);
            this.label7.TabIndex = 76;
            this.label7.Text = "Comentários";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(229, 461);
            this.txtComentario.MaxLength = 40;
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(726, 211);
            this.txtComentario.TabIndex = 78;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(222, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(185, 26);
            this.label18.TabIndex = 80;
            this.label18.Text = "Dados Cadastrais";
            // 
            // txttel1
            // 
            this.txttel1.Location = new System.Drawing.Point(335, 362);
            this.txttel1.Name = "txttel1";
            this.txttel1.Size = new System.Drawing.Size(135, 26);
            this.txttel1.TabIndex = 81;
            this.txttel1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(334, 329);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(675, 26);
            this.txtemail.TabIndex = 83;
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(335, 251);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(194, 26);
            this.txtcep.TabIndex = 85;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(335, 288);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(194, 26);
            this.txtcidade.TabIndex = 86;
            // 
            // cmbpais
            // 
            this.cmbpais.FormattingEnabled = true;
            this.cmbpais.Items.AddRange(new object[] {
            "Afeganistão",
            "África do Sul",
            "Akrotiri",
            "Albânia",
            "Alemanha",
            "Andorra",
            "Angola",
            "Anguila",
            "Antárctida",
            "Antígua e Barbuda",
            "Antilhas Neerlandesas",
            "Arábia Saudita",
            "Arctic Ocean",
            "Argélia",
            "Argentina",
            "Arménia",
            "Aruba",
            "Ashmore and Cartier Islands",
            "Atlantic Ocean",
            "Austrália",
            "Áustria",
            "Azerbaijão",
            "Baamas",
            "Bangladeche",
            "Barbados",
            "Barém",
            "Bélgica",
            "Belize",
            "Benim",
            "Bermudas",
            "Bielorrússia",
            "Birmânia",
            "Bolívia",
            "Bósnia e Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunei",
            "Bulgária",
            "Burquina Faso",
            "Burúndi",
            "Butão",
            "Cabo Verde",
            "Camarões",
            "Camboja",
            "Canadá",
            "Catar",
            "Cazaquistão",
            "Chade",
            "Chile",
            "China",
            "Chipre",
            "Clipperton Island",
            "Colômbia",
            "Comores",
            "Congo-Brazzaville",
            "Congo-Kinshasa",
            "Coral Sea Islands",
            "Coreia do Norte",
            "Coreia do Sul",
            "Costa do Marfim",
            "Costa Rica",
            "Croácia",
            "Cuba",
            "Dhekelia",
            "Dinamarca",
            "Domínica",
            "Egipto",
            "Emiratos Árabes Unidos",
            "Equador",
            "Eritreia",
            "Eslováquia",
            "Eslovénia",
            "Espanha",
            "Estados Unidos",
            "Estónia",
            "Etiópia",
            "Faroé",
            "Fiji",
            "Filipinas",
            "Finlândia",
            "França",
            "Gabão",
            "Gâmbia",
            "Gana",
            "Gaza Strip",
            "Geórgia",
            "Geórgia do Sul e Sandwich do Sul",
            "Gibraltar",
            "Granada",
            "Grécia",
            "Gronelândia",
            "Guame",
            "Guatemala",
            "Guernsey",
            "Guiana",
            "Guiné",
            "Guiné Equatorial",
            "Guiné-Bissau",
            "Haiti",
            "Honduras",
            "Hong Kong",
            "Hungria",
            "Iémen",
            "Ilha Bouvet",
            "Ilha do Natal",
            "Ilha Norfolk",
            "Ilhas Caimão",
            "Ilhas Cook",
            "Ilhas dos Cocos",
            "Ilhas Falkland",
            "Ilhas Heard e McDonald",
            "Ilhas Marshall",
            "Ilhas Salomão",
            "Ilhas Turcas e Caicos",
            "Ilhas Virgens Americanas",
            "Ilhas Virgens Britânicas",
            "Índia",
            "Indian Ocean",
            "Indonésia",
            "Irão",
            "Iraque",
            "Irlanda",
            "Islândia",
            "Israel",
            "Itália",
            "Jamaica",
            "Jan Mayen",
            "Japão",
            "Jersey",
            "Jibuti",
            "Jordânia",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letónia",
            "Líbano",
            "Libéria",
            "Líbia",
            "Listenstaine",
            "Lituânia",
            "Luxemburgo",
            "Macau",
            "Macedónia",
            "Madagáscar",
            "Malásia",
            "Malávi",
            "Maldivas",
            "Mali",
            "Malta",
            "Man, Isle of",
            "Marianas do Norte",
            "Marrocos",
            "Maurícia",
            "Mauritânia",
            "Mayotte",
            "México",
            "Micronésia",
            "Moçambique",
            "Moldávia",
            "Mónaco",
            "Mongólia",
            "Monserrate",
            "Montenegro",
            "Mundo",
            "Namíbia",
            "Nauru",
            "Navassa Island",
            "Nepal",
            "Nicarágua",
            "Níger",
            "Nigéria",
            "Niue",
            "Noruega",
            "Nova Caledónia",
            "Nova Zelândia",
            "Omã",
            "Pacific Ocean",
            "Países Baixos",
            "Palau",
            "Panamá",
            "Papua-Nova Guiné",
            "Paquistão",
            "Paracel Islands",
            "Paraguai",
            "Peru",
            "Pitcairn",
            "Polinésia Francesa",
            "Polónia",
            "Porto Rico",
            "Portugal",
            "Quénia",
            "Quirguizistão",
            "Quiribáti",
            "Reino Unido",
            "República Centro-Africana",
            "República Checa",
            "República Dominicana",
            "Roménia",
            "Ruanda",
            "Rússia",
            "Salvador",
            "Samoa",
            "Samoa Americana",
            "Santa Helena",
            "Santa Lúcia",
            "São Cristóvão e Neves",
            "São Marinho",
            "São Pedro e Miquelon",
            "São Tomé e Príncipe",
            "São Vicente e Granadinas",
            "Sara Ocidental",
            "Seicheles",
            "Senegal",
            "Serra Leoa",
            "Sérvia",
            "Singapura",
            "Síria",
            "Somália",
            "Southern Ocean",
            "Spratly Islands",
            "Sri Lanca",
            "Suazilândia",
            "Sudão",
            "Suécia",
            "Suíça",
            "Suriname",
            "Svalbard e Jan Mayen",
            "Tailândia",
            "Taiwan",
            "Tajiquistão",
            "Tanzânia",
            "Território Britânico do Oceano Índico",
            "Territórios Austrais Franceses",
            "Timor Leste",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trindade e Tobago",
            "Tunísia",
            "Turquemenistão",
            "Turquia",
            "Tuvalu",
            "Ucrânia",
            "Uganda",
            "União Europeia",
            "Uruguai",
            "Usbequistão",
            "Vanuatu",
            "Vaticano",
            "Venezuela",
            "Vietname",
            "Wake Island",
            "Wallis e Futuna",
            "West Bank",
            "Zâmbia",
            "Zimbabué"});
            this.cmbpais.Location = new System.Drawing.Point(1191, 365);
            this.cmbpais.Name = "cmbpais";
            this.cmbpais.Size = new System.Drawing.Size(163, 28);
            this.cmbpais.TabIndex = 88;
            // 
            // cmbtppessoa
            // 
            this.cmbtppessoa.FormattingEnabled = true;
            this.cmbtppessoa.Items.AddRange(new object[] {
            "Físico",
            "Jurídico"});
            this.cmbtppessoa.Location = new System.Drawing.Point(332, 173);
            this.cmbtppessoa.Name = "cmbtppessoa";
            this.cmbtppessoa.Size = new System.Drawing.Size(193, 28);
            this.cmbtppessoa.TabIndex = 90;
            // 
            // cmbestado
            // 
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP ",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC\t ",
            "SP\t ",
            "SE\t ",
            "TO"});
            this.cmbestado.Location = new System.Drawing.Point(971, 367);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(105, 28);
            this.cmbestado.TabIndex = 91;
            // 
            // txtcel
            // 
            this.txtcel.Location = new System.Drawing.Point(716, 365);
            this.txtcel.Name = "txtcel";
            this.txtcel.Size = new System.Drawing.Size(135, 26);
            this.txtcel.TabIndex = 92;
            // 
            // lblcel
            // 
            this.lblcel.AutoSize = true;
            this.lblcel.BackColor = System.Drawing.Color.Transparent;
            this.lblcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcel.Location = new System.Drawing.Point(650, 370);
            this.lblcel.Name = "lblcel";
            this.lblcel.Size = new System.Drawing.Size(35, 20);
            this.lblcel.TabIndex = 93;
            this.lblcel.Text = "Cel";
            this.lblcel.Click += new System.EventHandler(this.label19_Click);
            // 
            // picimg_cliente
            // 
            this.picimg_cliente.BackColor = System.Drawing.Color.Transparent;
            this.picimg_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picimg_cliente.Image = ((System.Drawing.Image)(resources.GetObject("picimg_cliente.Image")));
            this.picimg_cliente.Location = new System.Drawing.Point(41, 25);
            this.picimg_cliente.Name = "picimg_cliente";
            this.picimg_cliente.Size = new System.Drawing.Size(128, 128);
            this.picimg_cliente.TabIndex = 94;
            this.picimg_cliente.TabStop = false;
            this.picimg_cliente.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Brown;
            this.pictureBox2.Location = new System.Drawing.Point(1, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1384, 70);
            this.pictureBox2.TabIndex = 95;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Brown;
            this.pictureBox1.Location = new System.Drawing.Point(228, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1123, 10);
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Brown;
            this.pictureBox3.Location = new System.Drawing.Point(229, 440);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(727, 10);
            this.pictureBox3.TabIndex = 97;
            this.pictureBox3.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(716, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 26);
            this.dateTimePicker1.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(976, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 99;
            this.label1.Text = "Org Exp.";
            // 
            // Btn_Apagar
            // 
            this.Btn_Apagar.BackColor = System.Drawing.Color.Salmon;
            this.Btn_Apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Apagar.Location = new System.Drawing.Point(443, 690);
            this.Btn_Apagar.Name = "Btn_Apagar";
            this.Btn_Apagar.Size = new System.Drawing.Size(172, 39);
            this.Btn_Apagar.TabIndex = 53;
            this.Btn_Apagar.Text = "Apagar";
            this.Btn_Apagar.UseVisualStyleBackColor = false;
            this.Btn_Apagar.Click += new System.EventHandler(this.Btn_Apagar_Click);
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1383, 780);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picimg_cliente);
            this.Controls.Add(this.lblcel);
            this.Controls.Add(this.txtcel);
            this.Controls.Add(this.cmbestado);
            this.Controls.Add(this.cmbtppessoa);
            this.Controls.Add(this.cmbpais);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblpais);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.lblrg);
            this.Controls.Add(this.txt_inscEstadual);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lbllogradouro);
            this.Controls.Add(this.txtlogradouro);
            this.Controls.Add(this.lblfantasia);
            this.Controls.Add(this.txtfantasia);
            this.Controls.Add(this.Btn_Apagar);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.lbltppessoa);
            this.Controls.Add(this.Btn_Gravar);
            this.Controls.Add(this.Cad_clientes);
            this.Controls.Add(this.lblCódigo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttel1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroCliente";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picimg_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.Label Cad_clientes;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbltppessoa;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button Btn_Gravar;
        private System.Windows.Forms.Label lblfantasia;
        private System.Windows.Forms.TextBox txtfantasia;
        private System.Windows.Forms.Label lbllogradouro;
        private System.Windows.Forms.TextBox txtlogradouro;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox txt_inscEstadual;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblpais;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txttel1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.ComboBox cmbpais;
        private System.Windows.Forms.ComboBox cmbtppessoa;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.TextBox txtcel;
        private System.Windows.Forms.Label lblcel;
        private System.Windows.Forms.PictureBox picimg_cliente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Apagar;
    }
}