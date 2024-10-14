namespace BalanceCheckerWin
{
	// Token: 0x02000004 RID: 4
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000891 RID: 2193 RVA: 0x00002508 File Offset: 0x00000708
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00017C40 File Offset: 0x00015E40
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BalanceCheckerWin.Form1));
			this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.timeInterval = new global::DevExpress.XtraEditors.SpinEdit();
			this.cAddress = new global::DevExpress.XtraEditors.SpinEdit();
			this.simpleButton1 = new global::DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new global::DevExpress.XtraEditors.SimpleButton();
			this.openFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.simpleButton3 = new global::DevExpress.XtraEditors.SimpleButton();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.checkedListBoxControl1 = new global::DevExpress.XtraEditors.CheckedListBoxControl();
			this.label8 = new global::System.Windows.Forms.Label();
			this.seededit = new global::DevExpress.XtraEditors.CheckEdit();
			this.privkeyedit = new global::DevExpress.XtraEditors.CheckEdit();
			this.saveFileExcel = new global::DevExpress.XtraEditors.SimpleButton();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.simpleButton4 = new global::DevExpress.XtraEditors.SimpleButton();
			this.simpleButton5 = new global::DevExpress.XtraEditors.SimpleButton();
			this.btcf = new global::System.Windows.Forms.TextBox();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.main_set = new global::System.Windows.Forms.TabPage();
			this.balance_f = new global::System.Windows.Forms.TabPage();
			this.label35 = new global::System.Windows.Forms.Label();
			this.axief = new global::System.Windows.Forms.TextBox();
			this.label32 = new global::System.Windows.Forms.Label();
			this.ronintf = new global::System.Windows.Forms.TextBox();
			this.label33 = new global::System.Windows.Forms.Label();
			this.snowtf = new global::System.Windows.Forms.TextBox();
			this.label34 = new global::System.Windows.Forms.Label();
			this.moontf = new global::System.Windows.Forms.TextBox();
			this.label31 = new global::System.Windows.Forms.Label();
			this.roninf = new global::System.Windows.Forms.TextBox();
			this.label30 = new global::System.Windows.Forms.Label();
			this.snowf = new global::System.Windows.Forms.TextBox();
			this.label29 = new global::System.Windows.Forms.Label();
			this.moonf = new global::System.Windows.Forms.TextBox();
			this.label23 = new global::System.Windows.Forms.Label();
			this.opttf = new global::System.Windows.Forms.TextBox();
			this.label24 = new global::System.Windows.Forms.Label();
			this.optimisticf = new global::System.Windows.Forms.TextBox();
			this.label25 = new global::System.Windows.Forms.Label();
			this.arbtf = new global::System.Windows.Forms.TextBox();
			this.label26 = new global::System.Windows.Forms.Label();
			this.arbitrumf = new global::System.Windows.Forms.TextBox();
			this.label27 = new global::System.Windows.Forms.Label();
			this.polytf = new global::System.Windows.Forms.TextBox();
			this.label28 = new global::System.Windows.Forms.Label();
			this.maticf = new global::System.Windows.Forms.TextBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.hectf = new global::System.Windows.Forms.TextBox();
			this.label18 = new global::System.Windows.Forms.Label();
			this.hecof = new global::System.Windows.Forms.TextBox();
			this.label19 = new global::System.Windows.Forms.Label();
			this.fttf = new global::System.Windows.Forms.TextBox();
			this.label20 = new global::System.Windows.Forms.Label();
			this.ftmf = new global::System.Windows.Forms.TextBox();
			this.label21 = new global::System.Windows.Forms.Label();
			this.bepf = new global::System.Windows.Forms.TextBox();
			this.label22 = new global::System.Windows.Forms.Label();
			this.bscf = new global::System.Windows.Forms.TextBox();
			this.label16 = new global::System.Windows.Forms.Label();
			this.ercf = new global::System.Windows.Forms.TextBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.ethf = new global::System.Windows.Forms.TextBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.dashf = new global::System.Windows.Forms.TextBox();
			this.label13 = new global::System.Windows.Forms.Label();
			this.bchf = new global::System.Windows.Forms.TextBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.ltcf = new global::System.Windows.Forms.TextBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.tg_set = new global::System.Windows.Forms.TabPage();
			this.chatid = new global::System.Windows.Forms.TextBox();
			this.label37 = new global::System.Windows.Forms.Label();
			this.label36 = new global::System.Windows.Forms.Label();
			this.apib = new global::System.Windows.Forms.TextBox();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.timeInterval.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cAddress.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.checkedListBoxControl1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.seededit.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.privkeyedit.Properties).BeginInit();
			this.tabControl1.SuspendLayout();
			this.main_set.SuspendLayout();
			this.balance_f.SuspendLayout();
			this.tg_set.SuspendLayout();
			base.SuspendLayout();
			this.dataGridView1.AllowUserToAddRows = (global::<Module>.艾埃艾留留() != 0);
			this.dataGridView1.AllowUserToDeleteRows = (global::<Module>.留豆大大留() != 0);
			this.dataGridView1.AllowUserToResizeRows = (global::<Module>.大大豆波大() != 0);
			this.dataGridView1.Anchor = (global::System.Windows.Forms.AnchorStyles)global::<Module>.波儿波艾豆();
			dataGridViewCellStyle.Alignment = (global::System.Windows.Forms.DataGridViewContentAlignment)global::<Module>.艾大留克埃();
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("ṄṠṪṻṦṺṦṯṽḩṚṨṧṺḩṚṬṻṠṯ", global::<Module>.艾豆儿埃波()), (float)global::<Module>.克留斯艾斯(), (global::System.Drawing.FontStyle)global::<Module>.艾留豆克艾(), (global::System.Drawing.GraphicsUnit)global::<Module>.留斯留留大(), (byte)global::<Module>.艾艾克艾留());
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = (global::System.Windows.Forms.DataGridViewTriState)global::<Module>.波留儿豆斯();
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView1.ColumnHeadersHeightSizeMode = (global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)global::<Module>.大克留留留();
			this.dataGridView1.Location = new global::System.Drawing.Point(global::<Module>.留斯斯豆波(), global::<Module>.波克大艾波());
			this.dataGridView1.Name = global::<Module>.ZExtO("痵痰痥痰痖痣痸痵症痸痴痦疠", global::<Module>.艾儿斯埃埃());
			dataGridViewCellStyle2.Alignment = (global::System.Windows.Forms.DataGridViewContentAlignment)global::<Module>.波波波波留();
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("湴湐湚湋湖湊湖湟湍渙湪湘湗湊渙湪湜湋湐湟", global::<Module>.埃波克艾埃()), (float)global::<Module>.斯斯大波留(), (global::System.Drawing.FontStyle)global::<Module>.波波留斯埃(), (global::System.Drawing.GraphicsUnit)global::<Module>.艾豆艾波豆(), (byte)global::<Module>.留斯艾波留());
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = (global::System.Windows.Forms.DataGridViewTriState)global::<Module>.儿艾艾留留();
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.RowHeadersVisible = (global::<Module>.留波儿豆留() != 0);
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("秕秱移秪秷秫秷秾秬禸秋秹秶秫禸秋秽秪秱秾", global::<Module>.波克儿留艾()), (float)global::<Module>.斯波留儿大(), (global::System.Drawing.FontStyle)global::<Module>.斯克埃埃留(), (global::System.Drawing.GraphicsUnit)global::<Module>.波克艾留豆(), (byte)global::<Module>.波斯大儿波());
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.SelectionMode = (global::System.Windows.Forms.DataGridViewSelectionMode)global::<Module>.艾儿波艾波();
			this.dataGridView1.Size = new global::System.Drawing.Size(global::<Module>.儿儿留波斯(), global::<Module>.波大波斯波());
			this.dataGridView1.TabIndex = global::<Module>.儿大留留儿();
			this.label1.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("层屦屬屽屠屼屠屩屻尯屜屮屡屼尯屜屪屽屦屩", global::<Module>.留艾艾大留()), (float)global::<Module>.波克留埃埃(), (global::System.Drawing.FontStyle)global::<Module>.艾留豆波豆(), (global::System.Drawing.GraphicsUnit)global::<Module>.留波大大艾(), (byte)global::<Module>.留艾艾波埃());
			this.label1.Location = new global::System.Drawing.Point(global::<Module>.埃波波克斯(), global::<Module>.波大留埃豆());
			this.label1.Name = global::<Module>.ZExtO("챵챸챻챼챵차", global::<Module>.豆埃克克豆());
			this.label1.Size = new global::System.Drawing.Size(global::<Module>.艾留留大儿(), global::<Module>.艾波大斯斯());
			this.label1.TabIndex = global::<Module>.大豆艾留克();
			this.label1.Text = global::<Module>.ZExtO("\ud893\ud8b0\ud8be\ud8bb\ud8ff\ud8ac\ud8ba\ud8ba\ud8bb\ud8f0\ud8af\ud8ad\ud8b6\ud8a9\ud8be\ud8ab\ud8ba\ud8b4\ud8ba\ud8a6\ud8ff\ud8b0\ud8b1\ud8ba\ud8ff\ud8bd\ud8a6\ud8ff\ud8b0\ud8b1\ud8ba\ud8f3\ud8ff\ud89c\ud8b3\ud8b6\ud8bc\ud8b4\ud8ff\ud8bc\ud8b7\ud8ba\ud8bc\ud8b4\ud8f3\ud8ff\ud896\ud8ab\ud8ff\ud8a8\ud8b6\ud8b3\ud8b3\ud8ff\ud8ac\ud8b7\ud8b0\ud8a8\ud8ff\ud8bd\ud8ba\ud8b3\ud8b0\ud8a8\ud8ff\ud8ab\ud8be\ud8bd\ud8b3\ud8ba", global::<Module>.留埃波斯波());
			this.label2.AutoSize = (global::<Module>.埃波儿波儿() != 0);
			this.label2.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("쯶쯒쯘쯉쯔쯈쯔쯝쯏쮛쯨쯚쯕쯈쮛쯨쯞쯉쯒쯝", global::<Module>.斯豆留留埃()), (float)global::<Module>.留斯斯大埃());
			this.label2.Location = new global::System.Drawing.Point(global::<Module>.儿克斯埃留(), global::<Module>.儿埃克豆豆());
			this.label2.Name = global::<Module>.ZExtO("也乒乑乖也丁", global::<Module>.波儿埃豆埃());
			this.label2.Size = new global::System.Drawing.Size(global::<Module>.豆斯留儿豆(), global::<Module>.波克波儿留());
			this.label2.TabIndex = global::<Module>.儿留波斯波();
			this.label2.Text = global::<Module>.ZExtO("Ҧҁҙӎ҃ҏҀҗӎҏҊҊҜҋҝҝӎ҈Ҝҁ҃ӎҝҋҋҊӎӆҊҋ҈ҏқ҂ҚӔӎӟӇ", global::<Module>.埃波大波波());
			this.label3.AutoSize = (global::<Module>.波波波波波() != 0);
			this.label3.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("", global::<Module>.豆儿波波斯()), (float)global::<Module>.艾留豆留埃());
			this.label3.Location = new global::System.Drawing.Point(global::<Module>.斯波艾大大(), global::<Module>.艾大艾艾留());
			this.label3.Name = global::<Module>.ZExtO("䵚䵗䵔䵓䵚䴅", global::<Module>.克斯留斯豆());
			this.label3.Size = new global::System.Drawing.Size(global::<Module>.儿波大留大(), global::<Module>.斯留克留埃());
			this.label3.TabIndex = global::<Module>.克波豆留留();
			this.label3.Text = global::<Module>.ZExtO("㊞㊣㊧㊯㋪㊣㊤㊾㊯㊸㊼㊫㊦㋪㊾㊥㋪㊩㊢㊯㊩㊡㋪㊫㊮㊮㊸㊯㊹㊹㊯㊹㋪㊣㊤㋪㊹㊯㊩㊥㊤㊮㊹㋪㋢㊮㊯㊬㊫㊿㊦㊾㋰㋪㋻㋿㊹㋣", global::<Module>.波留大克留());
			global::DevExpress.XtraEditors.BaseEdit baseEdit = this.timeInterval;
			int[] array = new int[global::<Module>.儿克埃波留()];
			array[global::<Module>.波克克豆艾()] = global::<Module>.儿波艾留留();
			baseEdit.EditValue = new decimal(array);
			this.timeInterval.Location = new global::System.Drawing.Point(global::<Module>.斯艾波克留(), global::<Module>.儿大儿大斯());
			this.timeInterval.Name = global::<Module>.ZExtO("粖粋粏粇粫粌粖粇粐粔粃粎", global::<Module>.斯波埃儿埃());
			global::DevExpress.XtraEditors.Controls.EditorButtonCollection buttons = this.timeInterval.Properties.Buttons;
			global::DevExpress.XtraEditors.Controls.EditorButton[] array2 = new global::DevExpress.XtraEditors.Controls.EditorButton[global::<Module>.儿豆波儿大()];
			array2[global::<Module>.留大留儿豆()] = new global::DevExpress.XtraEditors.Controls.EditorButton((global::DevExpress.XtraEditors.Controls.ButtonPredefines)global::<Module>.埃大克大大());
			buttons.AddRange(array2);
			global::DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit properties = this.timeInterval.Properties;
			int[] array3 = new int[global::<Module>.大波埃豆儿()];
			array3[global::<Module>.克克克斯留()] = global::<Module>.大留儿斯艾();
			properties.Increment = new decimal(array3);
			this.timeInterval.Properties.IsFloatValue = (global::<Module>.豆克留留豆() != 0);
			this.timeInterval.Properties.Mask.EditMask = global::<Module>.ZExtO("갬걒걒", global::<Module>.波埃留艾豆());
			this.timeInterval.Size = new global::System.Drawing.Size(global::<Module>.留波波斯留(), global::<Module>.大克大豆留());
			this.timeInterval.TabIndex = global::<Module>.波大克豆豆();
			this.timeInterval.EditValueChanged += new global::System.EventHandler(this.timeInterval_EditValueChanged);
			global::DevExpress.XtraEditors.BaseEdit baseEdit2 = this.cAddress;
			int[] array4 = new int[global::<Module>.艾波留留豆()];
			array4[global::<Module>.埃儿儿埃豆()] = global::<Module>.豆留大波艾();
			baseEdit2.EditValue = new decimal(array4);
			this.cAddress.Location = new global::System.Drawing.Point(global::<Module>.大豆留豆留(), global::<Module>.波大豆波留());
			this.cAddress.Name = global::<Module>.ZExtO("흇흥흀흀흖흁흗흗", global::<Module>.斯克波大斯());
			global::DevExpress.XtraEditors.Controls.EditorButtonCollection buttons2 = this.cAddress.Properties.Buttons;
			global::DevExpress.XtraEditors.Controls.EditorButton[] array5 = new global::DevExpress.XtraEditors.Controls.EditorButton[global::<Module>.儿豆留豆波()];
			array5[global::<Module>.豆留埃儿豆()] = new global::DevExpress.XtraEditors.Controls.EditorButton((global::DevExpress.XtraEditors.Controls.ButtonPredefines)global::<Module>.斯克儿斯豆());
			buttons2.AddRange(array5);
			this.cAddress.Properties.EditFormat.FormatType = (global::DevExpress.Utils.FormatType)global::<Module>.波留豆大艾();
			this.cAddress.Properties.IsFloatValue = (global::<Module>.留留克克留() != 0);
			this.cAddress.Properties.Mask.EditMask = global::<Module>.ZExtO("帝幣幣", global::<Module>.斯留克大儿());
			this.cAddress.Size = new global::System.Drawing.Size(global::<Module>.豆留大留大(), global::<Module>.豆波大豆儿());
			this.cAddress.TabIndex = global::<Module>.波留波埃儿();
			this.cAddress.EditValueChanged += new global::System.EventHandler(this.cAddress_EditValueChanged);
			this.simpleButton1.Appearance.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("ᝳᝆᝏᝈᝊᝆ", global::<Module>.大儿儿波埃()), (float)global::<Module>.大克波波波());
			this.simpleButton1.Appearance.Options.UseFont = (global::<Module>.波留大留斯() != 0);
			this.simpleButton1.Location = new global::System.Drawing.Point(global::<Module>.埃波儿豆埃(), global::<Module>.大波留豆埃());
			this.simpleButton1.Name = global::<Module>.ZExtO("盻盡盥相盤盭益盽盼盼盧盦皹", global::<Module>.埃留埃儿波());
			this.simpleButton1.Size = new global::System.Drawing.Size(global::<Module>.艾埃克留斯(), global::<Module>.留斯儿大大());
			this.simpleButton1.TabIndex = global::<Module>.波波艾埃留();
			this.simpleButton1.Text = global::<Module>.ZExtO("Ɽⱏⱂⱄⱌ", global::<Module>.克克留波艾());
			this.simpleButton1.Click += new global::System.EventHandler(this.simpleButton1_Click);
			this.simpleButton2.Location = new global::System.Drawing.Point(global::<Module>.波斯留埃大(), global::<Module>.留留儿波埃());
			this.simpleButton2.Name = global::<Module>.ZExtO("䲾䲤䲠䲽䲡䲨䲏䲸䲹䲹䲢䲣䳿", global::<Module>.留克儿豆斯());
			this.simpleButton2.Size = new global::System.Drawing.Size(global::<Module>.儿儿留斯儿(), global::<Module>.留儿大艾斯());
			this.simpleButton2.TabIndex = global::<Module>.留斯波波留();
			this.simpleButton2.Text = global::<Module>.ZExtO("➃➬➥➡➲", global::<Module>.留儿斯埃大());
			this.simpleButton2.Click += new global::System.EventHandler(this.simpleButton2_Click);
			this.openFileDialog1.FileName = global::<Module>.ZExtO("쇸쇧쇲쇹쇑쇾쇻쇲쇓쇾쇶쇻쇸쇰솦", global::<Module>.大斯克克儿());
			this.simpleButton3.Appearance.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("ᮔᮡᮨᮯᮭᮡ", global::<Module>.儿留大大留()), (float)global::<Module>.艾儿艾波波());
			this.simpleButton3.Appearance.Options.UseFont = (global::<Module>.波斯艾埃波() != 0);
			this.simpleButton3.Location = new global::System.Drawing.Point(global::<Module>.波留斯波波(), global::<Module>.大埃斯留克());
			this.simpleButton3.Name = global::<Module>.ZExtO("⁀⁚⁞⁃\u205f⁖ⁱ⁆⁇⁇⁜⁝\u2000", global::<Module>.克豆儿儿豆());
			this.simpleButton3.Size = new global::System.Drawing.Size(global::<Module>.留艾儿留埃(), global::<Module>.大大埃埃艾());
			this.simpleButton3.TabIndex = global::<Module>.克艾豆儿留();
			this.simpleButton3.Text = global::<Module>.ZExtO("䳛䳸䳶䳳", global::<Module>.儿埃克大留());
			this.simpleButton3.Click += new global::System.EventHandler(this.simpleButton3_Click);
			this.label4.AutoSize = (global::<Module>.波豆大儿波() != 0);
			this.label4.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("吳吗吝同向名向吘吊呞吭吟吐名呞吭君同吗吘", global::<Module>.儿斯波克波()), (float)global::<Module>.儿埃豆留大());
			this.label4.Location = new global::System.Drawing.Point(global::<Module>.留艾埃埃留(), global::<Module>.留波斯克大());
			this.label4.Name = global::<Module>.ZExtO("섮섣선섧섮셶", global::<Module>.儿埃艾埃留());
			this.label4.Size = new global::System.Drawing.Size(global::<Module>.埃波大克留(), global::<Module>.留斯埃克波());
			this.label4.TabIndex = global::<Module>.埃留留儿留();
			this.label5.AutoSize = (global::<Module>.埃儿克大艾() != 0);
			this.label5.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("毂毦毬毽毠毼毠毩毻殯毜毮毡毼殯毜毪毽毦毩", global::<Module>.埃埃克留埃()), (float)global::<Module>.儿波克波波());
			this.label5.Location = new global::System.Drawing.Point(global::<Module>.艾艾波儿大(), global::<Module>.豆波波波波());
			this.label5.Name = global::<Module>.ZExtO("屔屙屚屝屔對", global::<Module>.艾留豆儿波());
			this.label5.Size = new global::System.Drawing.Size(global::<Module>.豆留留大斯(), global::<Module>.豆豆大波波());
			this.label5.TabIndex = global::<Module>.埃儿留埃留();
			this.label6.AutoSize = (global::<Module>.儿克艾大波() != 0);
			this.label6.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("ၠ၄၎ၟ၂ၞ၂။ၙဍၾ၌၃ၞဍၾ၈ၟ၄။", global::<Module>.留波斯大豆()), (float)global::<Module>.大留儿艾埃());
			this.label6.Location = new global::System.Drawing.Point(global::<Module>.留埃波留克(), global::<Module>.波斯留斯留());
			this.label6.Name = global::<Module>.ZExtO("痮痣痠痧痮疴", global::<Module>.儿大大斯大());
			this.label6.Size = new global::System.Drawing.Size(global::<Module>.大大波艾埃(), global::<Module>.留豆艾豆豆());
			this.label6.TabIndex = global::<Module>.斯儿斯大留();
			this.label6.Text = global::<Module>.ZExtO("㞽㞖㞛㞝㞕㟞㞐㞟㞓㞛㟞㞝㞑㞗㞐㟞㞘㞑㞌㟞㞊㞖㞛㟞㞓㞑㞐㞗㞊㞑㞌㞗㞐㞙㟳㟴", global::<Module>.埃斯波大留());
			this.label7.AutoSize = (global::<Module>.豆斯埃豆埃() != 0);
			this.label7.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("錹錝錗錆錛錇錛錒錀鍔錧錕錚錇鍔錧錑錆錝錒", global::<Module>.波斯波留埃()), (float)global::<Module>.克波豆豆艾());
			this.label7.Location = new global::System.Drawing.Point(global::<Module>.埃克埃留艾(), global::<Module>.艾留留留留());
			this.label7.Name = global::<Module>.ZExtO("廭廠廣廤廭庶", global::<Module>.克埃留大波());
			this.label7.Size = new global::System.Drawing.Size(global::<Module>.波艾豆波波(), global::<Module>.克大波留艾());
			this.label7.TabIndex = global::<Module>.斯留克留波();
			this.checkedListBoxControl1.CheckOnClick = (global::<Module>.波儿斯波留() != 0);
			this.checkedListBoxControl1.Cursor = global::System.Windows.Forms.Cursors.Default;
			global::DevExpress.XtraEditors.Controls.CheckedListBoxItemCollection items = this.checkedListBoxControl1.Items;
			global::DevExpress.XtraEditors.Controls.CheckedListBoxItem[] array6 = new global::DevExpress.XtraEditors.Controls.CheckedListBoxItem[global::<Module>.豆斯斯儿斯()];
			array6[global::<Module>.留儿留埃豆()] = new global::DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, global::<Module>.ZExtO("䢹䢯䢸", global::<Module>.波儿克波艾()));
			array6[global::<Module>.留波艾艾留()] = new global::DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, global::<Module>.ZExtO("䲤䲼䲫", global::<Module>.波大艾留波()));
			array6[global::<Module>.克大儿波克()] = new global::DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, global::<Module>.ZExtO("셧셢셰셫", global::<Module>.波波波波波()));
			array6[global::<Module>.斯大大克豆()] = new global::DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, global::<Module>.ZExtO("ᄆᄇᄌ", global::<Module>.波波儿留斯()));
			array6[global::<Module>.艾大大斯斯()] = new global::DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, global::<Module>.ZExtO("굷굦굺", global::<Module>.波克儿大克()));
			array6[global::<Module>.艾艾波大克()] = new global::DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, global::<Module>.ZExtO("巉巘巈", global::<Module>.克埃波豆艾()));
			array6[global::<Module>.儿留儿埃波()] = new global::DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, global::<Module>.ZExtO("", global::<Module>.斯克波儿埃()));
			array6[global::<Module>.豆艾埃儿波()] = new global::DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, global::<Module>.ZExtO("栚栆桺栚样栱栽栻格栴栽桻", global::<Module>.波埃波留波()));
			array6[global::<Module>.斯埃留大克()] = new global::DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, global::<Module>.ZExtO("䵌䵠䵵䵨䵢䴩䵑䵮䵭䵸䵦䵮䵯䴨", global::<Module>.艾豆豆埃波()));
			array6[global::<Module>.波埃波豆艾()] = new global::DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, global::<Module>.ZExtO("繇繴繤繯繵繥繧繨縮繇繴繤繯繲繴繳繫縯", global::<Module>.儿儿大留埃()));
			array6[global::<Module>.斯波埃斯克()] = new global::DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, global::<Module>.ZExtO("钮钑钕针钌针钒钕针钂铁钤钕钉钄钓钄钔钌", global::<Module>.埃艾儿艾大()));
			array6[global::<Module>.克儿斯斯大()] = new global::DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, global::<Module>.ZExtO("㜠㜂㜂㜃㜟㜄㜛㜈㜟", global::<Module>.艾波波留波()));
			array6[global::<Module>.斯斯大留儿()] = new global::DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, global::<Module>.ZExtO("뙑뙬뙭뙵뙶뙰뙣뙡뙧", global::<Module>.留留埃克埃()));
			array6[global::<Module>.克儿留波留()] = new global::DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, global::<Module>.ZExtO("", global::<Module>.留埃斯斯克()));
			items.AddRange(array6);
			this.checkedListBoxControl1.Location = new global::System.Drawing.Point(global::<Module>.豆大波波儿(), global::<Module>.儿波艾艾埃());
			this.checkedListBoxControl1.Name = global::<Module>.ZExtO("", global::<Module>.大大留埃留());
			this.checkedListBoxControl1.SelectionMode = (global::System.Windows.Forms.SelectionMode)global::<Module>.埃波斯艾斯();
			this.checkedListBoxControl1.Size = new global::System.Drawing.Size(global::<Module>.斯艾艾留斯(), global::<Module>.留克留儿波());
			this.checkedListBoxControl1.TabIndex = global::<Module>.留斯斯波波();
			this.checkedListBoxControl1.ItemCheck += new global::DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.checkedListBoxControl1_ItemCheck);
			this.label8.AutoSize = (global::<Module>.豆波艾克豆() != 0);
			this.label8.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("⚕⚱⚻⚪⚷⚫⚷⚾⚬⛸⚋⚹⚶⚫⛸⚋⚽⚪⚱⚾", global::<Module>.埃斯波埃波()), (float)global::<Module>.留斯留留留());
			this.label8.Location = new global::System.Drawing.Point(global::<Module>.埃波艾豆留(), global::<Module>.波儿留留斯());
			this.label8.Name = global::<Module>.ZExtO("䠴䠹䠺䠽䠴䡠", global::<Module>.艾豆留波留());
			this.label8.Size = new global::System.Drawing.Size(global::<Module>.克克儿大豆(), global::<Module>.斯留埃儿斯());
			this.label8.TabIndex = global::<Module>.豆克留儿大();
			this.seededit.Location = new global::System.Drawing.Point(global::<Module>.大儿大斯波(), global::<Module>.波艾斯留波());
			this.seededit.Name = global::<Module>.ZExtO("塹塯塯塮塯塮塣塾", global::<Module>.斯留埃豆大());
			this.seededit.Properties.Caption = global::<Module>.ZExtO("⠍⠵⠨⠱⡺⠸⠣⡺⠉⠿⠿⠾", global::<Module>.克波艾艾儿());
			this.seededit.Size = new global::System.Drawing.Size(global::<Module>.波留克艾斯(), global::<Module>.斯波留波豆());
			this.seededit.TabIndex = global::<Module>.大克斯斯豆();
			this.seededit.CheckedChanged += new global::System.EventHandler(this.seededit_CheckedChanged);
			this.privkeyedit.Location = new global::System.Drawing.Point(global::<Module>.豆艾儿埃儿(), global::<Module>.留留留豆儿());
			this.privkeyedit.Name = global::<Module>.ZExtO("", global::<Module>.大波埃波埃());
			this.privkeyedit.Properties.Caption = global::<Module>.ZExtO("챩챑챌챕찞챜챇찞챮챌챗챈챟챊챛챵챛챇", global::<Module>.艾留留埃艾());
			this.privkeyedit.Size = new global::System.Drawing.Size(global::<Module>.波留波豆留(), global::<Module>.豆儿留豆克());
			this.privkeyedit.TabIndex = global::<Module>.克儿留埃波();
			this.privkeyedit.CheckedChanged += new global::System.EventHandler(this.privkeyedit_CheckedChanged);
			this.saveFileExcel.Appearance.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("裖裣裪裭裯裣", global::<Module>.留儿留留克()), (float)global::<Module>.豆艾斯留豆());
			this.saveFileExcel.Appearance.Options.UseFont = (global::<Module>.留儿留儿大() != 0);
			this.saveFileExcel.Location = new global::System.Drawing.Point(global::<Module>.波斯斯艾克(), global::<Module>.波留波艾波());
			this.saveFileExcel.Name = global::<Module>.ZExtO("墺墨墿墬墏墠墥墬墌墱墪墬墥", global::<Module>.波大豆波艾());
			this.saveFileExcel.Size = new global::System.Drawing.Size(global::<Module>.儿豆埃埃艾(), global::<Module>.留豆豆留儿());
			this.saveFileExcel.TabIndex = global::<Module>.克斯留埃豆();
			this.saveFileExcel.Text = global::<Module>.ZExtO("\ude33\ude01\ude16\ude05", global::<Module>.大斯留艾大());
			this.saveFileExcel.Click += new global::System.EventHandler(this.saveFileExcel_Click);
			this.label9.AutoSize = (global::<Module>.留波斯豆豆() != 0);
			this.label9.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("퇒퇶퇼퇭퇰퇬퇰퇹퇫톿퇌퇾퇱퇬톿퇌퇺퇭퇶퇹", global::<Module>.艾豆豆克波()), (float)global::<Module>.艾儿波大大());
			this.label9.Location = new global::System.Drawing.Point(global::<Module>.艾艾留克留(), global::<Module>.波斯波留豆());
			this.label9.Name = global::<Module>.ZExtO("䑵䑸䑻䑼䑵䐠", global::<Module>.斯豆波艾波());
			this.label9.Size = new global::System.Drawing.Size(global::<Module>.艾留大留波(), global::<Module>.斯儿克埃豆());
			this.label9.TabIndex = global::<Module>.豆埃留波克();
			this.label9.Text = global::<Module>.ZExtO("ﵛﵴﵱﵻﵳﴸﵬﵷﴸﵫﵹﵮﵽﴸﵪﵽﵫﵭﵴﵬﵫﴸﵱﵶﴸﵾﵱﵴﵽﴸ﵌ﵹﵺﵴﵽ", global::<Module>.留波艾儿波());
			this.label10.AutoSize = (global::<Module>.儿儿儿克艾() != 0);
			this.label10.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("", global::<Module>.艾埃波豆波()), (float)global::<Module>.艾斯大波波());
			this.label10.Location = new global::System.Drawing.Point(global::<Module>.克大豆留克(), global::<Module>.豆留波克留());
			this.label10.Name = global::<Module>.ZExtO("ﲨﲥﲦﲡﲨﳵﳴ", global::<Module>.儿波豆波留());
			this.label10.Size = new global::System.Drawing.Size(global::<Module>.波波埃斯儿(), global::<Module>.豆波斯豆克());
			this.label10.TabIndex = global::<Module>.克大克大大();
			this.simpleButton4.Appearance.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("冐冥冬冫冩冥", global::<Module>.波波埃儿豆()), (float)global::<Module>.克留埃艾留());
			this.simpleButton4.Appearance.Options.UseFont = (global::<Module>.斯斯艾艾留() != 0);
			this.simpleButton4.Location = new global::System.Drawing.Point(global::<Module>.克克艾留大(), global::<Module>.斯斯克埃留());
			this.simpleButton4.Name = global::<Module>.ZExtO("镶镬镨镵镩镠镇镰镱镱镪镫锱", global::<Module>.大克埃大豆());
			this.simpleButton4.Size = new global::System.Drawing.Size(global::<Module>.艾大克留波(), global::<Module>.豆大大波大());
			this.simpleButton4.TabIndex = global::<Module>.艾大波儿留();
			this.simpleButton4.Text = global::<Module>.ZExtO("\ud8df\ud8e9\ud8e0\ud8e9\ud8ef\ud8f8\ud8ac\ud8cd\ud8e0\ud8e0", global::<Module>.儿斯艾埃埃());
			this.simpleButton4.Click += new global::System.EventHandler(this.simpleButton4_Click);
			this.simpleButton5.Appearance.Font = new global::System.Drawing.Font(global::<Module>.ZExtO("", global::<Module>.埃儿儿豆克()), (float)global::<Module>.艾儿埃留艾());
			this.simpleButton5.Appearance.Options.UseFont = (global::<Module>.埃波波儿留() != 0);
			this.simpleButton5.Location = new global::System.Drawing.Point(global::<Module>.留克儿留留(), global::<Module>.波波波克波());
			this.simpleButton5.Name = global::<Module>.ZExtO("", global::<Module>.豆波波艾斯());
			this.simpleButton5.Size = new global::System.Drawing.Size(global::<Module>.克留豆大留(), global::<Module>.豆儿克波斯());
			this.simpleButton5.TabIndex = global::<Module>.大大波克大();
			this.simpleButton5.Text = global::<Module>.ZExtO("彫彐彍彛归彛彝彊弞彿归归", global::<Module>.波艾儿波艾());
			this.simpleButton5.Click += new global::System.EventHandler(this.simpleButton5_Click);
			this.btcf.Location = new global::System.Drawing.Point(global::<Module>.留留波斯斯(), global::<Module>.斯豆留斯克());
			this.btcf.Name = global::<Module>.ZExtO("뻇뻑뻆뻃", global::<Module>.波斯留儿留());
			this.btcf.Size = new global::System.Drawing.Size(global::<Module>.留留波波豆(), global::<Module>.克埃豆儿留());
			this.btcf.TabIndex = global::<Module>.留波艾留埃();
			this.btcf.Text = global::<Module>.ZExtO("", global::<Module>.大克艾豆儿());
			this.btcf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.btcf_KeyPress);
			this.tabControl1.Controls.Add(this.main_set);
			this.tabControl1.Controls.Add(this.balance_f);
			this.tabControl1.Controls.Add(this.tg_set);
			this.tabControl1.Location = new global::System.Drawing.Point(global::<Module>.儿儿儿克儿(), global::<Module>.豆斯豆艾波());
			this.tabControl1.Name = global::<Module>.ZExtO("ᲪᲿ᲼ᲝᲱᲰᲪᲬᲱᲲᳯ", global::<Module>.克留波儿波());
			this.tabControl1.SelectedIndex = global::<Module>.豆克豆留留();
			this.tabControl1.Size = new global::System.Drawing.Size(global::<Module>.留留埃儿波(), global::<Module>.留波艾克留());
			this.tabControl1.TabIndex = global::<Module>.儿艾留豆波();
			this.main_set.Controls.Add(this.label2);
			this.main_set.Controls.Add(this.label3);
			this.main_set.Controls.Add(this.label5);
			this.main_set.Controls.Add(this.label10);
			this.main_set.Controls.Add(this.label4);
			this.main_set.Controls.Add(this.label8);
			this.main_set.Controls.Add(this.simpleButton3);
			this.main_set.Controls.Add(this.simpleButton5);
			this.main_set.Controls.Add(this.label1);
			this.main_set.Controls.Add(this.simpleButton2);
			this.main_set.Controls.Add(this.label7);
			this.main_set.Controls.Add(this.simpleButton1);
			this.main_set.Controls.Add(this.label9);
			this.main_set.Controls.Add(this.timeInterval);
			this.main_set.Controls.Add(this.saveFileExcel);
			this.main_set.Controls.Add(this.simpleButton4);
			this.main_set.Controls.Add(this.cAddress);
			this.main_set.Controls.Add(this.privkeyedit);
			this.main_set.Controls.Add(this.seededit);
			this.main_set.Controls.Add(this.label6);
			this.main_set.Controls.Add(this.checkedListBoxControl1);
			this.main_set.Location = new global::System.Drawing.Point(global::<Module>.留克大克豆(), global::<Module>.豆埃波斯波());
			this.main_set.Name = global::<Module>.ZExtO("㡱㡽㡵㡲㡃㡯㡹㡨", global::<Module>.艾艾留埃埃());
			this.main_set.Padding = new global::System.Windows.Forms.Padding(global::<Module>.斯斯波留克());
			this.main_set.Size = new global::System.Drawing.Size(global::<Module>.克艾埃大波(), global::<Module>.艾艾波波波());
			this.main_set.TabIndex = global::<Module>.留大留留豆();
			this.main_set.Text = global::<Module>.ZExtO("\udf80\udfac\udfa4\udfa3\udfed\udfbe\udfa8\udfb9\udfb9\udfa4\udfa3\udfaa\udfbe", global::<Module>.留波留留留());
			this.main_set.UseVisualStyleBackColor = (global::<Module>.波克留大克() != 0);
			this.balance_f.Controls.Add(this.label35);
			this.balance_f.Controls.Add(this.axief);
			this.balance_f.Controls.Add(this.label32);
			this.balance_f.Controls.Add(this.ronintf);
			this.balance_f.Controls.Add(this.label33);
			this.balance_f.Controls.Add(this.snowtf);
			this.balance_f.Controls.Add(this.label34);
			this.balance_f.Controls.Add(this.moontf);
			this.balance_f.Controls.Add(this.label31);
			this.balance_f.Controls.Add(this.roninf);
			this.balance_f.Controls.Add(this.label30);
			this.balance_f.Controls.Add(this.snowf);
			this.balance_f.Controls.Add(this.label29);
			this.balance_f.Controls.Add(this.moonf);
			this.balance_f.Controls.Add(this.label23);
			this.balance_f.Controls.Add(this.opttf);
			this.balance_f.Controls.Add(this.label24);
			this.balance_f.Controls.Add(this.optimisticf);
			this.balance_f.Controls.Add(this.label25);
			this.balance_f.Controls.Add(this.arbtf);
			this.balance_f.Controls.Add(this.label26);
			this.balance_f.Controls.Add(this.arbitrumf);
			this.balance_f.Controls.Add(this.label27);
			this.balance_f.Controls.Add(this.polytf);
			this.balance_f.Controls.Add(this.label28);
			this.balance_f.Controls.Add(this.maticf);
			this.balance_f.Controls.Add(this.label17);
			this.balance_f.Controls.Add(this.hectf);
			this.balance_f.Controls.Add(this.label18);
			this.balance_f.Controls.Add(this.hecof);
			this.balance_f.Controls.Add(this.label19);
			this.balance_f.Controls.Add(this.fttf);
			this.balance_f.Controls.Add(this.label20);
			this.balance_f.Controls.Add(this.ftmf);
			this.balance_f.Controls.Add(this.label21);
			this.balance_f.Controls.Add(this.bepf);
			this.balance_f.Controls.Add(this.label22);
			this.balance_f.Controls.Add(this.bscf);
			this.balance_f.Controls.Add(this.label16);
			this.balance_f.Controls.Add(this.ercf);
			this.balance_f.Controls.Add(this.label15);
			this.balance_f.Controls.Add(this.ethf);
			this.balance_f.Controls.Add(this.label14);
			this.balance_f.Controls.Add(this.dashf);
			this.balance_f.Controls.Add(this.label13);
			this.balance_f.Controls.Add(this.bchf);
			this.balance_f.Controls.Add(this.label12);
			this.balance_f.Controls.Add(this.ltcf);
			this.balance_f.Controls.Add(this.label11);
			this.balance_f.Controls.Add(this.btcf);
			this.balance_f.Location = new global::System.Drawing.Point(global::<Module>.大留艾埃艾(), global::<Module>.留留埃波儿());
			this.balance_f.Name = global::<Module>.ZExtO("疟疜疑疜疓疞疘疢疛", global::<Module>.斯克豆大波());
			this.balance_f.Padding = new global::System.Windows.Forms.Padding(global::<Module>.大斯艾留留());
			this.balance_f.Size = new global::System.Drawing.Size(global::<Module>.大儿豆克斯(), global::<Module>.波波留豆儿());
			this.balance_f.TabIndex = global::<Module>.豆波儿斯留();
			this.balance_f.Text = global::<Module>.ZExtO("﹮﹍﹀﹍﹂﹏﹉︌﹪﹅﹀﹘﹉﹞﹟", global::<Module>.克埃儿克大());
			this.balance_f.UseVisualStyleBackColor = (global::<Module>.儿斯埃斯波() != 0);
			this.label35.AutoSize = (global::<Module>.儿留留留斯() != 0);
			this.label35.Location = new global::System.Drawing.Point(global::<Module>.克留波波波(), global::<Module>.艾留波波斯());
			this.label35.Name = global::<Module>.ZExtO("ꚻꚶꚵꚲꚻꛤꛢ", global::<Module>.埃豆克克波());
			this.label35.Size = new global::System.Drawing.Size(global::<Module>.波波儿波斯(), global::<Module>.斯艾留克斯());
			this.label35.TabIndex = global::<Module>.埃儿波波艾();
			this.label35.Text = global::<Module>.ZExtO("먓먊먛먗", global::<Module>.艾留波儿留());
			this.axief.Location = new global::System.Drawing.Point(global::<Module>.波波大留留(), global::<Module>.艾艾留留斯());
			this.axief.Name = global::<Module>.ZExtO("设讧讶论讹", global::<Module>.波埃豆留大());
			this.axief.Size = new global::System.Drawing.Size(global::<Module>.大克儿斯豆(), global::<Module>.艾埃斯克儿());
			this.axief.TabIndex = global::<Module>.留波埃斯儿();
			this.axief.Text = global::<Module>.ZExtO("鰞", global::<Module>.斯留留艾大());
			this.axief.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.axief_KeyPress);
			this.label32.AutoSize = (global::<Module>.埃埃斯留艾() != 0);
			this.label32.Location = new global::System.Drawing.Point(global::<Module>.儿儿儿留波(), global::<Module>.埃波大埃斯());
			this.label32.Name = global::<Module>.ZExtO("ꀠꀭꀮꀩꀠꁿꁾ", global::<Module>.留克克儿豆());
			this.label32.Size = new global::System.Drawing.Size(global::<Module>.波克克波豆(), global::<Module>.留留艾斯豆());
			this.label32.TabIndex = global::<Module>.大艾大克斯();
			this.label32.Text = global::<Module>.ZExtO("뎟뎂뎃뎄뎃돭뎙뎢뎦뎨뎣돭돥돩돤", global::<Module>.斯留留艾大());
			this.ronintf.Location = new global::System.Drawing.Point(global::<Module>.豆波波波儿(), global::<Module>.克波豆埃斯());
			this.ronintf.Name = global::<Module>.ZExtO("", global::<Module>.克大波儿豆());
			this.ronintf.Size = new global::System.Drawing.Size(global::<Module>.留豆留留波(), global::<Module>.克埃波留克());
			this.ronintf.TabIndex = global::<Module>.波波克波豆();
			this.ronintf.Text = global::<Module>.ZExtO("牛", global::<Module>.艾大艾波豆());
			this.ronintf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.ronintf_KeyPress);
			this.label33.AutoSize = (global::<Module>.埃波波埃留() != 0);
			this.label33.Location = new global::System.Drawing.Point(global::<Module>.波艾艾埃留(), global::<Module>.豆留儿斯波());
			this.label33.Name = global::<Module>.ZExtO("zwtsz%%", global::<Module>.大波豆留斯());
			this.label33.Size = new global::System.Drawing.Size(global::<Module>.豆豆留艾斯(), global::<Module>.波大克埃艾());
			this.label33.TabIndex = global::<Module>.留波大儿豆();
			this.label33.Text = global::<Module>.ZExtO("땱땬땭땵땶땰땣땡땧딂땶땍땉땇때딂딊딆딋", global::<Module>.埃留波埃大());
			this.snowtf.Location = new global::System.Drawing.Point(global::<Module>.艾波波埃斯(), global::<Module>.艾儿留波儿());
			this.snowtf.Name = global::<Module>.ZExtO("궂궟궞궆궅궗", global::<Module>.斯大儿斯埃());
			this.snowtf.Size = new global::System.Drawing.Size(global::<Module>.埃大留留克(), global::<Module>.克波留波埃());
			this.snowtf.TabIndex = global::<Module>.斯留埃大大();
			this.snowtf.Text = global::<Module>.ZExtO("뢂", global::<Module>.波豆留留儿());
			this.snowtf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.snowtf_KeyPress);
			this.label34.AutoSize = (global::<Module>.留留留大儿() != 0);
			this.label34.Location = new global::System.Drawing.Point(global::<Module>.埃波波波波(), global::<Module>.留埃克艾留());
			this.label34.Name = global::<Module>.ZExtO("䬂䬏䬌䬋䬂䭝䭚", global::<Module>.波儿艾豆斯());
			this.label34.Size = new global::System.Drawing.Size(global::<Module>.克留埃豆埃(), global::<Module>.克儿艾埃留());
			this.label34.TabIndex = global::<Module>.斯留斯艾艾();
			this.label34.Text = global::<Module>.ZExtO("", global::<Module>.艾留留克埃());
			this.moontf.Location = new global::System.Drawing.Point(global::<Module>.儿艾克埃艾(), global::<Module>.斯大波留留());
			this.moontf.Name = global::<Module>.ZExtO("", global::<Module>.埃波豆大留());
			this.moontf.Size = new global::System.Drawing.Size(global::<Module>.艾留留大艾(), global::<Module>.波留儿留克());
			this.moontf.TabIndex = global::<Module>.豆留艾埃斯();
			this.moontf.Text = global::<Module>.ZExtO("ꩅ", global::<Module>.豆斯波留艾());
			this.moontf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.moontf_KeyPress);
			this.label31.AutoSize = (global::<Module>.留波豆大留() != 0);
			this.label31.Location = new global::System.Drawing.Point(global::<Module>.波斯克留留(), global::<Module>.波留留埃埃());
			this.label31.Name = global::<Module>.ZExtO("깆깋깈깏깆긙긛", global::<Module>.克大克艾艾());
			this.label31.Size = new global::System.Drawing.Size(global::<Module>.波豆儿留艾(), global::<Module>.大波大斯艾());
			this.label31.TabIndex = global::<Module>.波埃埃波豆();
			this.label31.Text = global::<Module>.ZExtO("㔁㔜㔝㔚㔝", global::<Module>.留留克留留());
			this.roninf.Location = new global::System.Drawing.Point(global::<Module>.克儿克儿大(), global::<Module>.留豆留埃克());
			this.roninf.Name = global::<Module>.ZExtO("篊篗篖篑篖篞", global::<Module>.儿克留斯波());
			this.roninf.Size = new global::System.Drawing.Size(global::<Module>.艾克埃波留(), global::<Module>.埃留留豆埃());
			this.roninf.TabIndex = global::<Module>.波留克克克();
			this.roninf.Text = global::<Module>.ZExtO("ꜱ", global::<Module>.艾克艾波留());
			this.roninf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.roninf_KeyPress);
			this.label30.AutoSize = (global::<Module>.埃波豆留克() != 0);
			this.label30.Location = new global::System.Drawing.Point(global::<Module>.波斯大埃豆(), global::<Module>.儿斯波豆大());
			this.label30.Name = global::<Module>.ZExtO("드듑듒듕드뒃뒀", global::<Module>.儿留波埃波());
			this.label30.Size = new global::System.Drawing.Size(global::<Module>.斯留斯艾艾(), global::<Module>.豆波波留艾());
			this.label30.TabIndex = global::<Module>.留艾埃波儿();
			this.label30.Text = global::<Module>.ZExtO("鴲鴯鴮鴶鴵鴳鴠鴢鴤", global::<Module>.波克留艾埃());
			this.snowf.Location = new global::System.Drawing.Point(global::<Module>.波艾波埃波(), global::<Module>.留儿斯波留());
			this.snowf.Name = global::<Module>.ZExtO("私秜秝秅秔", global::<Module>.克儿留豆斯());
			this.snowf.Size = new global::System.Drawing.Size(global::<Module>.斯艾波豆克(), global::<Module>.儿波留留波());
			this.snowf.TabIndex = global::<Module>.埃克埃大艾();
			this.snowf.Text = global::<Module>.ZExtO("녇", global::<Module>.艾豆波埃豆());
			this.snowf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.snowf_KeyPress);
			this.label29.AutoSize = (global::<Module>.儿埃克斯克() != 0);
			this.label29.Location = new global::System.Drawing.Point(global::<Module>.大艾儿波波(), global::<Module>.波埃克艾波());
			this.label29.Name = global::<Module>.ZExtO("꾉꾄꾇꾀꾉꿗꿜", global::<Module>.克波艾留大());
			this.label29.Size = new global::System.Drawing.Size(global::<Module>.埃克大艾大(), global::<Module>.波儿留斯留());
			this.label29.TabIndex = global::<Module>.克豆留豆留();
			this.label29.Text = global::<Module>.ZExtO("ᲩᲫᲫᲪᲶᲭᲲᲡᲶ", global::<Module>.斯波克留留());
			this.moonf.Location = new global::System.Drawing.Point(global::<Module>.克克埃埃艾(), global::<Module>.埃埃留豆波());
			this.moonf.Name = global::<Module>.ZExtO("퓙퓛퓛퓚퓒", global::<Module>.留大大儿豆());
			this.moonf.Size = new global::System.Drawing.Size(global::<Module>.艾儿艾留波(), global::<Module>.儿儿波艾斯());
			this.moonf.TabIndex = global::<Module>.留艾克埃克();
			this.moonf.Text = global::<Module>.ZExtO("绱", global::<Module>.儿艾波儿斯());
			this.moonf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.moonf_KeyPress);
			this.label23.AutoSize = (global::<Module>.留埃斯豆大() != 0);
			this.label23.Location = new global::System.Drawing.Point(global::<Module>.大斯豆波豆(), global::<Module>.留艾波埃豆());
			this.label23.Name = global::<Module>.ZExtO("ޒޟޜޛޒߌߍ", global::<Module>.留留大埃斯());
			this.label23.Size = new global::System.Drawing.Size(global::<Module>.波儿留波儿(), global::<Module>.留豆波波儿());
			this.label23.TabIndex = global::<Module>.大艾儿留埃();
			this.label23.Text = global::<Module>.ZExtO("", global::<Module>.艾留艾艾波());
			this.opttf.Location = new global::System.Drawing.Point(global::<Module>.波波儿艾波(), global::<Module>.大留克埃儿());
			this.opttf.Name = global::<Module>.ZExtO("유윿윻윻윩", global::<Module>.留斯儿波波());
			this.opttf.Size = new global::System.Drawing.Size(global::<Module>.斯留波大留(), global::<Module>.波波斯埃儿());
			this.opttf.TabIndex = global::<Module>.斯留斯豆波();
			this.opttf.Text = global::<Module>.ZExtO("", global::<Module>.埃大儿儿波());
			this.opttf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.opttf_KeyPress);
			this.label24.AutoSize = (global::<Module>.儿埃豆大波() != 0);
			this.label24.Location = new global::System.Drawing.Point(global::<Module>.艾波大埃留(), global::<Module>.埃留斯波留());
			this.label24.Name = global::<Module>.ZExtO("볳볾볽볺볳벭벫", global::<Module>.埃克大波豆());
			this.label24.Size = new global::System.Drawing.Size(global::<Module>.儿留艾留斯(), global::<Module>.波艾克儿儿());
			this.label24.TabIndex = global::<Module>.留艾埃儿埃();
			this.label24.Text = global::<Module>.ZExtO("副剰剴剩剭剩剳剴剩剣", global::<Module>.克艾埃豆斯());
			this.optimisticf.Location = new global::System.Drawing.Point(global::<Module>.艾波克斯艾(), global::<Module>.大儿留埃波());
			this.optimisticf.Name = global::<Module>.ZExtO("蕷蕨蕬蕱蕵蕱蕫蕬蕱蕻蕾", global::<Module>.留埃豆儿克());
			this.optimisticf.Size = new global::System.Drawing.Size(global::<Module>.克波埃克豆(), global::<Module>.埃儿儿波大());
			this.optimisticf.TabIndex = global::<Module>.留留留儿儿();
			this.optimisticf.Text = global::<Module>.ZExtO("防", global::<Module>.波埃波艾波());
			this.optimisticf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.optimisticf_KeyPress);
			this.label25.AutoSize = (global::<Module>.斯波波大留() != 0);
			this.label25.Location = new global::System.Drawing.Point(global::<Module>.儿克克大波(), global::<Module>.留儿大艾豆());
			this.label25.Name = global::<Module>.ZExtO("턦턫턨턯턦텸텿", global::<Module>.波留留豆克());
			this.label25.Size = new global::System.Drawing.Size(global::<Module>.豆波儿留克(), global::<Module>.留克波大豆());
			this.label25.TabIndex = global::<Module>.留儿大大豆();
			this.label25.Text = global::<Module>.ZExtO("鯸鯫鯻鯰鯭鯫鯬鯴鮙鯭鯖鯒鯜鯗鮙鮑鮝鮐", global::<Module>.波豆波大斯());
			this.arbtf.Location = new global::System.Drawing.Point(global::<Module>.豆留大儿波(), global::<Module>.留艾豆波豆());
			this.arbtf.Name = global::<Module>.ZExtO("륅륖륆륐륂", global::<Module>.豆克波波波());
			this.arbtf.Size = new global::System.Drawing.Size(global::<Module>.波波留斯波(), global::<Module>.艾大波波留());
			this.arbtf.TabIndex = global::<Module>.留大豆艾斯();
			this.arbtf.Text = global::<Module>.ZExtO("ﭳ", global::<Module>.波波艾儿斯());
			this.arbtf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.arbtf_KeyPress);
			this.label26.AutoSize = (global::<Module>.波留豆埃斯() != 0);
			this.label26.Location = new global::System.Drawing.Point(global::<Module>.留克埃波豆(), global::<Module>.儿斯留豆艾());
			this.label26.Name = global::<Module>.ZExtO("儲儿儼儻儲公全", global::<Module>.埃波艾豆儿());
			this.label26.Size = new global::System.Drawing.Size(global::<Module>.艾波留波豆(), global::<Module>.留艾大留克());
			this.label26.TabIndex = global::<Module>.克艾波斯豆();
			this.label26.Text = global::<Module>.ZExtO("淍淞淎淅淘淞淙淁", global::<Module>.留波留豆留());
			this.arbitrumf.Location = new global::System.Drawing.Point(global::<Module>.波斯大波斯(), global::<Module>.儿波埃埃斯());
			this.arbitrumf.Name = global::<Module>.ZExtO("궾궭궽궶궫궭궪궲궹", global::<Module>.大斯儿豆儿());
			this.arbitrumf.Size = new global::System.Drawing.Size(global::<Module>.艾艾斯克波(), global::<Module>.斯波留斯留());
			this.arbitrumf.TabIndex = global::<Module>.克波儿豆儿();
			this.arbitrumf.Text = global::<Module>.ZExtO("騜", global::<Module>.斯豆艾波斯());
			this.arbitrumf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.arbitrumf_KeyPress);
			this.label27.AutoSize = (global::<Module>.大波留艾斯() != 0);
			this.label27.Location = new global::System.Drawing.Point(global::<Module>.埃艾斯大留(), global::<Module>.豆留波艾大());
			this.label27.Name = global::<Module>.ZExtO("錾錳錰錷錾鍠鍥", global::<Module>.斯留大克斯());
			this.label27.Size = new global::System.Drawing.Size(global::<Module>.艾波克艾埃(), global::<Module>.斯波克波豆());
			this.label27.TabIndex = global::<Module>.大艾斯波大();
			this.label27.Text = global::<Module>.ZExtO("馱馮馭馸馦馮馯駁馵馎馊馄馏駁駉駅駈", global::<Module>.斯克艾豆儿());
			this.polytf.Location = new global::System.Drawing.Point(global::<Module>.儿艾克波豆(), global::<Module>.大艾克艾波());
			this.polytf.Name = global::<Module>.ZExtO("咾咡咢咷咺咨", global::<Module>.波儿留斯儿());
			this.polytf.Size = new global::System.Drawing.Size(global::<Module>.艾大留留豆(), global::<Module>.大留留波留());
			this.polytf.TabIndex = global::<Module>.大艾埃斯克();
			this.polytf.Text = global::<Module>.ZExtO("縜", global::<Module>.克留波留艾());
			this.polytf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.polytf_KeyPress);
			this.label28.AutoSize = (global::<Module>.埃艾波儿波() != 0);
			this.label28.Location = new global::System.Drawing.Point(global::<Module>.儿艾艾豆克(), global::<Module>.儿克埃克儿());
			this.label28.Name = global::<Module>.ZExtO("kfebk5?", global::<Module>.豆大埃豆大());
			this.label28.Size = new global::System.Drawing.Size(global::<Module>.斯儿波留艾(), global::<Module>.儿留豆波大());
			this.label28.TabIndex = global::<Module>.留斯豆艾艾();
			this.label28.Text = global::<Module>.ZExtO("澽澱澤澹澳", global::<Module>.埃留斯波大());
			this.maticf.Location = new global::System.Drawing.Point(global::<Module>.波豆留大留(), global::<Module>.斯艾豆留斯());
			this.maticf.Name = global::<Module>.ZExtO("", global::<Module>.波波波斯波());
			this.maticf.Size = new global::System.Drawing.Size(global::<Module>.波留留克埃(), global::<Module>.克儿克儿大());
			this.maticf.TabIndex = global::<Module>.波斯波留儿();
			this.maticf.Text = global::<Module>.ZExtO("僌", global::<Module>.波埃大儿艾());
			this.maticf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.maticf_KeyPress);
			this.label17.AutoSize = (global::<Module>.大留留埃大() != 0);
			this.label17.Location = new global::System.Drawing.Point(global::<Module>.克留波克留(), global::<Module>.埃留波斯斯());
			this.label17.Name = global::<Module>.ZExtO("ꂛꂖꂕꂒꂛꃆꃀ", global::<Module>.斯儿埃儿克());
			this.label17.Size = new global::System.Drawing.Size(global::<Module>.埃波克豆波(), global::<Module>.埃克留留留());
			this.label17.TabIndex = global::<Module>.儿留波儿埃();
			this.label17.Text = global::<Module>.ZExtO("煢煯煩煥焊煾煅煁煏煄焊焂焎焃", global::<Module>.艾波留波豆());
			this.hectf.Location = new global::System.Drawing.Point(global::<Module>.艾斯豆克大(), global::<Module>.艾留斯大留());
			this.hectf.Name = global::<Module>.ZExtO("틂틏틉틞틌", global::<Module>.波豆艾留留());
			this.hectf.Size = new global::System.Drawing.Size(global::<Module>.留儿留艾大(), global::<Module>.豆埃艾大波());
			this.hectf.TabIndex = global::<Module>.留埃克克儿();
			this.hectf.Text = global::<Module>.ZExtO("骢", global::<Module>.留波大波艾());
			this.hectf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.hectf_KeyPress);
			this.label18.AutoSize = (global::<Module>.波波埃儿留() != 0);
			this.label18.Location = new global::System.Drawing.Point(global::<Module>.艾豆克波克(), global::<Module>.波豆大克艾());
			this.label18.Name = global::<Module>.ZExtO("ᖁᖌᖏᖈᖁᗜᗕ", global::<Module>.留留斯留豆());
			this.label18.Size = new global::System.Drawing.Size(global::<Module>.留儿儿波波(), global::<Module>.留大埃儿艾());
			this.label18.TabIndex = global::<Module>.豆儿留豆儿();
			this.label18.Text = global::<Module>.ZExtO("Έ΅΃Ώ", global::<Module>.儿儿留波波());
			this.hecof.Location = new global::System.Drawing.Point(global::<Module>.埃豆斯斯埃(), global::<Module>.艾波豆艾波());
			this.hecof.Name = global::<Module>.ZExtO("롕롘롞롒롛", global::<Module>.豆艾留波埃());
			this.hecof.Size = new global::System.Drawing.Size(global::<Module>.克克艾留大(), global::<Module>.斯豆波波克());
			this.hecof.TabIndex = global::<Module>.埃埃大留留();
			this.hecof.Text = global::<Module>.ZExtO("谖", global::<Module>.斯埃留波留());
			this.hecof.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.hecof_KeyPress);
			this.label19.AutoSize = (global::<Module>.艾留留大克() != 0);
			this.label19.Location = new global::System.Drawing.Point(global::<Module>.波波波豆儿(), global::<Module>.波留埃留艾());
			this.label19.Name = global::<Module>.ZExtO("൭ൠൣ൤൭രസ", global::<Module>.艾埃豆留留());
			this.label19.Size = new global::System.Drawing.Size(global::<Module>.克留留埃埃(), global::<Module>.留波留儿留());
			this.label19.TabIndex = global::<Module>.豆克埃留留();
			this.label19.Text = global::<Module>.ZExtO("\udeb1\udea3\udeba\uded7\udea3\ude98\ude9c\ude92\ude99\uded7\udedf\uded3\udede", global::<Module>.艾儿斯儿留());
			this.fttf.Location = new global::System.Drawing.Point(global::<Module>.波留留埃波(), global::<Module>.斯豆留留大());
			this.fttf.Name = global::<Module>.ZExtO("勐勂勂勐", global::<Module>.斯克豆斯波());
			this.fttf.Size = new global::System.Drawing.Size(global::<Module>.埃埃波大儿(), global::<Module>.波留波留波());
			this.fttf.TabIndex = global::<Module>.大波斯波豆();
			this.fttf.Text = global::<Module>.ZExtO("퉿", global::<Module>.留波斯豆儿());
			this.fttf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.fttf_KeyPress);
			this.label20.AutoSize = (global::<Module>.儿埃波斯波() != 0);
			this.label20.Location = new global::System.Drawing.Point(global::<Module>.艾豆艾大斯(), global::<Module>.波克留克波());
			this.label20.Name = global::<Module>.ZExtO("⽯⽢⽡⽦⽯⼱⼳", global::<Module>.艾斯豆埃克());
			this.label20.Size = new global::System.Drawing.Size(global::<Module>.留儿豆大留(), global::<Module>.波波埃豆波());
			this.label20.TabIndex = global::<Module>.留留豆留埃();
			this.label20.Text = global::<Module>.ZExtO("炮炼炥", global::<Module>.埃艾斯留埃());
			this.ftmf.Location = new global::System.Drawing.Point(global::<Module>.波大波斯豆(), global::<Module>.克留克埃大());
			this.ftmf.Name = global::<Module>.ZExtO("爹爫爲爹", global::<Module>.儿留克留波());
			this.ftmf.Size = new global::System.Drawing.Size(global::<Module>.豆埃克波波(), global::<Module>.波豆儿留波());
			this.ftmf.TabIndex = global::<Module>.豆克大埃大();
			this.ftmf.Text = global::<Module>.ZExtO("Ȃ", global::<Module>.埃埃波豆波());
			this.ftmf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.ftmf_KeyPress);
			this.label21.AutoSize = (global::<Module>.艾斯儿大大() != 0);
			this.label21.Location = new global::System.Drawing.Point(global::<Module>.留儿豆艾波(), global::<Module>.儿波克儿埃());
			this.label21.Name = global::<Module>.ZExtO("❒❟❜❛❒✌✏", global::<Module>.豆波波克大());
			this.label21.Size = new global::System.Drawing.Size(global::<Module>.留艾艾留埃(), global::<Module>.埃艾埃儿斯());
			this.label21.TabIndex = global::<Module>.儿波克埃斯();
			this.label21.Text = global::<Module>.ZExtO("갗감갅걸걧걥걵걽걱걼", global::<Module>.儿大波留留());
			this.bepf.Location = new global::System.Drawing.Point(global::<Module>.克豆埃克克(), global::<Module>.克豆艾豆大());
			this.bepf.Name = global::<Module>.ZExtO("뎪뎭뎸뎮", global::<Module>.艾艾斯儿斯());
			this.bepf.Size = new global::System.Drawing.Size(global::<Module>.豆儿克大斯(), global::<Module>.豆艾大波克());
			this.bepf.TabIndex = global::<Module>.斯艾克留波();
			this.bepf.Text = global::<Module>.ZExtO("嚾", global::<Module>.艾儿留大克());
			this.bepf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.bepf_KeyPress);
			this.label22.AutoSize = (global::<Module>.留艾留波留() != 0);
			this.label22.Location = new global::System.Drawing.Point(global::<Module>.克豆埃大儿(), global::<Module>.埃斯波留斯());
			this.label22.Name = global::<Module>.ZExtO("潜潑潒潕潜漂漂", global::<Module>.埃克留斯豆());
			this.label22.Size = new global::System.Drawing.Size(global::<Module>.留儿儿豆留(), global::<Module>.留留埃艾波());
			this.label22.TabIndex = global::<Module>.豆儿豆艾儿();
			this.label22.Text = global::<Module>.ZExtO("嚈嚙嚉", global::<Module>.波斯波波克());
			this.bscf.Location = new global::System.Drawing.Point(global::<Module>.豆留豆儿埃(), global::<Module>.埃斯斯大波());
			this.bscf.Name = global::<Module>.ZExtO("빇빖빆빃", global::<Module>.留克儿波艾());
			this.bscf.Size = new global::System.Drawing.Size(global::<Module>.留豆留留大(), global::<Module>.斯豆留艾儿());
			this.bscf.TabIndex = global::<Module>.大斯留克波();
			this.bscf.Text = global::<Module>.ZExtO("퇕", global::<Module>.波波埃克豆());
			this.bscf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.bscf_KeyPress);
			this.label16.AutoSize = (global::<Module>.埃儿豆豆留() != 0);
			this.label16.Location = new global::System.Drawing.Point(global::<Module>.大艾波斯斯(), global::<Module>.波埃艾豆留());
			this.label16.Name = global::<Module>.ZExtO("퀫퀦퀥퀢퀫큶큱", global::<Module>.留波斯埃留());
			this.label16.Size = new global::System.Drawing.Size(global::<Module>.埃埃大埃儿(), global::<Module>.波大克艾艾());
			this.label16.TabIndex = global::<Module>.埃克留波艾();
			this.label16.Text = global::<Module>.ZExtO("捧捰捡挏挐挒挂挊挆挋", global::<Module>.克豆留儿埃());
			this.ercf.Location = new global::System.Drawing.Point(global::<Module>.儿克斯大留(), global::<Module>.大儿留斯大());
			this.ercf.Name = global::<Module>.ZExtO("උගඍඈ", global::<Module>.豆斯豆斯留());
			this.ercf.Size = new global::System.Drawing.Size(global::<Module>.埃波豆斯克(), global::<Module>.豆波克艾斯());
			this.ercf.TabIndex = global::<Module>.儿艾克波波();
			this.ercf.Text = global::<Module>.ZExtO("䌦", global::<Module>.留斯艾埃斯());
			this.ercf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.ercf_KeyPress);
			this.label15.AutoSize = (global::<Module>.留波埃克波() != 0);
			this.label15.Location = new global::System.Drawing.Point(global::<Module>.埃波豆斯儿(), global::<Module>.留克斯留艾());
			this.label15.Name = global::<Module>.ZExtO("셧셪셩셮셧섺섾", global::<Module>.波埃大留埃());
			this.label15.Size = new global::System.Drawing.Size(global::<Module>.斯豆儿克克(), global::<Module>.波留留留波());
			this.label15.TabIndex = global::<Module>.波艾豆豆埃();
			this.label15.Text = global::<Module>.ZExtO("䣚䣋䣗", global::<Module>.斯波波波埃());
			this.ethf.Location = new global::System.Drawing.Point(global::<Module>.艾留豆豆波(), global::<Module>.艾大艾留豆());
			this.ethf.Name = global::<Module>.ZExtO("", global::<Module>.留豆埃豆埃());
			this.ethf.Size = new global::System.Drawing.Size(global::<Module>.留克留豆儿(), global::<Module>.留豆波留留());
			this.ethf.TabIndex = global::<Module>.斯克大留大();
			this.ethf.Text = global::<Module>.ZExtO("ł", global::<Module>.大大留留留());
			this.ethf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.ethf_KeyPress);
			this.label14.AutoSize = (global::<Module>.儿埃儿波艾() != 0);
			this.label14.Location = new global::System.Drawing.Point(global::<Module>.波留儿留大(), global::<Module>.留艾豆豆克());
			this.label14.Name = global::<Module>.ZExtO("զիըկզԻԾ", global::<Module>.克留波克留());
			this.label14.Size = new global::System.Drawing.Size(global::<Module>.艾克波埃克(), global::<Module>.留豆克留儿());
			this.label14.TabIndex = global::<Module>.克波艾留波();
			this.label14.Text = global::<Module>.ZExtO("ꕱꕴꕦꕽ", global::<Module>.波留克波斯());
			this.dashf.Location = new global::System.Drawing.Point(global::<Module>.儿斯豆斯埃(), global::<Module>.艾克波大斯());
			this.dashf.Name = global::<Module>.ZExtO("", global::<Module>.留留波豆留());
			this.dashf.Size = new global::System.Drawing.Size(global::<Module>.艾儿艾艾克(), global::<Module>.留波克留克());
			this.dashf.TabIndex = global::<Module>.波埃留留波();
			this.dashf.Text = global::<Module>.ZExtO("칽", global::<Module>.儿波波留留());
			this.dashf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.dashf_KeyPress);
			this.label13.AutoSize = (global::<Module>.波克克埃留() != 0);
			this.label13.Location = new global::System.Drawing.Point(global::<Module>.大艾波大波(), global::<Module>.儿豆艾艾波());
			this.label13.Name = global::<Module>.ZExtO("ⅽⅰⅳⅴⅽ℠™", global::<Module>.克留艾斯波());
			this.label13.Size = new global::System.Drawing.Size(global::<Module>.留克埃克儿(), global::<Module>.艾儿留豆留());
			this.label13.TabIndex = global::<Module>.留埃留克留();
			this.label13.Text = global::<Module>.ZExtO("폒폓폘", global::<Module>.波留艾埃留());
			this.bchf.Location = new global::System.Drawing.Point(global::<Module>.留豆留埃波(), global::<Module>.波波留儿斯());
			this.bchf.Name = global::<Module>.ZExtO("륜륝륖류", global::<Module>.波波克克豆());
			this.bchf.Size = new global::System.Drawing.Size(global::<Module>.大埃埃大留(), global::<Module>.艾波留波大());
			this.bchf.TabIndex = global::<Module>.艾留留克波();
			this.bchf.Text = global::<Module>.ZExtO("ꎗ", global::<Module>.艾大留波豆());
			this.bchf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.bchf_KeyPress);
			this.label12.AutoSize = (global::<Module>.豆斯埃儿斯() != 0);
			this.label12.Location = new global::System.Drawing.Point(global::<Module>.斯波克儿波(), global::<Module>.儿豆波克斯());
			this.label12.Name = global::<Module>.ZExtO("톁톌톏톈톁퇜퇟", global::<Module>.波留斯克斯());
			this.label12.Size = new global::System.Drawing.Size(global::<Module>.埃克埃波波(), global::<Module>.豆豆波大儿());
			this.label12.TabIndex = global::<Module>.留大儿克埃();
			this.label12.Text = global::<Module>.ZExtO("珊珒珅", global::<Module>.埃埃大克儿());
			this.ltcf.Location = new global::System.Drawing.Point(global::<Module>.留儿克埃艾(), global::<Module>.儿克波留埃());
			this.ltcf.Name = global::<Module>.ZExtO("BZMH", global::<Module>.埃克大斯留());
			this.ltcf.Size = new global::System.Drawing.Size(global::<Module>.留斯斯豆大(), global::<Module>.斯埃波豆斯());
			this.ltcf.TabIndex = global::<Module>.大斯斯埃斯();
			this.ltcf.Text = global::<Module>.ZExtO("쉫", global::<Module>.大斯埃留波());
			this.ltcf.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.ltcf_KeyPress);
			this.label11.AutoSize = (global::<Module>.波豆豆克克() != 0);
			this.label11.Location = new global::System.Drawing.Point(global::<Module>.留艾留大儿(), global::<Module>.波埃留大斯());
			this.label11.Name = global::<Module>.ZExtO("ᰞᰓᰐᰗᰞ᱃᱃", global::<Module>.波波波留波());
			this.label11.Size = new global::System.Drawing.Size(global::<Module>.留留克波大(), global::<Module>.留留大儿儿());
			this.label11.TabIndex = global::<Module>.留埃留留波();
			this.label11.Text = global::<Module>.ZExtO("", global::<Module>.留大克波波());
			this.tg_set.Controls.Add(this.chatid);
			this.tg_set.Controls.Add(this.label37);
			this.tg_set.Controls.Add(this.label36);
			this.tg_set.Controls.Add(this.apib);
			this.tg_set.Location = new global::System.Drawing.Point(global::<Module>.儿克波大留(), global::<Module>.大波豆波波());
			this.tg_set.Name = global::<Module>.ZExtO("굉굚굢굎굘굉", global::<Module>.艾留斯埃艾());
			this.tg_set.Size = new global::System.Drawing.Size(global::<Module>.留波克留儿(), global::<Module>.豆斯克儿波());
			this.tg_set.TabIndex = global::<Module>.波克艾留波();
			this.tg_set.Text = global::<Module>.ZExtO("覱覀覉覀覂覗覄覈觅視覀覑覑覌見覂視", global::<Module>.留儿艾波波());
			this.tg_set.UseVisualStyleBackColor = (global::<Module>.儿留波豆豆() != 0);
			this.chatid.Location = new global::System.Drawing.Point(global::<Module>.儿豆留大克(), global::<Module>.埃波留大豆());
			this.chatid.Name = global::<Module>.ZExtO("쀷쀼쀵쀠쀽쀰", global::<Module>.埃克斯克留());
			this.chatid.Size = new global::System.Drawing.Size(global::<Module>.波埃波艾留(), global::<Module>.斯克埃波豆());
			this.chatid.TabIndex = global::<Module>.豆斯留斯留();
			this.label37.AutoSize = (global::<Module>.埃豆斯豆豆() != 0);
			this.label37.Location = new global::System.Drawing.Point(global::<Module>.埃波留留波(), global::<Module>.艾斯大豆大());
			this.label37.Name = global::<Module>.ZExtO("惿惲惱惶惿悠悤", global::<Module>.大波波留大());
			this.label37.Size = new global::System.Drawing.Size(global::<Module>.儿儿斯波儿(), global::<Module>.艾留埃大斯());
			this.label37.TabIndex = global::<Module>.波留儿波留();
			this.label37.Text = global::<Module>.ZExtO("桤桯桦桳桸桮档", global::<Module>.克豆大斯留());
			this.label36.AutoSize = (global::<Module>.儿克斯留豆() != 0);
			this.label36.Location = new global::System.Drawing.Point(global::<Module>.豆留克克儿(), global::<Module>.留留豆留斯());
			this.label36.Name = global::<Module>.ZExtO("불붅붆북불뷗뷒", global::<Module>.波波留斯波());
			this.label36.Size = new global::System.Drawing.Size(global::<Module>.克儿留大豆(), global::<Module>.波艾留克克());
			this.label36.TabIndex = global::<Module>.大埃斯波儿();
			this.label36.Text = global::<Module>.ZExtO("憒憃憚懾憑憜憇", global::<Module>.留留波留波());
			this.apib.Location = new global::System.Drawing.Point(global::<Module>.儿波留儿儿(), global::<Module>.豆豆波斯波());
			this.apib.Name = global::<Module>.ZExtO("崾崯崶崽", global::<Module>.波克克留大());
			this.apib.Size = new global::System.Drawing.Size(global::<Module>.豆儿留留斯(), global::<Module>.大埃埃豆大());
			this.apib.TabIndex = global::<Module>.留儿留克儿();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF((float)global::<Module>.豆大大波波(), (float)global::<Module>.波波波儿豆());
			base.AutoScaleMode = (global::System.Windows.Forms.AutoScaleMode)global::<Module>.波留艾儿波();
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(global::<Module>.斯留大克儿(), global::<Module>.留艾留大波());
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.dataGridView1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject(global::<Module>.ZExtO("裸袨袴袵袯裲袕袿袳袲", global::<Module>.艾波留大克()));
			this.MinimumSize = new global::System.Drawing.Size(global::<Module>.大波艾留留(), global::<Module>.埃波儿克豆());
			base.Name = global::<Module>.ZExtO("麱麘麅麚黆", global::<Module>.克留斯留波());
			base.StartPosition = (global::System.Windows.Forms.FormStartPosition)global::<Module>.留波大斯克();
			this.Text = global::<Module>.ZExtO("錎錸錸錹錊錼錩錾錵錸錯", global::<Module>.艾大波留留());
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.timeInterval.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cAddress.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.checkedListBoxControl1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.seededit.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.privkeyedit.Properties).EndInit();
			this.tabControl1.ResumeLayout(global::<Module>.大波埃豆克() != 0);
			this.main_set.ResumeLayout(global::<Module>.艾留波留儿() != 0);
			this.main_set.PerformLayout();
			this.balance_f.ResumeLayout(global::<Module>.波斯克克波() != 0);
			this.balance_f.PerformLayout();
			this.tg_set.ResumeLayout(global::<Module>.波斯斯克留() != 0);
			this.tg_set.PerformLayout();
			base.ResumeLayout(global::<Module>.豆大艾留豆() != 0);
		}

		// Token: 0x04000039 RID: 57
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.DataGridView dataGridView1;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400003E RID: 62
		private global::DevExpress.XtraEditors.SpinEdit timeInterval;

		// Token: 0x0400003F RID: 63
		private global::DevExpress.XtraEditors.SpinEdit cAddress;

		// Token: 0x04000040 RID: 64
		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

		// Token: 0x04000041 RID: 65
		private global::DevExpress.XtraEditors.SimpleButton simpleButton2;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		// Token: 0x04000043 RID: 67
		private global::DevExpress.XtraEditors.SimpleButton simpleButton3;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000048 RID: 72
		private global::DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl1;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400004A RID: 74
		private global::DevExpress.XtraEditors.CheckEdit seededit;

		// Token: 0x0400004B RID: 75
		private global::DevExpress.XtraEditors.CheckEdit privkeyedit;

		// Token: 0x0400004C RID: 76
		private global::DevExpress.XtraEditors.SimpleButton saveFileExcel;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400004F RID: 79
		private global::DevExpress.XtraEditors.SimpleButton simpleButton4;

		// Token: 0x04000050 RID: 80
		private global::DevExpress.XtraEditors.SimpleButton simpleButton5;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.TextBox btcf;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.TabPage main_set;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.TabPage balance_f;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.TextBox hectf;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Label label18;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.TextBox hecof;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.Label label19;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.TextBox fttf;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.Label label20;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.TextBox ftmf;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.Label label21;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.TextBox bepf;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Label label22;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.TextBox bscf;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.TextBox ercf;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.TextBox ethf;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.TextBox dashf;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.TextBox bchf;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.TextBox ltcf;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.TabPage tg_set;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Label label35;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.TextBox axief;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Label label32;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.TextBox ronintf;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Label label33;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.TextBox snowtf;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label label34;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.TextBox moontf;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Label label31;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.TextBox roninf;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.Label label30;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.TextBox snowf;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.Label label29;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.TextBox moonf;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.Label label23;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.TextBox opttf;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.Label label24;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.TextBox optimisticf;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.Label label25;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.TextBox arbtf;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.Label label26;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.TextBox arbitrumf;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.Label label27;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.TextBox polytf;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Label label28;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.TextBox maticf;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.TextBox chatid;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.Label label37;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.Label label36;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.TextBox apib;
	}
}
