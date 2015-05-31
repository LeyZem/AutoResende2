namespace AutoResende.View
{
    partial class frmCadastroFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFornecedor));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picimg_cliente = new System.Windows.Forms.PictureBox();
            this.lblcel = new System.Windows.Forms.Label();
            this.txtcel = new System.Windows.Forms.TextBox();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.cmbpais = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblpais = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lblbairro = new System.Windows.Forms.Label();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.lblrg = new System.Windows.Forms.Label();
            this.txt_inscEstadual = new System.Windows.Forms.TextBox();
            this.lblinscestadual = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lbllogradouro = new System.Windows.Forms.Label();
            this.txt_endereço = new System.Windows.Forms.TextBox();
            this.lblfantasia = new System.Windows.Forms.Label();
            this.txtfantasia = new System.Windows.Forms.TextBox();
            this.Btn_Apagar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lblcep = new System.Windows.Forms.Label();
            this.lblCnPJ = new System.Windows.Forms.Label();
            this.Btn_Gravar = new System.Windows.Forms.Button();
            this.lblfornecedor = new System.Windows.Forms.Label();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txttel2 = new System.Windows.Forms.TextBox();
            this.txttel1 = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimg_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Blue;
            this.pictureBox3.Location = new System.Drawing.Point(224, 463);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(727, 10);
            this.pictureBox3.TabIndex = 146;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Blue;
            this.pictureBox1.Location = new System.Drawing.Point(223, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1123, 10);
            this.pictureBox1.TabIndex = 145;
            this.pictureBox1.TabStop = false;
            // 
            // picimg_cliente
            // 
            this.picimg_cliente.BackColor = System.Drawing.Color.Transparent;
            this.picimg_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picimg_cliente.Image = ((System.Drawing.Image)(resources.GetObject("picimg_cliente.Image")));
            this.picimg_cliente.Location = new System.Drawing.Point(36, 48);
            this.picimg_cliente.Name = "picimg_cliente";
            this.picimg_cliente.Size = new System.Drawing.Size(128, 128);
            this.picimg_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picimg_cliente.TabIndex = 143;
            this.picimg_cliente.TabStop = false;
            // 
            // lblcel
            // 
            this.lblcel.AutoSize = true;
            this.lblcel.BackColor = System.Drawing.Color.Transparent;
            this.lblcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcel.Location = new System.Drawing.Point(645, 393);
            this.lblcel.Name = "lblcel";
            this.lblcel.Size = new System.Drawing.Size(35, 20);
            this.lblcel.TabIndex = 142;
            this.lblcel.Text = "Cel";
            // 
            // txtcel
            // 
            this.txtcel.Location = new System.Drawing.Point(711, 388);
            this.txtcel.Name = "txtcel";
            this.txtcel.Size = new System.Drawing.Size(135, 26);
            this.txtcel.TabIndex = 141;
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
            this.cmbestado.Location = new System.Drawing.Point(966, 390);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(105, 28);
            this.cmbestado.TabIndex = 140;
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
            this.cmbpais.Location = new System.Drawing.Point(1186, 388);
            this.cmbpais.Name = "cmbpais";
            this.cmbpais.Size = new System.Drawing.Size(163, 28);
            this.cmbpais.TabIndex = 137;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(217, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(185, 26);
            this.label18.TabIndex = 131;
            this.label18.Text = "Dados Cadastrais";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 484);
            this.textBox1.MaxLength = 40;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(726, 246);
            this.textBox1.TabIndex = 130;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(217, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 26);
            this.label7.TabIndex = 129;
            this.label7.Text = "Comentários";
            // 
            // lblpais
            // 
            this.lblpais.AutoSize = true;
            this.lblpais.BackColor = System.Drawing.Color.Transparent;
            this.lblpais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpais.Location = new System.Drawing.Point(1107, 391);
            this.lblpais.Name = "lblpais";
            this.lblpais.Size = new System.Drawing.Size(43, 20);
            this.lblpais.TabIndex = 128;
            this.lblpais.Text = "País";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.BackColor = System.Drawing.Color.Transparent;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(871, 396);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(66, 20);
            this.lblestado.TabIndex = 127;
            this.lblestado.Text = "Estado";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(1134, 352);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(217, 26);
            this.txt_bairro.TabIndex = 126;
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.BackColor = System.Drawing.Color.Transparent;
            this.lblbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbairro.Location = new System.Drawing.Point(1056, 358);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(57, 20);
            this.lblbairro.TabIndex = 125;
            this.lblbairro.Text = "Bairro";
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(780, 352);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(251, 26);
            this.txt_complemento.TabIndex = 124;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(645, 355);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 20);
            this.label14.TabIndex = 123;
            this.label14.Text = "Complemento";
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(1065, 235);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(217, 26);
            this.txt_rg.TabIndex = 122;
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.BackColor = System.Drawing.Color.Transparent;
            this.lblrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrg.Location = new System.Drawing.Point(995, 238);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(36, 20);
            this.lblrg.TabIndex = 121;
            this.lblrg.Text = "RG";
            // 
            // txt_inscEstadual
            // 
            this.txt_inscEstadual.Location = new System.Drawing.Point(330, 232);
            this.txt_inscEstadual.Name = "txt_inscEstadual";
            this.txt_inscEstadual.Size = new System.Drawing.Size(194, 26);
            this.txt_inscEstadual.TabIndex = 120;
            // 
            // lblinscestadual
            // 
            this.lblinscestadual.AutoSize = true;
            this.lblinscestadual.BackColor = System.Drawing.Color.Transparent;
            this.lblinscestadual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinscestadual.Location = new System.Drawing.Point(218, 235);
            this.lblinscestadual.Name = "lblinscestadual";
            this.lblinscestadual.Size = new System.Drawing.Size(76, 20);
            this.lblinscestadual.TabIndex = 119;
            this.lblinscestadual.Text = "Ins. Est.";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(711, 235);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(217, 26);
            this.txt_cpf.TabIndex = 118;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.BackColor = System.Drawing.Color.Transparent;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(577, 238);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(43, 20);
            this.lblcpf.TabIndex = 117;
            this.lblcpf.Text = "CPF";
            // 
            // lbllogradouro
            // 
            this.lbllogradouro.AutoSize = true;
            this.lbllogradouro.BackColor = System.Drawing.Color.Transparent;
            this.lbllogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogradouro.Location = new System.Drawing.Point(575, 317);
            this.lbllogradouro.Name = "lbllogradouro";
            this.lbllogradouro.Size = new System.Drawing.Size(101, 20);
            this.lbllogradouro.TabIndex = 116;
            this.lbllogradouro.Text = "Logradouro";
            // 
            // txt_endereço
            // 
            this.txt_endereço.Location = new System.Drawing.Point(711, 312);
            this.txt_endereço.MaxLength = 40;
            this.txt_endereço.Name = "txt_endereço";
            this.txt_endereço.Size = new System.Drawing.Size(637, 26);
            this.txt_endereço.TabIndex = 115;
            // 
            // lblfantasia
            // 
            this.lblfantasia.AutoSize = true;
            this.lblfantasia.BackColor = System.Drawing.Color.Transparent;
            this.lblfantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfantasia.Location = new System.Drawing.Point(577, 204);
            this.lblfantasia.Name = "lblfantasia";
            this.lblfantasia.Size = new System.Drawing.Size(79, 20);
            this.lblfantasia.TabIndex = 114;
            this.lblfantasia.Text = "Fantasia";
            // 
            // txtfantasia
            // 
            this.txtfantasia.Location = new System.Drawing.Point(711, 198);
            this.txtfantasia.MaxLength = 40;
            this.txtfantasia.Name = "txtfantasia";
            this.txtfantasia.Size = new System.Drawing.Size(637, 26);
            this.txtfantasia.TabIndex = 113;
            // 
            // Btn_Apagar
            // 
            this.Btn_Apagar.BackColor = System.Drawing.Color.Salmon;
            this.Btn_Apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Apagar.Location = new System.Drawing.Point(802, 750);
            this.Btn_Apagar.Name = "Btn_Apagar";
            this.Btn_Apagar.Size = new System.Drawing.Size(172, 39);
            this.Btn_Apagar.TabIndex = 112;
            this.Btn_Apagar.Text = "Apagar";
            this.Btn_Apagar.UseVisualStyleBackColor = false;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Buscar.Location = new System.Drawing.Point(614, 750);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(172, 39);
            this.Btn_Buscar.TabIndex = 111;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Novo.Location = new System.Drawing.Point(420, 750);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(172, 39);
            this.Btn_Novo.TabIndex = 110;
            this.Btn_Novo.Text = "Novo";
            this.Btn_Novo.UseVisualStyleBackColor = false;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.Transparent;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(577, 165);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(115, 20);
            this.lblnome.TabIndex = 109;
            this.lblnome.Text = "Razão Social";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(711, 159);
            this.txtnome.MaxLength = 40;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(637, 26);
            this.txtnome.TabIndex = 108;
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.BackColor = System.Drawing.Color.Transparent;
            this.lbltel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.Location = new System.Drawing.Point(219, 388);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(88, 20);
            this.lbltel.TabIndex = 107;
            this.lbltel.Text = "Telefones";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.BackColor = System.Drawing.Color.Transparent;
            this.lblcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcidade.Location = new System.Drawing.Point(218, 315);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(65, 20);
            this.lblcidade.TabIndex = 106;
            this.lblcidade.Text = "Cidade";
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.BackColor = System.Drawing.Color.Transparent;
            this.lblcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcep.Location = new System.Drawing.Point(219, 277);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(41, 20);
            this.lblcep.TabIndex = 105;
            this.lblcep.Text = "Cep";
            // 
            // lblCnPJ
            // 
            this.lblCnPJ.AutoSize = true;
            this.lblCnPJ.BackColor = System.Drawing.Color.Transparent;
            this.lblCnPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnPJ.Location = new System.Drawing.Point(220, 204);
            this.lblCnPJ.Name = "lblCnPJ";
            this.lblCnPJ.Size = new System.Drawing.Size(53, 20);
            this.lblCnPJ.TabIndex = 104;
            this.lblCnPJ.Text = "CNPJ";
            // 
            // Btn_Gravar
            // 
            this.Btn_Gravar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_Gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Gravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Gravar.Location = new System.Drawing.Point(224, 750);
            this.Btn_Gravar.Name = "Btn_Gravar";
            this.Btn_Gravar.Size = new System.Drawing.Size(172, 39);
            this.Btn_Gravar.TabIndex = 101;
            this.Btn_Gravar.Text = "Gravar";
            this.Btn_Gravar.UseVisualStyleBackColor = false;
            // 
            // lblfornecedor
            // 
            this.lblfornecedor.AutoSize = true;
            this.lblfornecedor.BackColor = System.Drawing.Color.Blue;
            this.lblfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfornecedor.ForeColor = System.Drawing.Color.White;
            this.lblfornecedor.Location = new System.Drawing.Point(209, 48);
            this.lblfornecedor.Name = "lblfornecedor";
            this.lblfornecedor.Size = new System.Drawing.Size(392, 36);
            this.lblfornecedor.TabIndex = 100;
            this.lblfornecedor.Text = "Cadastro de Fornecedores";
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.Location = new System.Drawing.Point(218, 162);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(65, 20);
            this.lblCódigo.TabIndex = 99;
            this.lblCódigo.Text = "Código";
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
            this.btnFechar.Location = new System.Drawing.Point(1368, 48);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(43, 37);
            this.btnFechar.TabIndex = 98;
            this.btnFechar.UseVisualStyleBackColor = false;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(330, 311);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(194, 26);
            this.txtnumero.TabIndex = 136;
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(330, 274);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(194, 26);
            this.txtcep.TabIndex = 135;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(330, 348);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(303, 26);
            this.txtcidade.TabIndex = 134;
            // 
            // txttel2
            // 
            this.txttel2.Location = new System.Drawing.Point(498, 385);
            this.txttel2.Name = "txttel2";
            this.txttel2.Size = new System.Drawing.Size(135, 26);
            this.txttel2.TabIndex = 133;
            // 
            // txttel1
            // 
            this.txttel1.Location = new System.Drawing.Point(330, 385);
            this.txttel1.Name = "txttel1";
            this.txttel1.Size = new System.Drawing.Size(135, 26);
            this.txttel1.TabIndex = 132;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(330, 159);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(114, 26);
            this.txt_Codigo.TabIndex = 102;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Blue;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1441, 70);
            this.pictureBox2.TabIndex = 144;
            this.pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(330, 198);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 26);
            this.textBox2.TabIndex = 147;
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1433, 815);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picimg_cliente);
            this.Controls.Add(this.lblcel);
            this.Controls.Add(this.txtcel);
            this.Controls.Add(this.cmbestado);
            this.Controls.Add(this.cmbpais);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblpais);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.txt_complemento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.lblrg);
            this.Controls.Add(this.txt_inscEstadual);
            this.Controls.Add(this.lblinscestadual);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lbllogradouro);
            this.Controls.Add(this.txt_endereço);
            this.Controls.Add(this.lblfantasia);
            this.Controls.Add(this.txtfantasia);
            this.Controls.Add(this.Btn_Apagar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_Novo);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.lblCnPJ);
            this.Controls.Add(this.Btn_Gravar);
            this.Controls.Add(this.lblfornecedor);
            this.Controls.Add(this.lblCódigo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txttel2);
            this.Controls.Add(this.txttel1);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadastroFornecedor";
            this.Text = "frmCadastroFornecedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimg_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picimg_cliente;
        private System.Windows.Forms.Label lblcel;
        private System.Windows.Forms.TextBox txtcel;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.ComboBox cmbpais;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblpais;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.TextBox txt_inscEstadual;
        private System.Windows.Forms.Label lblinscestadual;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lbllogradouro;
        private System.Windows.Forms.TextBox txt_endereço;
        private System.Windows.Forms.Label lblfantasia;
        private System.Windows.Forms.TextBox txtfantasia;
        private System.Windows.Forms.Button Btn_Apagar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.Label lblCnPJ;
        private System.Windows.Forms.Button Btn_Gravar;
        private System.Windows.Forms.Label lblfornecedor;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txttel2;
        private System.Windows.Forms.TextBox txttel1;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox2;
    }
}