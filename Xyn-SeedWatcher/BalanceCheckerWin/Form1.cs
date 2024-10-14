using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Serialization;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using MySql.Data.MySqlClient;
using NBitcoin;
using NBitcoin.Altcoins;
using Nethereum.Signer;
using Nethereum.Web3.Accounts;

namespace BalanceCheckerWin
{
	// Token: 0x02000004 RID: 4
	public partial class Form1 : Form
	{
		// Token: 0x0600084E RID: 2126 RVA: 0x00009794 File Offset: 0x00007994
		private void writeSetting()
		{
			this.props.Fields.bot_api = this.apib.Text;
			this.props.Fields.chatid = this.chatid.Text;
			this.props.Fields.bbtc = Convert.ToDecimal(this.btcf.Text);
			this.props.Fields.bltc = Convert.ToDecimal(this.ltcf.Text);
			this.props.Fields.bbch = Convert.ToDecimal(this.bchf.Text);
			this.props.Fields.bdash = Convert.ToDecimal(this.dashf.Text);
			this.props.Fields.beth = Convert.ToDecimal(this.ethf.Text);
			this.props.Fields.bbsc = Convert.ToDecimal(this.bscf.Text);
			this.props.Fields.bftm = Convert.ToDecimal(this.ftmf.Text);
			this.props.Fields.bht = Convert.ToDecimal(this.hecof.Text);
			this.props.Fields.bmatic = Convert.ToDecimal(this.maticf.Text);
			this.props.Fields.boptimistic = Convert.ToDecimal(this.optimisticf.Text);
			this.props.Fields.barb = Convert.ToDecimal(this.arbitrumf.Text);
			this.props.Fields.bmovr = Convert.ToDecimal(this.moonf.Text);
			this.props.Fields.bsnow = Convert.ToDecimal(this.snowf.Text);
			this.props.Fields.bronin = Convert.ToDecimal(this.roninf.Text);
			this.props.Fields.baxie = Convert.ToDecimal(this.axief.Text);
			this.props.Fields.teth = Convert.ToDecimal(this.ercf.Text);
			this.props.Fields.tbsc = Convert.ToDecimal(this.bepf.Text);
			this.props.Fields.tftm = Convert.ToDecimal(this.fttf.Text);
			this.props.Fields.tht = Convert.ToDecimal(this.hectf.Text);
			this.props.Fields.tpolygon = Convert.ToDecimal(this.polytf.Text);
			this.props.Fields.toptimistic = Convert.ToDecimal(this.opttf.Text);
			this.props.Fields.tarb = Convert.ToDecimal(this.arbtf.Text);
			this.props.Fields.tmovr = Convert.ToDecimal(this.moontf.Text);
			this.props.Fields.tsnow = Convert.ToDecimal(this.snowtf.Text);
			this.props.Fields.tronin = Convert.ToDecimal(this.ronintf.Text);
			this.props.Fields.addresses_seed = this.cAddress.Value;
			this.props.Fields.time_out_check = this.timeInterval.Value;
			this.props.Fields.seed = this.seededit.Checked;
			this.props.Fields.pk = this.privkeyedit.Checked;
			this.props.Fields.LoadFile = this.openFileDialog1.FileName;
			this.props.Fields.btc = this.checkedListBoxControl1.GetItemChecked(<Module>.留埃斯豆豆());
			this.props.Fields.ltc = this.checkedListBoxControl1.GetItemChecked(<Module>.留儿波埃斯());
			this.props.Fields.dash = this.checkedListBoxControl1.GetItemChecked(<Module>.大留斯艾克());
			this.props.Fields.bch = this.checkedListBoxControl1.GetItemChecked(<Module>.克斯留留豆());
			this.props.Fields.eth = this.checkedListBoxControl1.GetItemChecked(<Module>.波留留波波());
			this.props.Fields.bsc = this.checkedListBoxControl1.GetItemChecked(<Module>.留儿留大大());
			this.props.Fields.ftm = this.checkedListBoxControl1.GetItemChecked(<Module>.波儿波波留());
			this.props.Fields.ht = this.checkedListBoxControl1.GetItemChecked(<Module>.波波克波留());
			this.props.Fields.matic = this.checkedListBoxControl1.GetItemChecked(<Module>.豆波留埃克());
			this.props.Fields.arbiscan = this.checkedListBoxControl1.GetItemChecked(<Module>.克埃波大艾());
			this.props.Fields.optimistic = this.checkedListBoxControl1.GetItemChecked(<Module>.波留豆克斯());
			this.props.Fields.movr = this.checkedListBoxControl1.GetItemChecked(<Module>.艾艾波留波());
			this.props.Fields.snowtrace = this.checkedListBoxControl1.GetItemChecked(<Module>.波留克波留());
			this.props.Fields.ronin = this.checkedListBoxControl1.GetItemChecked(<Module>.儿埃波克儿());
			this.props.WriteXml();
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00009E60 File Offset: 0x00008060
		private void readSetting()
		{
			this.props.ReadXml();
			this.apib.Text = this.props.Fields.bot_api;
			this.chatid.Text = this.props.Fields.chatid;
			this.btcf.Text = this.props.Fields.bbtc.ToString();
			this.ltcf.Text = this.props.Fields.bltc.ToString();
			this.bchf.Text = this.props.Fields.bbch.ToString();
			this.dashf.Text = this.props.Fields.bdash.ToString();
			this.ethf.Text = this.props.Fields.beth.ToString();
			this.bscf.Text = this.props.Fields.bbsc.ToString();
			this.ftmf.Text = this.props.Fields.bftm.ToString();
			this.hecof.Text = this.props.Fields.bht.ToString();
			this.maticf.Text = this.props.Fields.bmatic.ToString();
			this.optimisticf.Text = this.props.Fields.boptimistic.ToString();
			this.arbitrumf.Text = this.props.Fields.barb.ToString();
			this.moonf.Text = this.props.Fields.bmovr.ToString();
			this.snowf.Text = this.props.Fields.bsnow.ToString();
			this.roninf.Text = this.props.Fields.bronin.ToString();
			this.axief.Text = this.props.Fields.baxie.ToString();
			this.ercf.Text = this.props.Fields.teth.ToString();
			this.bepf.Text = this.props.Fields.tbsc.ToString();
			this.fttf.Text = this.props.Fields.tftm.ToString();
			this.hectf.Text = this.props.Fields.tht.ToString();
			this.polytf.Text = this.props.Fields.tpolygon.ToString();
			this.opttf.Text = this.props.Fields.toptimistic.ToString();
			this.arbtf.Text = this.props.Fields.tarb.ToString();
			this.moontf.Text = this.props.Fields.tmovr.ToString();
			this.snowtf.Text = this.props.Fields.tsnow.ToString();
			this.ronintf.Text = this.props.Fields.tronin.ToString();
			this.cAddress.Value = this.props.Fields.addresses_seed;
			this.timeInterval.Value = this.props.Fields.time_out_check;
			this.seededit.Checked = this.props.Fields.seed;
			this.privkeyedit.Checked = this.props.Fields.pk;
			this.openFileDialog1.FileName = this.props.Fields.LoadFile;
			this.checkedListBoxControl1.SetItemChecked(<Module>.波埃克豆豆(), this.props.Fields.btc);
			this.checkedListBoxControl1.SetItemChecked(<Module>.儿波波大大(), this.props.Fields.ltc);
			this.checkedListBoxControl1.SetItemChecked(<Module>.留大留儿留(), this.props.Fields.dash);
			this.checkedListBoxControl1.SetItemChecked(<Module>.留波大留留(), this.props.Fields.bch);
			this.checkedListBoxControl1.SetItemChecked(<Module>.留艾艾豆波(), this.props.Fields.eth);
			this.checkedListBoxControl1.SetItemChecked(<Module>.克艾儿克波(), this.props.Fields.bsc);
			this.checkedListBoxControl1.SetItemChecked(<Module>.埃艾斯儿留(), this.props.Fields.ftm);
			this.checkedListBoxControl1.SetItemChecked(<Module>.儿大豆克艾(), this.props.Fields.ht);
			this.checkedListBoxControl1.SetItemChecked(<Module>.斯克留克留(), this.props.Fields.matic);
			this.checkedListBoxControl1.SetItemChecked(<Module>.留大留大豆(), this.props.Fields.arbiscan);
			this.checkedListBoxControl1.SetItemChecked(<Module>.豆波留斯留(), this.props.Fields.optimistic);
			this.checkedListBoxControl1.SetItemChecked(<Module>.克波克斯留(), this.props.Fields.movr);
			this.checkedListBoxControl1.SetItemChecked(<Module>.克波斯留大(), this.props.Fields.snowtrace);
			this.checkedListBoxControl1.SetItemChecked(<Module>.留埃留留留(), this.props.Fields.ronin);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0000A52C File Offset: 0x0000872C
		public Form1()
		{
			this.InitializeComponent();
			this.dataGridView1.DoubleBuffered(<Module>.艾波克豆艾() != 0);
			this.readSetting();
			if (this.openFileDialog1.FileName != "" && this.openFileDialog1.FileName != null)
			{
				try
				{
					string[] array = File.ReadAllLines(this.openFileDialog1.FileName);
					for (int i = <Module>.儿克留克大(); i < array.Length; i += <Module>.斯波豆留儿())
					{
						string text = array[i];
						if (text != "" && text != null)
						{
							this.mnemonics.Add(text.ToLower().Replace(<Module>.ZExtO("桄栌", <Module>.波克大斯留()), ""));
						}
					}
					this.label4.Text = <Module>.ZExtO("鵖鵵鵻鵾鵿鵾鴠鴺", <Module>.斯斯波大留()) + this.mnemonics.Count;
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0000A6CC File Offset: 0x000088CC
		public void GridChoice(DataTable items)
		{
			if (!this.seedcheck)
			{
				if (this.privkeycheck)
				{
					if (this.dataGridView1.InvokeRequired)
					{
						this.dataGridView1.Invoke(new MethodInvoker(delegate()
						{
							this.dataGridView1.DataSource = items;
							this.dataGridView1.Refresh();
						}));
						return;
					}
					this.dataGridView1.DataSource = items;
				}
				return;
			}
			if (this.dataGridView1.InvokeRequired)
			{
				this.dataGridView1.Invoke(new MethodInvoker(delegate()
				{
					this.dataGridView1.DataSource = items;
					this.dataGridView1.Refresh();
				}));
				return;
			}
			this.dataGridView1.DataSource = items;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0000A7AC File Offset: 0x000089AC
		public string TelegramSendMessage(string apilToken, string destID, string text)
		{
			string[] array = new string[<Module>.留留艾留埃()];
			array[<Module>.波留儿留波()] = <Module>.ZExtO("뢖뢊뢊뢎뢍룄룑룑뢟뢎뢗룐뢊뢛뢒뢛뢙뢌뢟뢓룐뢑뢌뢙룑뢜뢑뢊", <Module>.克儿豆艾克());
			array[<Module>.埃豆埃留克()] = apilToken;
			array[<Module>.豆波埃波克()] = <Module>.ZExtO("泳沯油沲沸沑油沯沯沽治油泣沿沴沽沨沃沵沸泡", <Module>.克克埃克艾());
			array[<Module>.波埃留留克()] = destID;
			array[<Module>.波留儿埃豆()] = <Module>.ZExtO("\0RC^R\u001b", <Module>.大留留波大());
			array[<Module>.留波大儿儿()] = text;
			string address = string.Concat(array);
			return new WebClient().DownloadString(address);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0000A840 File Offset: 0x00008A40
		public void CheckBalanceTimer(object source, ElapsedEventArgs e)
		{
			try
			{
				this.time.Stop();
				this.time.Interval = (double)this.timeInterval.Value * 1000.0;
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("\uda72\uda63\uda7f\uda17\uda75\uda56\uda5b\uda56\uda59\uda54\uda52", <Module>.大克留克留())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("㫮㫿㫣㪋㫩㫊㫇㫊㫅㫈㫎", <Module>.克留斯儿留()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("ᐤᐳᐢᑌᐵᐎᐊᐄᐏᑁᑉᑅᑈ", <Module>.大留留豆埃())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("", <Module>.克留留留波()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("褦褪褦襄褦褅褈褅褊複褁", <Module>.留大豆豆波())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("悌悀悌惮悌悯悢悯悠悭悫", <Module>.留留斯埃艾()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("댽댺댯덒댫댐댔댚댑덟덗덛덖", <Module>.波波大留斯())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("靿靸靭霐革青靖靘靓霝霕霙霔", <Module>.斯克儿埃埃()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("뮓뮁뮘믵뮗뮴뮹뮴뮻뮶뮰", <Module>.留大豆斯艾())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("ﷅ﷗﷎ﶣﷁ﷢﷯﷢﷭﷠﷦", <Module>.留豆豆波克()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("鬌鬞鬇魧鬞鬥鬡鬯鬤魪魢魮魣", <Module>.儿大留大克())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("", <Module>.豆克留波豆()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("✩✵❁✣✀✍✀✏✂✄", <Module>.艾儿克埃留())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("폏폓펧폅폦폫폦폩폤폢", <Module>.留克埃儿波()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("熃熟燦熟熤熠熮熥燫燣燯燢", <Module>.埃克留波留())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("嚽嚡囘嚡嚚嚞嚐嚛囕囝囑囜", <Module>.斯波波大豆()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("췦췪췿췢취춋췩췊췇췊췅췈췎", <Module>.艾留波留豆())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("㓍㓁㓔㓉㓃㒠㓂㓡㓬㓡㓮㓣㓥", <Module>.埃留埃大大()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("㹼㹣㹠㹵㹫㹣㹢㸁㹸㹃㹇㹉㹂㸌㸄㸈㸅", <Module>.埃斯大埃波())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("פּﭛﭘכֿﭓﭛﭚיּנּﭻﭿﭱﭺהּלּאּ﬽", <Module>.斯克留波克()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("少尮尪尷尳尷尭尪尷尽尛尊尖屾尜尿尲尿尰尽尻", <Module>.儿留大埃克())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("࠸ࠇࠃࠞࠚࠞࠄࠃࠞࠔ࠲ࠣ࠿ࡗ࠵ࠖࠛࠖ࠙ࠔࠒ", <Module>.留留波留豆()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("ꋳꋌꋈꋕꋑꋕꋏꋈꋕꋟꋹꋨꋴꊑꋨꋓꋗꋙꋒꊜꊔꊘꊕ", <Module>.艾波艾波大())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("횤횛횟횂횆횂횘횟횂횈횮횿횣훆횿횄횀횎횅훋훃훏훂", <Module>.克斯大克留()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("왜왋왜왅옵왎왳왲왪왩왯왼왾외옴옽왟왼왱왼왳왾외", <Module>.儿克儿大儿())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("緲緥緲緫綛締緝緜緄緇緁緒緐緖続經緱緒緟緒緝緐緖", <Module>.波留波埃斯()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("ᓺᓭᓺᓣᒓᓨᓕᓔᓌᓏᓉᓚᓘᓞᒒᒖᓯᓔᓐᓞᓕᒛᒓᒟᒒ", <Module>.埃留埃斯大())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("檕檂檕檌櫼檇檺檻檣檠檦檵檷檱櫽櫹檀檻檿檱檺櫴櫼櫰櫽", <Module>.儿斯波儿留()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("쯵쯷쯮쯪쮘쯺쯙쯔쯙쯖쯛쯝", <Module>.克留克波儿())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("㒵㒷㒮㒪㓘㒺㒙㒔㒙㒖㒛㒝", <Module>.儿儿留儿大()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("쉉쉋쉒쉖숩쉐쉫쉯쉡쉪숤숬술숭", <Module>.埃留波斯波())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("뵎뵌뵕뵑봮뵗뵬뵨뵦뵭봣봫봧봪", <Module>.留斯豆大大()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("䁿䁌䁜䁗䁊䁌䁋䁓䀞䁼䁟䁒䁟䁐䁝䁛", <Module>.艾留波儿豆())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("ￆ￵￥￮￳￵￲￪ﾧￅ￦￫￦￩￤￢", <Module>.克波大克儿()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("\u001b(83.(/7w\u000e51?4zr~s", <Module>.豆留艾儿大())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("", <Module>.克豆大儿埃()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("䋖䋋䋊䋍䋊䊤䋆䋥䋨䋥䋪䋧䋡", <Module>.克豆儿儿克())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("덥델덹덾덹댗덵덖덛덖덙더덒", <Module>.斯波波波波()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("檚檇檆檁檆櫥檜檧檣檭檦櫨櫠櫬櫡", <Module>.留斯埃波留())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("堥堸堹堾堹塚堣堘堜堒堙塗塟塓塞", <Module>.儿埃留波艾()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("Έῐ῁῍ᾨῊῩῤῩῦΎ῭", <Module>.斯大波埃波())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("禿禦禷离秞禼禟禒禟禐禝禛", <Module>.斯大埃豆斯()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("谍谛谌豯谍谮谣谮谡谬谪", <Module>.留留大大斯())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("禉禟禈秫禉禪禧禪禥禨禮", <Module>.艾波儿留波()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("᭏᭙᭎ᬭ᭟᭨᭮᭤᭨᭻᭨᭩", <Module>.大儿留大斯())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("ퟓퟅퟒힱퟃퟴퟲퟸퟴퟧퟴퟵ", <Module>.儿波斯波儿()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("꺍꺕꺂껡꺃꺠꺭꺠꺯꺢꺤", <Module>.克留留埃波())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("䐦䐾䐩䑊䐨䐋䐆䐋䐄䐉䐏", <Module>.波克儿大留()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("", <Module>.豆儿波留斯())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("긞긆긑깲글긷긱긻긷긤긷긶", <Module>.艾留波斯斯()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("ꂣꂦꂴꂯꃇꂥꂆꂋꂆꂉꂄꂂ", <Module>.豆波埃儿斯())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("җҒҀқӳґҲҿҲҽҰҶ", <Module>.留留留波儿()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("ᐪᐯᐽᐦᑎᐼᐋᐍᐇᐋᐘᐋᐊ", <Module>.留埃大大克())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("㔬㔩㔻㔠㕈㔺㔍㔋㔁㔍㔞㔍㔌", <Module>.埃埃斯留波()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("嘩嘨嘣噋嘩嘊嘇嘊嘅嘈嘎", <Module>.留埃大艾留())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("⶧ⶦⶭⷅ⶧ⶄⶉⶄⶋⶆⶀ", <Module>.儿留豆埃艾()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("엓엒엙얱엃열엲엸열엧열엵", <Module>.留埃埃留波())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("玏玎玅班玟玨玮玤玨玻玨玩", <Module>.儿波克留大()), typeof(decimal));
				}
				decimal d = new decimal(<Module>.豆儿留艾波());
				int i = <Module>.留波留大克();
				string text = "";
				string text2 = "";
				decimal all_token_balance = 0m;
				List<DataRow> l = (from f in this.adr_seed.AsEnumerable().AsParallel<DataRow>()
				where f.Field(<Module>.ZExtO("葏葢葢葡", <Module>.波波留大斯()))
				select f).ToList(this.adr_seed.AsEnumerable().Count<DataRow>());
				if (this.label10.InvokeRequired)
				{
					this.label10.Invoke(new MethodInvoker(delegate()
					{
						this.label10.Text = <Module>.ZExtO("橴橏橔橁橌樀橡橄橄橒橅橓橓橅橓樚樀", <Module>.豆埃波克波()) + l.Count.ToString();
					}));
				}
				else
				{
					this.label10.Text = <Module>.ZExtO("퉛퉠퉻퉮퉣툯퉎퉫퉫퉽퉪퉼퉼퉪퉼툵툯", <Module>.艾儿斯波波()) + l.Count.ToString();
				}
				List<string> list = new List<string>();
				ServicePointManager.SecurityProtocol = (SecurityProtocolType)<Module>.留埃波留艾();
				MethodInvoker <>9__2;
				MethodInvoker <>9__3;
				foreach (DataRow dataRow in l)
				{
					decimal num = 0m;
					decimal num2 = 0m;
					decimal num3 = 0m;
					decimal num4 = 0m;
					decimal num5 = 0m;
					decimal num6 = 0m;
					decimal num7 = 0m;
					decimal num8 = 0m;
					decimal num9 = 0m;
					decimal num10 = 0m;
					decimal num11 = 0m;
					decimal num12 = 0m;
					decimal num13 = 0m;
					decimal num14 = 0m;
					decimal num15 = 0m;
					decimal num16 = 0m;
					decimal num17 = 0m;
					decimal num18 = 0m;
					decimal num19 = 0m;
					decimal num20 = 0m;
					decimal num21 = 0m;
					decimal num22 = 0m;
					decimal num23 = 0m;
					decimal num24 = 0m;
					decimal num25 = 0m;
					decimal num26 = 0m;
					decimal num27 = 0m;
					decimal num28 = 0m;
					decimal num29 = 0m;
					text = dataRow[<Module>.ZExtO("\ud966\ud943\ud943\ud955\ud942\ud954\ud954", <Module>.艾留波斯留())].ToString();
					text2 = dataRow[<Module>.ZExtO("㮇㮱㮱㮰", <Module>.波埃波艾留())].ToString();
					if (this.btc && (text.StartsWith(<Module>.ZExtO("愭", <Module>.艾留波斯留())) || text.StartsWith(<Module>.ZExtO("ⶦ", <Module>.留克波克豆())) || text.StartsWith(<Module>.ZExtO("ᤙᤘ᥊", <Module>.斯波艾豆埃()))))
					{
						int j = i;
						i = j + <Module>.斯留斯波留();
						try
						{
							HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("⋁⋝⋝⋙⋚⊓⊆⊆⋋⋅⋆⋊⋂⋊⋁⋈⋀⋇⊇⋀⋇⋏⋆⊆⋈⋍⋍⋛⋌⋚⋚⊆", <Module>.艾埃斯斯儿()) + text + <Module>.ZExtO("通遃遊遗遈遄遑逘遏遖遊運", <Module>.埃斯儿波埃()));
							httpWebRequest.ReadWriteTimeout = <Module>.波儿留留留();
							using (Stream responseStream = httpWebRequest.GetResponse().GetResponseStream())
							{
								using (StreamReader streamReader = new StreamReader(responseStream))
								{
									string source2 = streamReader.ReadToEnd();
									num = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source2, <Module>.ZExtO("", <Module>.儿斯埃大豆()), <Module>.ZExtO("픠", <Module>.儿大大留大())))) / d;
									num2 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source2, <Module>.ZExtO("௡௮௩௦௫௘௥௦௫௦௩௤௢஥஽", <Module>.斯斯留克儿()), <Module>.ZExtO("ꭲ", <Module>.艾留豆儿留())))) / d;
									dataRow[<Module>.ZExtO("▾▨▿◜▾▝▐▝▒▟▙", <Module>.艾艾克艾波())] = num2;
									dataRow[<Module>.ZExtO("ꏀꏖꏁꎢꏐꏧꏡꏫꏧꏴꏧꏦ", <Module>.艾留豆克斯())] = num;
									if (num2 > this.fbalance_btc)
									{
										list.Add(<Module>.ZExtO("ᰃᰠᰭᰠᰯᰢᰤᱡᰃᰕᰂᱻᱡ", <Module>.艾留波波大()) + num2);
									}
								}
							}
							goto IL_483A;
						}
						catch
						{
							HttpWebRequest httpWebRequest2 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("⎳⎯⎯⎫⎨⏡⏴⏴⎹⎷⎴⎸⎰⎸⎳⎺⎲⎵⏵⎲⎵⎽⎴⏴⎺⎿⎿⎩⎾⎨⎨⏴", <Module>.豆留豆留克()) + text + <Module>.ZExtO("ံၯၦၻၤၨၽဴၣၺၦၧ", <Module>.大波大豆留()));
							httpWebRequest2.ReadWriteTimeout = <Module>.留儿留埃留();
							using (Stream responseStream2 = httpWebRequest2.GetResponse().GetResponseStream())
							{
								using (StreamReader streamReader2 = new StreamReader(responseStream2))
								{
									string source3 = streamReader2.ReadToEnd();
									num = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source3, <Module>.ZExtO("⒤Ⓙ⒤⒱Ⓖ⒏⒢⒵⒳⒵Ⓓ⒦⒵⒴⓲⓪", <Module>.留儿斯豆豆()), <Module>.ZExtO("뼯", <Module>.埃克波留大())))) / d;
									num2 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source3, <Module>.ZExtO("쑓쑜쑛쑔쑙쑪쑗쑔쑙쑔쑛쑖쑐쐗쐏", <Module>.斯大克艾波()), <Module>.ZExtO("獅", <Module>.儿波克波波())))) / d;
									dataRow[<Module>.ZExtO("㭕㭃㭔㬷㭕㭶㭻㭶㭹㭴㭲", <Module>.波留克留艾())] = num2;
									dataRow[<Module>.ZExtO("턱턧터텓턡턖턐턚턖턅턖턗", <Module>.留斯斯克艾())] = num;
									if (num2 > this.fbalance_btc)
									{
										list.Add(<Module>.ZExtO("℠℃ℎ℃ℌ℁ℇ⅂℠ℶ℡⅘⅂", <Module>.留豆留儿波()) + num2);
									}
								}
							}
							goto IL_483A;
						}
					}
					if (this.ltc && (text.StartsWith(<Module>.ZExtO("Ⓐ", <Module>.豆大留波大())) || text.StartsWith(<Module>.ZExtO("", <Module>.留波克留豆())) || text.StartsWith(<Module>.ZExtO("퇠", <Module>.豆艾儿斯波()))))
					{
						int j = i;
						i = j + <Module>.波艾波大儿();
						try
						{
							HttpWebRequest httpWebRequest3 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("鬊鬖鬖鬒鬑魘魍魍鬎鬋鬖鬇鬁鬍鬋鬌鬀鬎鬍鬁鬉鬇鬚鬒鬎鬍鬐鬇鬐魌鬌鬇鬖魍鬃鬆鬆鬐鬇鬑鬑魍", <Module>.豆留儿大埃()) + text);
							httpWebRequest3.ReadWriteTimeout = <Module>.波留大斯留();
							using (Stream responseStream3 = httpWebRequest3.GetResponse().GetResponseStream())
							{
								using (StreamReader streamReader3 = new StreamReader(responseStream3))
								{
									string source4 = streamReader3.ReadToEnd();
									num4 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source4, <Module>.ZExtO("⟽⟒⟕⟚⟗➛⟹⟚⟗⟚⟕⟘⟞➇⟧➔⟈⟋⟚⟕➅➇⟈⟋⟚⟕➅", <Module>.斯留留斯波()), <Module>.ZExtO("ᠪᡆᡞᡉ", <Module>.大艾儿留留()))));
									num3 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source4, <Module>.ZExtO("鱆鱽鱦鱳鱾鰲鱀鱷鱱鱷鱻鱤鱷鱶鰮鱎鰽鱡鱢鱳鱼鰬鰮鱡鱢鱳鱼鰬", <Module>.波波儿艾儿()), <Module>.ZExtO("簽籑籉籞", <Module>.大艾埃大斯()))));
									dataRow[<Module>.ZExtO("ꝦꝾꝩ꜊ꝨꝋꝆꝋꝄꝉꝏ", <Module>.大斯留豆波())] = num4;
									dataRow[<Module>.ZExtO("봪봲봥뵆봴봃봅봏봃봐봃봂", <Module>.波儿留波留())] = num3;
									if (num4 > this.fbalance_ltc)
									{
										list.Add(<Module>.ZExtO("", <Module>.豆埃留豆波()) + num4);
									}
								}
							}
							goto IL_483A;
						}
						catch
						{
							HttpWebRequest httpWebRequest4 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("醉醕醕醑醒釛野野醍醈醕醄醂醎醈醏醃醍醎醂醊醄醙醑醍醎醓醄醓量醏醄醕野醀醅醅醓醄醒醒野", <Module>.留埃留波留()) + text);
							httpWebRequest4.ReadWriteTimeout = <Module>.波豆斯留大();
							using (Stream responseStream4 = httpWebRequest4.GetResponse().GetResponseStream())
							{
								using (StreamReader streamReader4 = new StreamReader(responseStream4))
								{
									string source5 = streamReader4.ReadToEnd();
									num4 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source5, <Module>.ZExtO("늗늸늿늰늽닱늓늰늽늰늿늲늴닭늍닾늢늡늰늿닯닭늢늡늰늿닯", <Module>.斯留克儿波()), <Module>.ZExtO("챫찇찟찈", <Module>.斯留埃埃斯()))));
									num3 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source5, <Module>.ZExtO("聾量便殺諒櫓弄若沈若兩不若掠來淚菉異率殺勵勞來異率殺勵勞", <Module>.埃豆艾留大()), <Module>.ZExtO("䶨䷄䷜䷋", <Module>.艾克大埃豆()))));
									dataRow[<Module>.ZExtO("螶螮螹蟚螸螛螖螛螔螙螟", <Module>.大豆儿波斯())] = num4;
									dataRow[<Module>.ZExtO("ųūżğŭŚŜŖŚŉŚś", <Module>.斯埃艾留留())] = num3;
									if (num4 > this.fbalance_ltc)
									{
										list.Add(<Module>.ZExtO("鄖鄵鄸鄵鄺鄷鄱酴鄘鄀鄗酮酴", <Module>.大豆埃儿斯()) + num4);
									}
								}
							}
							goto IL_483A;
						}
					}
					if (this.bch && text.StartsWith(<Module>.ZExtO("쭁", <Module>.艾艾留艾斯())))
					{
						int j = i;
						i = j + <Module>.埃埃留波波();
						try
						{
							HttpWebRequest httpWebRequest5 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("", <Module>.艾留艾埃留()) + text);
							httpWebRequest5.ReadWriteTimeout = <Module>.艾艾斯留埃();
							using (Stream responseStream5 = httpWebRequest5.GetResponse().GetResponseStream())
							{
								using (StreamReader streamReader5 = new StreamReader(responseStream5))
								{
									string source6 = streamReader5.ReadToEnd();
									num6 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source6, <Module>.ZExtO("妳妜妛妔妙姕妷妔妙妔妛妖妐姉妩姚妆妅妔妛始姉妆妅妔妛始", <Module>.斯克大波艾()), <Module>.ZExtO("쓯쒍쒌쒇", <Module>.克大斯艾留()))));
									num5 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source6, <Module>.ZExtO("\udec8\udef3\udee8\udefd\udef0\udebc\udece\udef9\udeff\udef9\udef5\udeea\udef9\udef8\udea0\udec0\udeb3\udeef\udeec\udefd\udef2\udea2\udea0\udeef\udeec\udefd\udef2\udea2", <Module>.埃留豆艾波()), <Module>.ZExtO("䧡䦃䦂䦉", <Module>.埃大儿波豆()))));
									dataRow[<Module>.ZExtO("輘輙輒轺輘輻輶輻輴輹輿", <Module>.斯埃豆埃儿())] = num6;
									dataRow[<Module>.ZExtO("䘱䘰䘻䙓䘡䘖䘐䘚䘖䘅䘖䘗", <Module>.波波艾豆留())] = num5;
									if (num6 > this.fbalance_bch)
									{
										list.Add(<Module>.ZExtO("᷐᷐ᷳᷝᷟ᷒ᷔᶑ᷹ᷳᷲᶋᶑ", <Module>.波波艾儿豆()) + num6);
									}
								}
							}
							goto IL_483A;
						}
						catch
						{
							HttpWebRequest httpWebRequest6 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("颦颺颺颾颽飴飡飡颬颭颦颬颢颡颭颥颫颶颾颢颡颼颫颼飠颭颡颣飡颯颪颪颼颫颽颽飡颬颧颺颭颡颧颠颭颯颽颦飴", <Module>.留大波埃埃()) + text);
							httpWebRequest6.ReadWriteTimeout = <Module>.波留大留儿();
							using (Stream responseStream6 = httpWebRequest6.GetResponse().GetResponseStream())
							{
								using (StreamReader streamReader6 = new StreamReader(responseStream6))
								{
									string source7 = streamReader6.ReadToEnd();
									num6 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source7, <Module>.ZExtO("\uddc5\uddea\udded\udde2\uddef\udda3\uddc1\udde2\uddef\udde2\udded\udde0\udde6\uddbf\udddf\uddac\uddf0\uddf3\udde2\udded\uddbd\uddbf\uddf0\uddf3\udde2\udded\uddbd", <Module>.儿艾埃大波()), <Module>.ZExtO("㪥㫇㫆㫍", <Module>.大豆留留波()))));
									num5 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source7, <Module>.ZExtO("䦦䦝䦆䦓䦞䧒䦠䦗䦑䦗䦛䦄䦗䦖䧎䦮䧝䦁䦂䦓䦜䧌䧎䦁䦂䦓䦜䧌", <Module>.克斯斯波留()), <Module>.ZExtO("ỹẛẚẑ", <Module>.波波斯儿克()))));
									dataRow[<Module>.ZExtO("載輈較轫載輪輧輪輥輨輮", <Module>.大斯斯艾大())] = num6;
									dataRow[<Module>.ZExtO("杖杗杜朴杆東杷杽東杢東杰", <Module>.波留儿儿斯())] = num5;
									if (num6 > this.fbalance_bch)
									{
										list.Add(<Module>.ZExtO("", <Module>.波波埃波豆()) + num6);
									}
								}
							}
							goto IL_483A;
						}
					}
					if (this.dash && text.StartsWith(<Module>.ZExtO("꧷", <Module>.克波斯克留())))
					{
						int j = i;
						i = j + <Module>.留斯埃留波();
						try
						{
							HttpWebRequest httpWebRequest7 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("᧵᧩᧩᧭᧮ᦧᦲᦲ᧹᧼᧮᧵᧿᧱᧲᧾᧶᧸᧥᧭᧱᧲᧯᧸᧯ᦳ᧾᧲᧰ᦲ᧼᧹᧹᧯᧸᧮᧮ᦲ", <Module>.斯埃艾克大()) + text);
							httpWebRequest7.ReadWriteTimeout = <Module>.埃儿艾波波();
							using (Stream responseStream7 = httpWebRequest7.GetResponse().GetResponseStream())
							{
								using (StreamReader streamReader7 = new StreamReader(responseStream7))
								{
									string source8 = streamReader7.ReadToEnd();
									num8 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source8, <Module>.ZExtO("礇礨礯礠礭祡礃礠礭礠礯礢礤祽礝祮礲礱礠礯祿祽礲礱礠礯祿", <Module>.留大波豆埃()), <Module>.ZExtO("혫홏홊환홃", <Module>.留斯波大波()))));
									num7 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source8, <Module>.ZExtO("ꮯꮔꮏꮚꮗꯛꮩꮞꮘꮞꮒꮍꮞꮟꯇꮧꯔꮈꮋꮚꮕꯅꯇꮈꮋꮚꮕꯅ", <Module>.波克留留儿()), <Module>.ZExtO("ⲡⳅⳀⳒⳉ", <Module>.大留埃斯大()))));
									dataRow[<Module>.ZExtO("熘熝熏熔燼熞熽熰熽熲熿熹", <Module>.埃克波留埃())] = num8;
									dataRow[<Module>.ZExtO("ﾷﾲﾠﾻￓﾡﾖﾐﾚﾖﾅﾖﾗ", <Module>.波斯留波斯())] = num7;
									if (num8 > this.fbalance_dash)
									{
										list.Add(<Module>.ZExtO("閄閧閪閧閨閥閣闦閂閇閕閎闼闦", <Module>.波斯斯豆留()) + num8);
									}
								}
							}
							goto IL_483A;
						}
						catch
						{
							HttpWebRequest httpWebRequest8 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("ဥ္္ွှၷၢၢဩာှဥုအဢီဦဨဵွအဢဿဨဿၣီဢဠၢာဩဩဿဨှှၢ", <Module>.留埃大克埃()) + text);
							httpWebRequest8.ReadWriteTimeout = <Module>.艾留波留波();
							using (Stream responseStream8 = httpWebRequest8.GetResponse().GetResponseStream())
							{
								using (StreamReader streamReader8 = new StreamReader(responseStream8))
								{
									string source9 = streamReader8.ReadToEnd();
									num8 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source9, <Module>.ZExtO("篳篜篛篔篙箕篷篔篙篔篛篖篐箉篩箚篆篅篔篛箋箉篆篅篔篛箋", <Module>.克克波留埃()), <Module>.ZExtO("亥仁仄他仍", <Module>.留艾大留大()))));
									num7 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source9, <Module>.ZExtO("", <Module>.大豆艾豆大()), <Module>.ZExtO("䂫䃏䃊䃘䃃", <Module>.斯儿大克儿()))));
									dataRow[<Module>.ZExtO("㬬㬩㬻㬠㭈㬪㬉㬄㬉㬆㬋㬍", <Module>.克留留波留())] = num8;
									dataRow[<Module>.ZExtO("趥趠趲趩跁足趄趂趈趄趗趄超", <Module>.大斯留斯儿())] = num7;
									if (num8 > this.fbalance_dash)
									{
										list.Add(<Module>.ZExtO("ᵩᵊᵇᵊᵅᵈᵎᴋᵯᵪᵸᵣᴑᴋ", <Module>.留波留波豆()) + num8);
									}
								}
							}
							goto IL_483A;
						}
					}
					if (text.StartsWith(<Module>.ZExtO("ꫨꪠ", <Module>.艾波埃波儿())) && (this.eth || this.bsc || this.ftm || this.ht || this.polygon || this.snowtrace || this.arbitrum || this.movr || this.ronint || this.optimeth))
					{
						int j = i;
						i = j + <Module>.克留波艾克();
						if (this.eth && text.StartsWith(<Module>.ZExtO("舥艭", <Module>.留留大留波())))
						{
							try
							{
								HttpWebRequest httpWebRequest9 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("빽빡빡빥빦븯븺븺빰빡빽빰빧빦빶빴빻븻빼빺븺빴빱빱빧빰빦빦븺", <Module>.豆克儿留斯()) + text);
								httpWebRequest9.ReadWriteTimeout = <Module>.斯斯波艾儿();
								using (Stream responseStream9 = httpWebRequest9.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader9 = new StreamReader(responseStream9))
									{
										string source10 = streamReader9.ReadToEnd();
										try
										{
											num9 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source10, <Module>.ZExtO("荰荼荿茾荾荷茾茫茱茭", <Module>.大儿克波留()), <Module>.ZExtO("㻽㺘㺩㺵㺸㺯", <Module>.豆埃克埃儿())).Replace(<Module>.ZExtO("흺휤흸", <Module>.波儿豆波留()), "").Replace(<Module>.ZExtO("촄촗쵚촆", <Module>.大克大斯豆()), "")));
										}
										catch
										{
											num9 = 0m;
										}
										try
										{
											num20 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source10, <Module>.ZExtO("腸脩脶脳脾脿脓脴脏脪腸腺脾脻脮脻腷脯脴脼脵脶脾腷脻脴脳脷脻脮脳脵脴腷脵脯脮腧腸脼脻脾脿脕脯脮腸腤脆脴脆脞", <Module>.留留豆留波()), <Module>.ZExtO("잶임쟖잙잚잋임", <Module>.波波豆克儿())).Replace(<Module>.ZExtO("㐡", <Module>.大埃波儿大()), "")));
										}
										catch
										{
											num20 = 0m;
										}
										dataRow[<Module>.ZExtO("\ud93c\ud92d\ud931\ud959\ud93b\ud918\ud915\ud918\ud917\ud91a\ud91c", <Module>.波波豆波斯())] = num9;
										dataRow[<Module>.ZExtO("ጆ጑ጀ፮጗ጬጨጦጭ፣፫፧፪", <Module>.留大大斯豆())] = num20;
										all_token_balance += num20;
										if (num9 > this.fbalance_eth)
										{
											list.Add(<Module>.ZExtO("聧聄聉聄聋聆聀者聠聱聭耟者", <Module>.斯克斯波豆()) + num9);
										}
										if (num20 > this.ftoken_erc)
										{
											list.Add(<Module>.ZExtO("凄凓凂冬决冱冡凕凮凪凤凯冡冩冥冨冻冡", <Module>.埃豆斯儿留()) + num20);
										}
									}
								}
							}
							catch
							{
								HttpWebRequest httpWebRequest10 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("㾭㾱㾱㾵㾶㿿㿪㿪㾠㾱㾭㾠㾷㾶㾦㾤㾫㿫㾬㾪㿪㾤㾡㾡㾷㾠㾶㾶㿪", <Module>.波儿儿埃波()) + text);
								httpWebRequest10.ReadWriteTimeout = <Module>.斯埃埃大波();
								using (Stream responseStream10 = httpWebRequest10.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader10 = new StreamReader(responseStream10))
									{
										string source11 = streamReader10.ReadToEnd();
										try
										{
											num9 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source11, <Module>.ZExtO("", <Module>.波斯大埃克()), <Module>.ZExtO("줱쥔쥥쥹쥴쥣", <Module>.艾克留埃克())).Replace(<Module>.ZExtO("찹챧찻", <Module>.艾艾波留留()), "").Replace(<Module>.ZExtO("괟괌굁괝", <Module>.斯留艾斯艾()), "")));
										}
										catch
										{
											num9 = 0m;
										}
										try
										{
											num20 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source11, <Module>.ZExtO("ꌎꍟꍀꍅꍈꍉꍥꍂꍹꍜꌎꌌꍈꍍꍘꍍꌁꍙꍂꍊꍃꍀꍈꌁꍍꍂꍅꍁꍍꍘꍅꍃꍂꌁꍃꍙꍘꌑꌎꍊꍍꍈꍉꍣꍙꍘꌎꌒꍰꍂꍰꍨ", <Module>.波留波波豆()), <Module>.ZExtO("阴阆陔阛阘阉阆", <Module>.儿克豆大豆())).Replace(<Module>.ZExtO("錤", <Module>.波斯豆波斯()), "")));
										}
										catch
										{
											num20 = 0m;
										}
										dataRow[<Module>.ZExtO("쮀쮑쮍쯥쮇쮤쮩쮤쮫쮦쮠", <Module>.埃留克斯波())] = num9;
										dataRow[<Module>.ZExtO("", <Module>.豆波克留大())] = num20;
										all_token_balance += num20;
										if (num9 > this.fbalance_eth)
										{
											list.Add(<Module>.ZExtO("䮫䮈䮅䮈䮇䮊䮌䯉䮬䮽䮡䯓䯉", <Module>.留豆克留斯()) + num9);
										}
										if (num20 > this.ftoken_erc)
										{
											list.Add(<Module>.ZExtO("⻲⻥⻴⺚⺅⺇⺗⻣⻘⻜⻒⻙⺗⺟⺓⺞⺍⺗", <Module>.儿波留儿埃()) + num20);
										}
									}
								}
							}
						}
						if (this.bsc && text.StartsWith(<Module>.ZExtO("", <Module>.豆波留克波())))
						{
							try
							{
								HttpWebRequest httpWebRequest11 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("౻౧౧ౣౠ఩఼఼౱ౠ౰ౠ౰౲౽ఽ౰౼౾఼౲౷౷ౡ౶ౠౠ఼", <Module>.波斯克埃波()) + text);
								httpWebRequest11.ReadWriteTimeout = <Module>.大艾豆斯留();
								using (Stream responseStream11 = httpWebRequest11.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader11 = new StreamReader(responseStream11))
									{
										string source12 = streamReader11.ReadToEnd();
										try
										{
											num10 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source12, <Module>.ZExtO("", <Module>.大大大留儿()), <Module>.ZExtO("\udaa0\udac2\udace\udac2", <Module>.豆儿大留埃())).Replace(<Module>.ZExtO("緉綗緋", <Module>.波豆留克斯()), "").Replace(<Module>.ZExtO("䪏䪜䫑䪍", <Module>.大波大波大()), "")));
										}
										catch
										{
											num10 = 0m;
										}
										try
										{
											num21 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source12, <Module>.ZExtO("ꄐꅁꅞꅛꅖꅗꅻꅜꅧꅂꄐꄒꅖꅓꅆꅓꄟꅇꅜꅔꅝꅞꅖꄟꅓꅜꅛꅟꅓꅆꅛꅝꅜꄟꅝꅇꅆꄏꄐꅔꅓꅖꅗꅽꅇꅆꄐꄌꅮꅜꅮꅶ", <Module>.艾波埃留豆()), <Module>.ZExtO("눳눁뉓눜눟눎눁", <Module>.波斯埃克埃())).Replace(<Module>.ZExtO("ﺘ", <Module>.大豆豆豆留()), "")));
										}
										catch
										{
											num21 = 0m;
										}
										dataRow[<Module>.ZExtO("", <Module>.波克埃豆埃())] = num10;
										dataRow[<Module>.ZExtO("䉈䉏䉚䈧䉞䉥䉡䉯䉤䈪䈢䈮䈣", <Module>.斯克豆克儿())] = num21;
										all_token_balance += num21;
										if (num10 > this.fbalance_bsc)
										{
											list.Add(<Module>.ZExtO("꤉ꤪꤧꤪꤥꤨ꤮ꥫ꤉ꤘ꤈ꥱꥫ", <Module>.留儿埃波埃()) + num10);
										}
										if (num21 > this.ftoken_bsc)
										{
											list.Add(<Module>.ZExtO("諌請諞誣誼誾誮諚諡諥諫諠誮誦說誧誴誮", <Module>.留斯斯豆豆()) + num21);
										}
									}
								}
							}
							catch
							{
								dataRow[<Module>.ZExtO("꬐꬜꬐ꭲ꬐ꬳꬾꬳꬼꬱꬷ", <Module>.留大留留豆())] = <Module>.儿艾克留波();
								dataRow[<Module>.ZExtO("ꈔꈓꈆꉻꈂꈹꈽꈳꈸꉶꉾꉲꉿ", <Module>.留埃留斯留())] = <Module>.斯波大儿克();
								continue;
							}
						}
						if (this.ftm && text.StartsWith(<Module>.ZExtO("泳治", <Module>.波波豆斯留())))
						{
							try
							{
								HttpWebRequest httpWebRequest12 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("䜢䜾䜾䜺䜹䝰䝥䝥䜬䜾䜧䜹䜩䜫䜤䝤䜩䜥䜧䝥䜫䜮䜮䜸䜯䜹䜹䝥", <Module>.埃斯大埃克()) + text);
								httpWebRequest12.ReadWriteTimeout = <Module>.埃儿埃埃埃();
								using (Stream responseStream12 = httpWebRequest12.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader12 = new StreamReader(responseStream12))
									{
										string source13 = streamReader12.ReadToEnd();
										try
										{
											num11 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source13, <Module>.ZExtO("㦀㦌㦏㧎㦎㦇㧎㧛㧁㧝", <Module>.埃艾克埃波()), <Module>.ZExtO("岩峏峝峄", <Module>.艾埃留大波())).Replace(<Module>.ZExtO("럗랉럕", <Module>.波斯波豆留()), "").Replace(<Module>.ZExtO("峡峲岿峣", <Module>.留豆留波艾()), "")));
										}
										catch
										{
											num11 = 0m;
										}
										try
										{
											num22 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source13, <Module>.ZExtO("規觞见规觉览觤觃觸觝規覍觉觌觙觌覀觘觃觋观见觉覀觌觃规觀觌觙规观觃覀观觘觙覐規觋觌觉览觢觘觙規覓觱觃觱觩", <Module>.波波大波留()), <Module>.ZExtO("䓗䓥䒷䓸䓻䓪䓥", <Module>.留大克大儿())).Replace(<Module>.ZExtO("꼫", <Module>.克埃波斯波()), "")));
										}
										catch
										{
											num22 = 0m;
										}
										dataRow[<Module>.ZExtO("", <Module>.艾大斯大留())] = num11;
										dataRow[<Module>.ZExtO("劢劰助勉劰劋劏劁劊勄勌勀勍", <Module>.波豆艾波埃())] = num22;
										all_token_balance += num22;
										if (num11 > this.fbalance_ftm)
										{
											list.Add(<Module>.ZExtO("腃腠腭腠腯腢腤脡腇腕腌脻脡", <Module>.波波大克儿()) + num11);
										}
										if (num22 > this.ftoken_ftm)
										{
											list.Add(<Module>.ZExtO("펍펟펆폫펟펤펠펮펥폫폣폯폢폱폫", <Module>.克斯斯留艾()) + num22);
										}
									}
								}
							}
							catch
							{
								HttpWebRequest httpWebRequest13 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("퇻퇧퇧퇣퇠톩톼톼퇵퇧퇾퇠퇰퇲퇽톽퇰퇼퇾톼퇲퇷퇷퇡퇶퇠퇠톼", <Module>.儿斯儿克留()) + text);
								httpWebRequest13.ReadWriteTimeout = <Module>.斯留斯艾儿();
								using (Stream responseStream13 = httpWebRequest13.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader13 = new StreamReader(responseStream13))
									{
										string source14 = streamReader13.ReadToEnd();
										try
										{
											num11 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source14, <Module>.ZExtO("ᢀᢌᢏᣎᢎᢇᣎᣛᣁᣝ", <Module>.波留艾克斯()), <Module>.ZExtO("鲔鳲鳠鳹", <Module>.克儿克大克())).Replace(<Module>.ZExtO("㕪㔴㕨", <Module>.留波豆波克()), "").Replace(<Module>.ZExtO("謧謴譹謥", <Module>.埃豆豆儿艾()), "")));
										}
										catch
										{
											num11 = 0m;
										}
										try
										{
											num22 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source14, <Module>.ZExtO("꣒ꢃꢜꢙꢔꢕꢹꢞꢥꢀ꣒꣐ꢔꢑꢄꢑ꣝ꢅꢞꢖꢟꢜꢔ꣝ꢑꢞꢙꢝꢑꢄꢙꢟꢞ꣝ꢟꢅꢄ꣍꣒ꢖꢑꢔꢕꢿꢅꢄ꣒꣎ꢬꢞꢬꢴ", <Module>.留留豆艾克()), <Module>.ZExtO("㼱㼃㽑㼞㼝㼌㼃", <Module>.大艾克波斯())).Replace(<Module>.ZExtO("㧜", <Module>.留波豆儿艾()), "")));
										}
										catch
										{
											num22 = 0m;
										}
										dataRow[<Module>.ZExtO("恡恳恪怇恥恆恋恆恉恄恂", <Module>.豆波斯留留())] = num11;
										dataRow[<Module>.ZExtO("䞠䞲䞫䟋䞲䞉䞍䞃䞈䟆䟎䟂䟏", <Module>.波克豆大埃())] = num22;
										all_token_balance += num22;
										if (num11 > this.fbalance_ftm)
										{
											list.Add(<Module>.ZExtO("ᤆᤥᤨᤥᤪᤧᤡᥤᤂᤐᤉ᥾ᥤ", <Module>.留大斯埃波()) + num11);
										}
										if (num22 > this.ftoken_ftm)
										{
											list.Add(<Module>.ZExtO("ˤ˶˯ʂ˶ˍˉˇˌʂʊʆʋʘʂ", <Module>.斯留留豆留()) + num22);
										}
									}
								}
							}
						}
						if (this.ht && text.StartsWith(<Module>.ZExtO("ᢌᣄ", <Module>.艾留豆豆留())))
						{
							try
							{
								HttpWebRequest httpWebRequest14 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("⼆⼚⼚⼞⼝⽔⽁⽁⼆⼋⼍⼁⼇⼀⼈⼁⽀⼍⼁⼃⽁⼏⼊⼊⼜⼋⼝⼝⽁", <Module>.留艾儿埃儿()) + text);
								httpWebRequest14.ReadWriteTimeout = <Module>.波留斯波克();
								using (Stream responseStream14 = httpWebRequest14.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader14 = new StreamReader(responseStream14))
									{
										string source15 = streamReader14.ReadToEnd();
										try
										{
											num12 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source15, <Module>.ZExtO("蛿蛳蛰蚱蛱蛸蚱蚤蚾蚢", <Module>.大波克克克()), <Module>.ZExtO("ퟭ힅힙", <Module>.波豆儿留斯())).Replace(<Module>.ZExtO("풑퓏풓", <Module>.埃大埃艾豆()), "").Replace(<Module>.ZExtO("ꇤꇷꆺꇦ", <Module>.儿斯豆留埃()), "")));
										}
										catch
										{
											num12 = 0m;
										}
										try
										{
											num23 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source15, <Module>.ZExtO("탹킨킷킲킿킾킒킵킎킫탹탻킿킺킯킺탶킮킵킽킴킷킿탶킺킵킲킶킺킯킲킴킵탶킴킮킯탦탹킽킺킿킾킔킮킯탹탥킇킵킇킟", <Module>.埃留斯埃豆()), <Module>.ZExtO("〕〧ふ〺〹〨〧", <Module>.留波留儿大())).Replace(<Module>.ZExtO("蒎", <Module>.埃克留豆留()), "")));
										}
										catch
										{
											num23 = 0m;
										}
										dataRow[<Module>.ZExtO("撗撋擿撝撾撳撾撱撼撺", <Module>.留波波波埃())] = num12;
										dataRow[<Module>.ZExtO("ꝯꝳ꜊ꝳꝈꝌꝂꝉ꜇꜏꜃꜎", <Module>.儿斯波儿留())] = num23;
										all_token_balance += num23;
										if (num12 > this.fbalance_ht)
										{
											list.Add(<Module>.ZExtO("㟚㟹㟴㟹㟶㟻㟽㞸㟐㟝㟛㟗㞢㞸", <Module>.斯留埃埃豆()) + num12);
										}
										if (num23 > this.ftoken_ht)
										{
											list.Add(<Module>.ZExtO("啧啪啬啠唏啻啀啄啊啁唏唇唋唆唕唏", <Module>.留留波波埃()) + num23);
										}
									}
								}
							}
							catch
							{
								HttpWebRequest httpWebRequest15 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("鲔鲈鲈鲌鲏鳆鳓鳓鲔鲙鲟鲓鲕鲒鲚鲓鳒鲟鲓鲑鳓鲝鲘鲘鲎鲙鲏鲏鳓", <Module>.波留埃克大()) + text);
								httpWebRequest15.ReadWriteTimeout = <Module>.大埃豆斯斯();
								using (Stream responseStream15 = httpWebRequest15.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader15 = new StreamReader(responseStream15))
									{
										string source16 = streamReader15.ReadToEnd();
										try
										{
											num12 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source16, <Module>.ZExtO("阮流柳麗杻療麗劣驪鍊", <Module>.留留克埃留()), <Module>.ZExtO("᫴᪜᪀", <Module>.留留克波波())).Replace(<Module>.ZExtO("꧱ꦯ꧳", <Module>.留波艾克波()), "").Replace(<Module>.ZExtO("", <Module>.大大留儿波()), "")));
										}
										catch
										{
											num12 = 0m;
										}
										try
										{
											num23 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source16, <Module>.ZExtO("揥掴掫掮掣探掎掩排掷揥揧掣掦掳掦揪掲掩採推掫掣揪掦掩掮措掦掳掮推掩揪推掲掳揺揥採掦掣探授掲掳揥揹掛掩掛掃", <Module>.克波儿留克()), <Module>.ZExtO("纼纎络纓纐纁纎", <Module>.埃儿斯留波())).Replace(<Module>.ZExtO("㭗", <Module>.艾斯斯波豆()), "")));
										}
										catch
										{
											num23 = 0m;
										}
										dataRow[<Module>.ZExtO("ז׊־ל׿ײ׿װ׽׻", <Module>.大波豆艾克())] = num12;
										dataRow[<Module>.ZExtO("㷔㷈㶱㷈㷳㷷㷹㷲㶼㶴㶸㶵", <Module>.儿儿艾大斯())] = num23;
										all_token_balance += num23;
										if (num12 > this.fbalance_ht)
										{
											list.Add(<Module>.ZExtO("紑紲紿紲紽細紶絳紛紖紐紜絩絳", <Module>.埃豆豆波豆()) + num12);
										}
										if (num23 > this.ftoken_ht)
										{
											list.Add(<Module>.ZExtO("鉃鉎鉈鉄鈫鉟鉤鉠鉮鉥鈫鈣鈯鈢鈱鈫", <Module>.豆克大波克()) + num23);
										}
									}
								}
							}
						}
						if (this.polygon && text.StartsWith(<Module>.ZExtO("\ud93c\ud974", <Module>.克斯斯豆波())))
						{
							try
							{
								HttpWebRequest httpWebRequest16 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("禳禯禯禫禨秡秴秴禫禴禷禢禼禴禵禨禸禺禵秵禸禴禶秴禺禿禿禩禾禨禨秴", <Module>.克儿儿埃波()) + text);
								httpWebRequest16.ReadWriteTimeout = <Module>.艾斯克克留();
								using (Stream responseStream16 = httpWebRequest16.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader16 = new StreamReader(responseStream16))
									{
										string source17 = streamReader16.ReadToEnd();
										try
										{
											num13 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source17, <Module>.ZExtO("⁘⁔⁗‖⁖\u205f‖\u2003’\u2005", <Module>.豆波大艾克()), <Module>.ZExtO("襂褯褣褶褫褡", <Module>.波克大儿克())).Replace(<Module>.ZExtO("းၦ်", <Module>.克波波艾波()), "").Replace(<Module>.ZExtO("\udeec\udeff\udeb2\udeee", <Module>.波豆波大留()), "")));
										}
										catch
										{
											num13 = 0m;
										}
										try
										{
											num24 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source17, <Module>.ZExtO("㓢㒳㒬㒩㒤㒥㒉㒮㒕㒰㓢㓠㒤㒡㒴㒡㓭㒵㒮㒦㒯㒬㒤㓭㒡㒮㒩㒭㒡㒴㒩㒯㒮㓭㒯㒵㒴㓽㓢㒦㒡㒤㒥㒏㒵㒴㓢㓾㒜㒮㒜㒄", <Module>.克克豆克豆()), <Module>.ZExtO("俪俘侊俅俆俗俘", <Module>.埃埃艾艾艾())).Replace(<Module>.ZExtO("颺", <Module>.波波波豆埃()), "")));
										}
										catch
										{
											num24 = 0m;
										}
										dataRow[<Module>.ZExtO("㇙㇕㇀㇝㇗ㆴ㇖ㇵㇸㇵㇺㇷㇱ", <Module>.艾留波大儿())] = num13;
										dataRow[<Module>.ZExtO("鈼鈣鈠鈵鈫鈣鈢鉁鈸鈃鈇鈉鈂鉌鉄鉈鉅", <Module>.豆留艾留大())] = num24;
										all_token_balance += num24;
										if (num13 > this.fbalance_matic)
										{
											list.Add(<Module>.ZExtO("ۗ۴۹۴ۻ۶۰ڵۘ۔ہۜۖگڵ", <Module>.波留埃斯大()) + num13);
										}
										if (num24 > this.ftoken_polygon)
										{
											list.Add(<Module>.ZExtO("", <Module>.儿波波大波()) + num24);
										}
									}
								}
							}
							catch
							{
								HttpWebRequest httpWebRequest17 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("ۨ۴۴۰۳ںگگ۰ۯ۬۹ۧۯۮ۳ۣۡۮڮۣۯۭگۡۤۤ۲ۥ۳۳گ", <Module>.波波克艾埃()) + text);
								httpWebRequest17.ReadWriteTimeout = <Module>.大艾波埃大();
								using (Stream responseStream17 = httpWebRequest17.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader17 = new StreamReader(responseStream17))
									{
										string source18 = streamReader17.ReadToEnd();
										try
										{
											num13 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source18, <Module>.ZExtO("▋▇▄◅▅▌◅◐◊◖", <Module>.大豆留艾斯()), <Module>.ZExtO("컈캥캩캼캡캫", <Module>.艾斯留艾留())).Replace(<Module>.ZExtO("틼튢틾", <Module>.斯艾克留留()), "").Replace(<Module>.ZExtO("﷨ﷻﶶ﷪", <Module>.斯豆大斯豆()), "")));
										}
										catch
										{
											num13 = 0m;
										}
										try
										{
											num24 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source18, <Module>.ZExtO("壁墐墏墊墇墆墪墍墶墓壁壃墇墂増墂壎墖墍墅墌墏墇壎墂墍墊墎墂増墊墌墍壎墌墖増壞壁墅墂墇墆墬墖増壁壝墿墍墿墧", <Module>.波埃留留斯()), <Module>.ZExtO("", <Module>.斯儿克斯大())).Replace(<Module>.ZExtO("酥", <Module>.波埃留艾豆()), "")));
										}
										catch
										{
											num24 = 0m;
										}
										dataRow[<Module>.ZExtO("ﬁ﬍﬘ﬅ﬏ﭬ﬎שּׂﬠשּׂﬢאָ﬩", <Module>.留豆留埃波())] = num13;
										dataRow[<Module>.ZExtO("蝎蝑蝒蝇蝙蝑蝐蜳蝊蝱蝵蝻蝰蜾蜶蜺蜷", <Module>.波留克波克())] = num24;
										all_token_balance += num24;
										if (num13 > this.fbalance_matic)
										{
											list.Add(<Module>.ZExtO("⦆⦥⦨⦥⦪⦧⦡⧤⦉⦅⦐⦍⦇⧾⧤", <Module>.斯大大克留()) + num13);
										}
										if (num24 > this.ftoken_polygon)
										{
											list.Add(<Module>.ZExtO("戊戵戶戣戽戵戴扺戎戵戱房戴扺扲找扳扠扺", <Module>.波斯艾埃留()) + num24);
										}
									}
								}
							}
						}
						if (this.arbitrum && text.StartsWith(<Module>.ZExtO("", <Module>.大留波大埃())))
						{
							try
							{
								HttpWebRequest httpWebRequest18 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("䪻䪧䪧䪣䪠䫩䫼䫼䪲䪡䪱䪺䪠䪰䪲䪽䫽䪺䪼䫼䪲䪷䪷䪡䪶䪠䪠䫼", <Module>.留埃大大留()) + text);
								httpWebRequest18.ReadWriteTimeout = <Module>.克埃留留埃();
								using (Stream responseStream18 = httpWebRequest18.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader18 = new StreamReader(responseStream18))
									{
										string source19 = streamReader18.ReadToEnd();
										try
										{
											num15 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source19, <Module>.ZExtO("㝇㝋㝈㜉㝉㝀㜉㜜㜆㜚", <Module>.斯留大波留()), <Module>.ZExtO("", <Module>.艾留埃波埃())).Replace(<Module>.ZExtO("뼡뽿뼣", <Module>.留波埃大豆()), "").Replace(<Module>.ZExtO("", <Module>.克留波波艾()), "")));
										}
										catch
										{
											num15 = 0m;
										}
										try
										{
											num26 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(source19, <Module>.ZExtO("", <Module>.埃艾斯豆豆()), <Module>.ZExtO("럄랼랰럃럄럼랴럄랶럅랲랱", <Module>.波艾留豆埃())).Replace(<Module>.ZExtO("袾", <Module>.克波波克儿()), "")));
										}
										catch
										{
											num26 = 0m;
										}
										dataRow[<Module>.ZExtO("", <Module>.留留克艾大())] = num15;
										dataRow[<Module>.ZExtO("䏾䏍䏝䏖䏋䏍䏊䏒䎒䏫䏐䏔䏚䏑䎟䎗䎛䎖", <Module>.留波埃斯克())] = num26;
										all_token_balance += num26;
										if (num15 > this.fbalance_arbiscan)
										{
											list.Add(<Module>.ZExtO("攥攆攋攆攉攄攂敇攦攕攅攎攔攄攆攉敝敇", <Module>.波埃豆大大()) + num15);
										}
										if (num26 > this.ftoken_arbiscan)
										{
											list.Add(<Module>.ZExtO("᎟ᎬᎼᎷᎭᎽᎿᎰ᏾ᎊᎱᎵᎻᎰ᏾᏶ᏺ᏷Ꮴ᏾", <Module>.艾艾波斯埃()) + num26);
										}
									}
								}
							}
							catch
							{
								HttpWebRequest httpWebRequest19 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("↛ↇↇↃↀ⇉⇜⇜→ↁ↑↚ↀ←→↝⇝↚↜⇜→↗↗ↁ↖ↀↀ⇜", <Module>.艾大大留克()) + text);
								httpWebRequest19.ReadWriteTimeout = <Module>.豆豆埃波豆();
								using (Stream responseStream19 = httpWebRequest19.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader19 = new StreamReader(responseStream19))
									{
										string source20 = streamReader19.ReadToEnd();
										try
										{
											num15 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source20, <Module>.ZExtO("뮸뮴뮷믶뮶뮿믶믣믹믥", <Module>.克埃豆儿埃()), <Module>.ZExtO("\ud9d7\ud9b2\ud9a3\ud9bf", <Module>.斯波留波克())).Replace(<Module>.ZExtO("⛂⚜⛀", <Module>.艾艾豆留留()), "").Replace(<Module>.ZExtO("艰艣舮色", <Module>.大艾艾儿波()), "")));
										}
										catch
										{
											num15 = 0m;
										}
										try
										{
											num26 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(source20, <Module>.ZExtO("什仅仐仅争仑今仂介仈什争仅今仍仉仅仐仍介今争介仑仐亙了仂仅什仁仫仑仐了亚亏", <Module>.留埃克埃埃()), <Module>.ZExtO("", <Module>.艾艾儿波大())).Replace(<Module>.ZExtO("윩", <Module>.留大儿大埃()), "")));
										}
										catch
										{
											num26 = 0m;
										}
										dataRow[<Module>.ZExtO("ꋾꋍꋝꋖꋋꋍꋊꋒꊟꋽꋞꋓꋞꋑꋜꋚ", <Module>.波克斯斯埃())] = num15;
										dataRow[<Module>.ZExtO("纣纐纀纋纖纐纗纏经纶纍纉纇續绂绊细绋", <Module>.斯儿大克波())] = num26;
										all_token_balance += num26;
										if (num15 > this.fbalance_arbiscan)
										{
											list.Add(<Module>.ZExtO("㹩㹊㹇㹊㹅㹈㹎㸋㹪㹙㹉㹂㹘㹈㹊㹅㸑㸋", <Module>.埃大留豆波()) + num15);
										}
										if (num26 > this.ftoken_arbiscan)
										{
											list.Add(<Module>.ZExtO("䐏䐼䐬䐧䐽䐭䐯䐠䑮䐚䐡䐥䐫䐠䑮䑦䑪䑧䑴䑮", <Module>.大波波豆波()) + num26);
										}
									}
								}
							}
						}
						if (this.optimeth && text.StartsWith(<Module>.ZExtO("", <Module>.埃豆留儿留())))
						{
							try
							{
								HttpWebRequest httpWebRequest20 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("ᖽᖡᖡᖥᖦᗯᗺᗺᖺᖥᖡᖼᖸᖼᖦᖡᖼᖶᗻᖰᖡᖽᖰᖧᖦᖶᖴᖻᗻᖼᖺᗺᖴᖱᖱᖧᖰᖦᖦᗺ", <Module>.儿波留克儿()) + text);
								httpWebRequest20.ReadWriteTimeout = <Module>.斯豆艾留克();
								using (Stream responseStream20 = httpWebRequest20.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader20 = new StreamReader(responseStream20))
									{
										string source21 = streamReader20.ReadToEnd();
										try
										{
											num14 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source21, <Module>.ZExtO("", <Module>.斯波大艾克()), <Module>.ZExtO("뢚룿룎룒룟룈", <Module>.波波豆儿埃())).Replace(<Module>.ZExtO("", <Module>.斯埃儿艾豆()), "").Replace(<Module>.ZExtO("", <Module>.克豆儿豆豆()), "")));
										}
										catch
										{
											num14 = 0m;
										}
										try
										{
											num25 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(source21, <Module>.ZExtO("窏窊窟窊竆窞窅窍窄窇窏竆窊窅窂窆窊窟窂窄窅竆窄窞窟竖竉窍窊窏窎窤窞窟竉竕竀", <Module>.波大艾波波()), <Module>.ZExtO("\udd58\udd20\udd2c\udd5f\udd58\udd60\udd28\udd58\udd2a\udd59\udd2e\udd2d", <Module>.波斯斯留斯())).Replace(<Module>.ZExtO("쏰", <Module>.埃波艾波艾()), "")));
										}
										catch
										{
											num25 = 0m;
										}
										dataRow[<Module>.ZExtO("ꁿꁀꁄꁙꁝꁙꁃꁄꁙꁓꁵꁤꁸꀐꁲꁑꁜꁑꁞꁓꁕ", <Module>.豆埃留波艾())] = num14;
										dataRow[<Module>.ZExtO("䣣䣜䣘䣅䣁䣅䣟䣘䣅䣏䣩䣸䣤䢁䣸䣃䣇䣉䣂䢌䢄䢈䢅", <Module>.斯豆斯艾斯())] = num25;
										all_token_balance += num25;
										if (num14 > this.fbalance_oteth)
										{
											list.Add(<Module>.ZExtO("\udadb\udaf8\udaf5\udaf8\udaf7\udafa\udafc\udab9\udad6\udae9\udaed\udaf0\udaf4\udaf0\udaea\udaed\udaf0\udafa\udaa3\udab9", <Module>.艾埃留克留()) + num14);
										}
										if (num25 > this.ftoken_oteth)
										{
											list.Add(<Module>.ZExtO("ᔬᔓᔗᔊᔎᔊᔐᔗᔊᔀᕃᔷᔌᔈᔆᔍᕃᕋᕇᕊᕙᕃ", <Module>.大大儿留儿()) + num25);
										}
									}
								}
							}
							catch
							{
								HttpWebRequest httpWebRequest21 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("腮腲腲腶腵脼脩脩腩腶腲腯腫腯腵腲腯腥脨腣腲腮腣腴腵腥腧腨脨腯腩脩腧腢腢腴腣腵腵脩", <Module>.豆波艾克波()) + text);
								httpWebRequest21.ReadWriteTimeout = <Module>.艾艾留波豆();
								using (Stream responseStream21 = httpWebRequest21.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader21 = new StreamReader(responseStream21))
									{
										string source22 = streamReader21.ReadToEnd();
										try
										{
											num14 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source22, <Module>.ZExtO("৫১৤থ৥৬থরপশ", <Module>.留留豆豆埃()), <Module>.ZExtO("莡菄菵菩菤菳", <Module>.埃埃留大儿())).Replace(<Module>.ZExtO("բԼՠ", <Module>.留埃埃留波()), "").Replace(<Module>.ZExtO("", <Module>.波大克豆留()), "")));
										}
										catch
										{
											num14 = 0m;
										}
										try
										{
											num25 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(source22, <Module>.ZExtO("寚察寊察宓寋寐寘寑寒寚宓察寐寗寓察寊寗寑寐宓寑寋寊它宜寘察寚寛寱寋寊宜宀宕", <Module>.波埃儿埃儿()), <Module>.ZExtO("ᱤᰜᰐᱣᱤᱜᰔᱤᰖᱥᰒᰑ", <Module>.斯留儿埃埃())).Replace(<Module>.ZExtO("躥", <Module>.儿波波儿儿()), "")));
										}
										catch
										{
											num25 = 0m;
										}
										dataRow[<Module>.ZExtO("灠灟灛灆灂灆灜灛灆灌灪灻灧瀏灭灎灃灎灁灌灊", <Module>.克克留埃留())] = num14;
										dataRow[<Module>.ZExtO("癏癰癴癩癭癩癳癴癩癣癅癔癈瘭癔癯癫癥癮瘠瘨瘤瘩", <Module>.大留大克斯())] = num25;
										all_token_balance += num25;
										if (num14 > this.fbalance_oteth)
										{
											list.Add(<Module>.ZExtO("㑯㑌㑁㑌㑃㑎㑈㐍㑢㑝㑙㑄㑀㑄㑞㑙㑄㑎㐗㐍", <Module>.留波埃波大()) + num14);
										}
										if (num25 > this.ftoken_oteth)
										{
											list.Add(<Module>.ZExtO("騘騧騣騾騺騾騤騣騾騴驷騃騸騼騲騹驷驿驳驾驭驷", <Module>.斯留艾艾斯()) + num25);
										}
									}
								}
							}
						}
						if (this.snowtrace && text.StartsWith(<Module>.ZExtO("", <Module>.留波豆大波())))
						{
							try
							{
								HttpWebRequest httpWebRequest22 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("纛纇纇纃纀绉络络纀纝纜纄纇纁纒纐纖绝纚纜络纒纗纗纁纖纀纀络", <Module>.艾大波大埃()) + text);
								httpWebRequest22.ReadWriteTimeout = <Module>.克大波留艾();
								using (Stream responseStream22 = httpWebRequest22.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader22 = new StreamReader(responseStream22))
									{
										string source23 = streamReader22.ReadToEnd();
										try
										{
											num17 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source23, <Module>.ZExtO("摍摁摂搃摃摊搃搖搌搐", <Module>.斯波埃波艾()), <Module>.ZExtO("홬혍혚혍혔", <Module>.大儿艾留波())).Replace(<Module>.ZExtO("ꠕꡋꠗ", <Module>.留波大波波()), "").Replace(<Module>.ZExtO("単卋匆博", <Module>.斯留斯波斯()), "")));
										}
										catch
										{
											num17 = 0m;
										}
										try
										{
											num28 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(source23, <Module>.ZExtO("磳磶磣磶確磢磹磱磸磻磳確磶磹磾磺磶磣磾磸磹確磸磢磣碪碵磱磶磳磲磘磢磣碵碩碼", <Module>.波斯艾斯豆()), <Module>.ZExtO("嵹崁崍嵾嵹嵁崉嵹崋嵸崏崌", <Module>.豆儿埃克埃())).Replace(<Module>.ZExtO("﮺", <Module>.艾波斯波埃()), "")));
										}
										catch
										{
											num28 = 0m;
										}
										dataRow[<Module>.ZExtO("\ud890\ud887\ud890\ud889\ud8f9\ud882\ud8bf\ud8be\ud8a6\ud8a5\ud8a3\ud8b0\ud8b2\ud8b4\ud8f8\ud8f1\ud893\ud8b0\ud8bd\ud8b0\ud8bf\ud8b2\ud8b4", <Module>.波波克豆豆())] = num17;
										dataRow[<Module>.ZExtO("녰녧녰녩넙녢녟녞녆녅녃념녒녔넘넜녥녞녚녔녟넑넙넕넘", <Module>.波斯埃艾大())] = num28;
										all_token_balance += num28;
										if (num17 > this.fbalance_snowtrace)
										{
											list.Add(<Module>.ZExtO("ꟾ꟝Ꟑ꟝꟒꟟ꟙꞜꟽ꟪ꟽ꟤ꞆꞜ", <Module>.克豆埃艾波()) + num17);
										}
										if (num28 > this.ftoken_snowtrace)
										{
											list.Add(<Module>.ZExtO("໇໺໻໣໠໦໵໷໱ຼ໕ໂ໕໌ຽິເ໻໿໱໺ິຼະຽຮິ", <Module>.大克豆艾斯()) + num28);
										}
									}
								}
							}
							catch
							{
								HttpWebRequest httpWebRequest23 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("執埫埫埯埬垥垰垰埬埱埰埨埫埭埾埼基垱埶埰垰埾埻埻埭基埬埬垰", <Module>.埃留波留艾()) + text);
								httpWebRequest23.ReadWriteTimeout = <Module>.艾儿波波斯();
								using (Stream responseStream23 = httpWebRequest23.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader23 = new StreamReader(responseStream23))
									{
										string source24 = streamReader23.ReadToEnd();
										try
										{
											num17 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source24, <Module>.ZExtO("욺욶욵웴운욽웴웡웻웧", <Module>.克克艾儿豆()), <Module>.ZExtO("᱔ᰵᰢᰵᰬ", <Module>.波儿斯波留())).Replace(<Module>.ZExtO("왉옗왋", <Module>.克克豆豆波()), "").Replace(<Module>.ZExtO("듣듰뒽듡", <Module>.埃儿留大波()), "")));
										}
										catch
										{
											num17 = 0m;
										}
										try
										{
											num28 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(source24, <Module>.ZExtO("簱簴簡簴籸簠簻簳簺簹簱籸簴簻簼簸簴簡簼簺簻籸簺簠簡籨籷簳簴簱簰簚簠簡籷籫籾", <Module>.留波儿留埃()), <Module>.ZExtO("䨑䩩䩥䨖䨑䨩䩡䨑䩣䨐䩧䩤", <Module>.豆儿艾波波())).Replace(<Module>.ZExtO("霁", <Module>.埃波大大斯()), "")));
										}
										catch
										{
											num28 = 0m;
										}
										dataRow[<Module>.ZExtO("竮竹竮竷窇竼竁竀竘竛竝竎竌竊窆窏竭竎竃竎竁竌竊", <Module>.埃波大艾埃())] = num17;
										dataRow[<Module>.ZExtO("森棹森棷梇棼棁检棘棛棝棎棌棊梆梂棻检棄棊棁梏梇梋梆", <Module>.艾留留克克())] = num28;
										all_token_balance += num28;
										if (num17 > this.fbalance_snowtrace)
										{
											list.Add(<Module>.ZExtO("↕↶↻↶↹↴↲⇷↖ↁ↖↏⇭⇷", <Module>.豆留留波艾()) + num17);
										}
										if (num28 > this.ftoken_snowtrace)
										{
											list.Add(<Module>.ZExtO("퍾퍃퍂퍚퍙퍟퍌퍎퍈팅퍬퍻퍬퍵팄팍퍹퍂퍆퍈퍃팍팅팉팄팗팍", <Module>.留斯克埃波()) + num28);
										}
									}
								}
							}
						}
						if (this.movr && text.StartsWith(<Module>.ZExtO("믢뮪", <Module>.儿留克儿埃())))
						{
							try
							{
								HttpWebRequest httpWebRequest24 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("⒀⒜⒜⒘⒛ⓒⓇⓇ⒅⒇⒇⒆⒚⒁⒞⒍⒚Ⓠ⒅⒇⒇⒆⒛⒋⒉⒆Ⓠ⒁⒇ⓇⓇ⒉⒌⒌⒚⒍⒛⒛Ⓡ", <Module>.克克留埃波()) + text);
								httpWebRequest24.ReadWriteTimeout = <Module>.大留儿波波();
								using (Stream responseStream24 = httpWebRequest24.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader24 = new StreamReader(responseStream24))
									{
										string source25 = streamReader24.ReadToEnd();
										try
										{
											num16 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source25, <Module>.ZExtO("ાલ઱૰રહ૰૥૿ૣ", <Module>.艾大留大克()), <Module>.ZExtO("柎枣枡枸枼", <Module>.艾留艾大埃())).Replace(<Module>.ZExtO("ᶜ᷂ᶞ", <Module>.埃留留波留()), "").Replace(<Module>.ZExtO("辍辞迓辏", <Module>.留儿大艾留()), "")));
										}
										catch
										{
											num16 = 0m;
										}
										try
										{
											num27 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(source25, <Module>.ZExtO("", <Module>.留大儿艾留()), <Module>.ZExtO("厐叨古厗厐厨叠厐叢厑另句", <Module>.留埃留儿波())).Replace(<Module>.ZExtO("ꬣ", <Module>.克斯埃埃埃()), "")));
										}
										catch
										{
											num27 = 0m;
										}
										dataRow[<Module>.ZExtO("祝禎琢祈屮艹墳並墳全奔啕", <Module>.留波波留克())] = num16;
										dataRow[<Module>.ZExtO("磟磝磄磀碿磆磽磹磷磼碲確碶碻", <Module>.留豆波艾埃())] = num27;
										all_token_balance += num27;
										if (num16 > this.fbalance_moonriver)
										{
											list.Add(<Module>.ZExtO("", <Module>.大斯埃留艾()) + num16);
										}
										if (num27 > this.ftoken_moonriver)
										{
											list.Add(<Module>.ZExtO("⁚⁘⁁⁅‷⁃⁸⁼⁲⁹‷‿″‾‭‷", <Module>.儿留埃斯斯()) + num27);
										}
									}
								}
							}
							catch
							{
								HttpWebRequest httpWebRequest25 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("뛨뛴뛴뛰뛳뚺뚯뚯뛭뛯뛯뛮뛲뛩뛶뛥뛲뚮뛭뛯뛯뛮뛳뛣뛡뛮뚮뛩뛯뚯뚯뛡뛤뛤뛲뛥뛳뛳뚯", <Module>.大儿大波儿()) + text);
								httpWebRequest25.ReadWriteTimeout = <Module>.留波留艾豆();
								using (Stream responseStream25 = httpWebRequest25.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader25 = new StreamReader(responseStream25))
									{
										string source26 = streamReader25.ReadToEnd();
										try
										{
											num16 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source26, <Module>.ZExtO("ꖻꖷꖴꗵꖵꖼꗵꗠꗺꗦ", <Module>.波波波波豆()), <Module>.ZExtO("谎豣象豸豼", <Module>.留留波留儿())).Replace(<Module>.ZExtO("盆皘盄", <Module>.留艾克艾艾()), "").Replace(<Module>.ZExtO("댪댹덴댨", <Module>.斯埃豆埃克()), "")));
										}
										catch
										{
											num16 = 0m;
										}
										try
										{
											num27 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(source26, <Module>.ZExtO("㕷㕲㕧㕲㔾㕦㕽㕵㕼㕿㕷㔾㕲㕽㕺㕾㕲㕧㕺㕼㕽㔾㕼㕦㕧㔮㔱㕵㕲㕷㕶㕜㕦㕧㔱㔭㔸", <Module>.艾斯留波儿()), <Module>.ZExtO("ꩊꨲ꨾ꩍꩊꩲ꨺ꩊ꨸ꩋ꨼꨿", <Module>.留克波斯艾())).Replace(<Module>.ZExtO("봬", <Module>.波埃克儿斯()), "")));
										}
										catch
										{
											num27 = 0m;
										}
										dataRow[<Module>.ZExtO("豻豹豠豤谖豴豗豚豗豘豕豓", <Module>.留波大留克())] = num16;
										dataRow[<Module>.ZExtO("碔碖碏碋磴碍碶碲碼碷磹磱磽磰", <Module>.波埃艾艾波())] = num27;
										all_token_balance += num27;
										if (num16 > this.fbalance_moonriver)
										{
											list.Add(<Module>.ZExtO("懬懏懂懏懀懍懋憎懣懡懸懼憔憎", <Module>.波艾波波波()) + num16);
										}
										if (num27 > this.ftoken_moonriver)
										{
											list.Add(<Module>.ZExtO("栽栿栦栢桐栤栟栛栕栞桐桘桔桙桊桐", <Module>.留留波留大()) + num27);
										}
									}
								}
							}
						}
						if (this.ronint && text.StartsWith(<Module>.ZExtO("ꗁꖉ", <Module>.留留埃埃克())))
						{
							try
							{
								CookieContainer cookieContainer = new CookieContainer();
								HttpClientHandler httpClientHandler = new HttpClientHandler();
								httpClientHandler.CookieContainer = cookieContainer;
								httpClientHandler.UseCookies = (<Module>.波留斯留大() != 0);
								string str = text.Replace(<Module>.ZExtO("䓅䒍", <Module>.波波波大克()), "");
								using (HttpClient httpClient = new HttpClient(httpClientHandler))
								{
									httpClient.DefaultRequestHeaders.Add(<Module>.ZExtO("ԬԊԜԋՔԸԞԜԗԍ", <Module>.波波波豆大()), <Module>.ZExtO("‴‖\u2003‐――‘⁖⁌⁗⁉⁙⁑‮‐‗”‖‎\u200a⁙‷‭⁙⁈⁉⁗⁉⁂⁙‮‐‗⁏⁍⁂⁙\u2001⁏⁍⁐⁙‸\u2009\u2009―“‮“‛′‐‍⁖⁌⁊⁎⁗⁊⁏⁙⁑′‱‭‴‵⁕⁙―‐‒“⁙‾“‚‒‖⁐⁙›‑​‖—“⁖⁎⁁⁗⁉⁗⁊⁀⁉⁍⁗⁀⁎⁙‪‘‟‘​‐⁖⁌⁊⁎⁗⁊⁏", <Module>.留儿大埃豆()));
									Uri requestUri = new Uri(<Module>.ZExtO("༣༿༿༻༸ཱཤཤ༮༳༻༧༤༹༮༹ཥ༹༤༥༢༥༨༣༪༢༥ཥ༨༤༦ཤ༪༯༯༹༮༸༸ཤ༹༤༥༢༥ཱ", <Module>.大波艾波克()) + str);
									string result = httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, requestUri)).Result.Content.ReadAsStringAsync().Result;
									try
									{
										num18 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(result, <Module>.ZExtO("낍냂냁냐냟낑냒냝냐냂냂낌낓냝냔냐냕냘냟냖난낃낁낓낏", <Module>.留大儿大儿()), <Module>.ZExtO("ꪇꫴꫳ꫋ꪃꫳꪁꫲꪅꪆ", <Module>.艾波斯波波()))));
									}
									catch
									{
										num18 = 0m;
									}
									try
									{
										num29 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(result, <Module>.ZExtO("", <Module>.斯留儿斯大()), <Module>.ZExtO("", <Module>.大克波儿儿())).Replace(<Module>.ZExtO("䮪", <Module>.波克留克留()), "")));
									}
									catch
									{
										num29 = 0m;
									}
									try
									{
										num19 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseAxie(result, <Module>.ZExtO("\ud9c7\ud99e\ud9de\ud9dd\ud9d0\ud9dd\ud9d2\ud9df\ud9d9\ud99e\ud986\ud99e", <Module>.留艾埃埃波()), <Module>.ZExtO("钨钦钨链铥铡铯铤铋铮铮铸铯铹铹钨钰钨钺铲钹钸钳钿钺铮铨钸铫钽钻钼钾铫铯钲钹钹钻钸钻钿钺钻铩钽钳钽铮钽钳铯钽铨钽钳铮钽钾铩钨", <Module>.豆豆留儿波()))));
									}
									catch
									{
										num19 = 0m;
									}
									dataRow[<Module>.ZExtO("ỎồỒổỒẼỞỽỰỽỲỿỹ", <Module>.克儿克艾留())] = num18;
									dataRow[<Module>.ZExtO("꿯꿲꿳꿴꿳꾐꿩꿒꿖꿘꿓꾝꾕꾙꾔", <Module>.波留豆克克())] = num29;
									dataRow[<Module>.ZExtO("㔡㔸㔩㔥㕀㔢㔁㔌㔁㔎㔃㔅", <Module>.儿豆埃波儿())] = num19;
									all_token_balance += num29;
									if (num18 > this.fbalance_ronin)
									{
										list.Add(<Module>.ZExtO("䦅䦦䦫䦦䦩䦤䦢䧧䦕䦈䦉䦎䦉䧽䧧", <Module>.斯豆留克波()) + num18);
									}
									if (num29 > this.ftoken_ronin)
									{
										list.Add(<Module>.ZExtO("儷優儫儬儫充儱儊儎儀儋充免允兌兟充", <Module>.波波艾波留()) + num29);
									}
									if (num19 > this.fbalance_axie)
									{
										list.Add(<Module>.ZExtO("ꄰꄓꄞꄓꄜꄑꄗꅒꄳꄪꄻꄷꅈꅒ", <Module>.埃波克艾波()) + num19);
									}
								}
							}
							catch
							{
								dataRow[<Module>.ZExtO("쐳쐮쐯쐨쐯쑁쐣쐀쐍쐀쐏쐂쐄", <Module>.大大豆留克())] = <Module>.艾豆留斯斯();
								dataRow[<Module>.ZExtO("๦๻๺๽๺น๠๛๟๑๚ดผฐฝ", <Module>.斯克波埃克())] = <Module>.留留大波艾();
								dataRow[<Module>.ZExtO("鶖鶏鶞鶒鷷鶕鶶鶻鶶鶹鶴鶲", <Module>.埃克波大艾())] = <Module>.波克儿波波();
								continue;
							}
						}
					}
					IL_483A:
					if ((num2 > this.fbalance_btc || num4 > this.fbalance_ltc || num6 > this.fbalance_bch || num8 > this.fbalance_dash || num9 > this.fbalance_eth || num10 > this.fbalance_bsc || num11 > this.fbalance_ftm || num12 > this.fbalance_ht || num13 > this.fbalance_matic || num14 > this.fbalance_oteth || num17 > this.fbalance_snowtrace || num16 > this.fbalance_moonriver || num15 > this.fbalance_arbiscan || num18 > this.fbalance_ronin || num19 > this.fbalance_axie || num20 > this.ftoken_erc || num21 > this.ftoken_bsc || num26 > this.ftoken_arbiscan || num22 > this.ftoken_ftm || num23 > this.ftoken_ht || num27 > this.ftoken_moonriver || num25 > this.ftoken_oteth || num24 > this.ftoken_polygon || num29 > this.ftoken_ronin || num28 > this.ftoken_snowtrace) && this.api_bot != "" && this.Chat_id != "")
					{
						string apilToken = this.api_bot;
						string chat_id = this.Chat_id;
						string[] array = new string[<Module>.埃波大波留()];
						array[<Module>.大豆斯艾埃()] = <Module>.ZExtO("紻紼娳娳娳絴絷絺絷絸絵絳紖絷絺絳絤絢娳娳娳紻紼絥絓絓絒紌紖", <Module>.斯埃艾留克());
						array[<Module>.儿儿艾大豆()] = text2;
						array[<Module>.留埃儿埃儿()] = <Module>.ZExtO("힕힒ퟙ퟼퟼ퟪ퟽ퟫퟫ힢ힸ", <Module>.克豆儿斯大());
						array[<Module>.留斯克波斯()] = text;
						array[<Module>.波波波斯波()] = <Module>.ZExtO("᷺᷽엍셀엍셀엍셀ᶲᶑᶜᶑᶞᶓᶕ엍셀엍셀엍셀᷺᷺᷽᷽᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍᷍", <Module>.留大儿波波());
						array[<Module>.豆留留克豆()] = string.Join(<Module>.ZExtO("", <Module>.克艾波波豆()), list);
						array[<Module>.豆儿大儿儿()] = <Module>.ZExtO("돱돶돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁돁", <Module>.波大豆大艾());
						this.TelegramSendMessage(apilToken, chat_id, string.Concat(array));
						list.Clear();
					}
					if (this.label7.InvokeRequired)
					{
						Control control = this.label7;
						MethodInvoker method;
						if ((method = <>9__2) == null)
						{
							method = (<>9__2 = delegate()
							{
								this.label7.Text = <Module>.ZExtO("⦄⦯⦢⦤⦬⦢⦣⧧⦆⦣⦣⦵⦢⦴⦴⦢⦴⧽⧧", <Module>.埃留波儿留()) + i.ToString();
							});
						}
						control.Invoke(method);
					}
					else
					{
						this.label7.Text = <Module>.ZExtO("", <Module>.豆豆留儿波()) + i.ToString();
					}
					if (this.label8.InvokeRequired)
					{
						Control control2 = this.label8;
						MethodInvoker method2;
						if ((method2 = <>9__3) == null)
						{
							method2 = (<>9__3 = delegate()
							{
								this.label8.Text = <Module>.ZExtO("\uddaf\udd94\udd8f\udd9a\udd97\udddb\udd8f\udd94\udd90\udd9e\udd95\udddb\udd88\udd8e\udd8b\udd8b\udd97\udd82\uddc1\udddb", <Module>.豆留波埃留()) + all_token_balance.ToString() + <Module>.ZExtO("埐埔", <Module>.埃波留波豆());
							});
						}
						control2.Invoke(method2);
					}
					else
					{
						this.label8.Text = <Module>.ZExtO("扁扺扡扴批戵扡扺找扰扻戵扦扠扥扥批扬戯戵", <Module>.留斯大留埃()) + all_token_balance.ToString() + <Module>.ZExtO("➉➍", <Module>.克波大儿波());
					}
					DataGridView obj = this.dataGridView1;
					bool flag = <Module>.艾留留斯斯() != 0;
					try
					{
						Monitor.Enter(obj, ref flag);
						this.GridChoice(this.adr_seed);
					}
					finally
					{
						if (flag)
						{
							Monitor.Exit(obj);
						}
					}
				}
				this.time.Start();
			}
			catch (Exception ex)
			{
				if (this.time != null)
				{
					this.time.Stop();
				}
				this.simpleButton1.Enabled = (<Module>.留留大波大() != 0);
				this.simpleButton2.Enabled = (<Module>.埃留波留波() != 0);
				this.simpleButton3.Enabled = (<Module>.艾波波波波() != 0);
				MessageBox.Show(ex.Message + ex.InnerException);
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0000FFB0 File Offset: 0x0000E1B0
		public string useCorrectSeparator(string str = "")
		{
			return str.Replace(<Module>.ZExtO("炾", <Module>.埃儿波波克()), CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(<Module>.ZExtO("篋", <Module>.留斯豆儿留()), CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000020D2 File Offset: 0x000002D2
		public static bool AcceptAllCertificatePolicy(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return <Module>.留波儿留埃() != 0;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x000020D9 File Offset: 0x000002D9
		public string RegexParse(string source, string left, string right)
		{
			return Regex.Match(source, left + <Module>.ZExtO("癇癁癅癐癆", <Module>.豆留儿埃儿()) + right).Groups[<Module>.克艾埃波大()].Value;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00002114 File Offset: 0x00000314
		public string RegexParseAxie(string source, string left, string right)
		{
			return Regex.Match(source, left + <Module>.ZExtO("䇘䇞䇚䇏䇙", <Module>.波留留埃留()) + right, (RegexOptions)<Module>.儿埃留斯波()).Groups[<Module>.豆儿儿克大()].Value;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00002154 File Offset: 0x00000354
		public string RegexParseSnow(string source, string left, string right)
		{
			return Regex.Match(source, left + <Module>.ZExtO("㌙㌟㌛㌎㌘", <Module>.艾留艾豆波()) + right, (RegexOptions)<Module>.儿波留波留()).Groups[<Module>.波儿大埃大()].Value;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00002194 File Offset: 0x00000394
		private void cAddress_EditValueChanged(object sender, EventArgs e)
		{
			if (this.cAddress.Value <= 0m)
			{
				this.cAddress.Value = 1m;
			}
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000021C6 File Offset: 0x000003C6
		private void timeInterval_EditValueChanged(object sender, EventArgs e)
		{
			if (this.timeInterval.Value < new decimal(<Module>.波儿波留波()))
			{
				this.timeInterval.Value = new decimal(<Module>.大波留斯克());
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00010008 File Offset: 0x0000E208
		public static byte[] HexStringToBytes(string source, bool testingForValidHex = false)
		{
			List<byte> list = new List<byte>();
			bool flag = <Module>.留豆波克克() != 0;
			byte b = (byte)<Module>.斯克艾波克();
			char[] array = source.ToCharArray();
			for (int i = <Module>.斯豆埃艾儿(); i < array.Length; i += <Module>.克留艾大波())
			{
				char c = array[i];
				if ((int)c == <Module>.艾儿波艾波() || (int)c == <Module>.埃波波豆大() || (int)c == <Module>.斯斯斯波豆())
				{
					if (flag)
					{
						list.Add(b);
						b = (byte)<Module>.斯埃波留大();
						flag = (<Module>.儿波儿大斯() != 0);
					}
				}
				else if (((int)c >= <Module>.儿克留豆埃() && (int)c <= <Module>.波儿留留克()) || ((int)c >= <Module>.儿豆斯留克() && (int)c <= <Module>.波留留留留()) || ((int)c >= <Module>.埃留斯波留() && (int)c <= <Module>.斯艾斯大豆()))
				{
					byte b2 = (byte)((int)c - <Module>.斯埃克波埃());
					if ((int)c >= <Module>.留斯波留豆() && (int)c <= <Module>.艾波波斯大())
					{
						b2 = (byte)((int)c + <Module>.大波留波艾() - <Module>.克豆波波克());
					}
					if ((int)c >= <Module>.波豆波克留() && (int)c <= <Module>.波留留留豆())
					{
						b2 = (byte)((int)c + <Module>.艾留留波斯() - <Module>.留克艾留大());
					}
					if (!flag)
					{
						flag = (<Module>.儿波豆波艾() != 0);
						b = b2;
					}
					else
					{
						b = (byte)(b << <Module>.波波波波波());
						b += b2;
						list.Add(b);
						b = (byte)<Module>.大斯儿斯大();
						flag = (<Module>.豆留大埃克() != 0);
					}
				}
				else if (testingForValidHex)
				{
					return null;
				}
			}
			if (flag)
			{
				list.Add(b);
			}
			return list.ToArray();
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0001021C File Offset: 0x0000E41C
		private void SeedCheck()
		{
			this.adr_seed = new DataTable();
			this.adr_seed.Columns.Add(<Module>.ZExtO("䐮䐋䐋䐝䐊䐜䐜", <Module>.波豆留留埃()));
			this.adr_seed.Columns.Add(<Module>.ZExtO("煥煓煓煒", <Module>.埃波留克留()));
			this.adr_seed.Columns.Add(<Module>.ZExtO("䣈䣥䣥䣦", <Module>.波豆大艾波()), typeof(bool));
			this.adr_seed.Columns[<Module>.ZExtO("孬孁孁孂", <Module>.埃埃波埃艾())].ColumnMapping = (MappingType)<Module>.大克艾克斯();
			if (this.mnemonics.Count != 0)
			{
				try
				{
					this.api_bot = this.apib.Text;
					this.Chat_id = this.chatid.Text;
					if (this.btcf.Text != "" && this.ltcf.Text != "" && this.bchf.Text != "" && this.dashf.Text != "" && this.ethf.Text != "" && this.bscf.Text != "" && this.ftmf.Text != "" && this.hecof.Text != "" && this.maticf.Text != "" && this.optimisticf.Text != "" && this.arbitrumf.Text != "" && this.moonf.Text != "" && this.snowf.Text != "" && this.roninf.Text != "" && this.axief.Text != "" && this.ercf.Text != "" && this.bepf.Text != "" && this.fttf.Text != "" && this.hectf.Text != "" && this.polytf.Text != "" && this.opttf.Text != "" && this.arbtf.Text != "" && this.moontf.Text != "" && this.snowtf.Text != "" && this.ronintf.Text != "")
					{
						this.fbalance_btc = Convert.ToDecimal(this.btcf.Text);
						this.fbalance_ltc = Convert.ToDecimal(this.ltcf.Text);
						this.fbalance_bch = Convert.ToDecimal(this.bchf.Text);
						this.fbalance_dash = Convert.ToDecimal(this.dashf.Text);
						this.fbalance_eth = Convert.ToDecimal(this.ethf.Text);
						this.fbalance_bsc = Convert.ToDecimal(this.bscf.Text);
						this.fbalance_ftm = Convert.ToDecimal(this.ftmf.Text);
						this.fbalance_ht = Convert.ToDecimal(this.hecof.Text);
						this.fbalance_matic = Convert.ToDecimal(this.maticf.Text);
						this.fbalance_oteth = Convert.ToDecimal(this.optimisticf.Text);
						this.fbalance_arbiscan = Convert.ToDecimal(this.arbitrumf.Text);
						this.fbalance_moonriver = Convert.ToDecimal(this.moonf.Text);
						this.fbalance_snowtrace = Convert.ToDecimal(this.snowf.Text);
						this.fbalance_ronin = Convert.ToDecimal(this.roninf.Text);
						this.fbalance_axie = Convert.ToDecimal(this.axief.Text);
						this.ftoken_erc = Convert.ToDecimal(this.ercf.Text);
						this.ftoken_bsc = Convert.ToDecimal(this.bepf.Text);
						this.ftoken_ftm = Convert.ToDecimal(this.fttf.Text);
						this.ftoken_ht = Convert.ToDecimal(this.hectf.Text);
						this.ftoken_polygon = Convert.ToDecimal(this.polytf.Text);
						this.ftoken_oteth = Convert.ToDecimal(this.opttf.Text);
						this.ftoken_arbiscan = Convert.ToDecimal(this.arbtf.Text);
						this.ftoken_moonriver = Convert.ToDecimal(this.moontf.Text);
						this.ftoken_snowtrace = Convert.ToDecimal(this.snowtf.Text);
						this.ftoken_ronin = Convert.ToDecimal(this.ronintf.Text);
						this.simpleButton1.Enabled = (<Module>.埃波留波斯() != 0);
						this.simpleButton2.Enabled = (<Module>.波留儿儿克() != 0);
						this.simpleButton3.Enabled = (<Module>.波大豆波波() != 0);
						this.privkeyedit.Enabled = (<Module>.豆大艾波留() != 0);
					}
					else
					{
						MessageBox.Show(<Module>.ZExtO("", <Module>.豆克波艾克()));
					}
				}
				catch
				{
					MessageBox.Show(<Module>.ZExtO("ꈐꈻꈶꈰꈸꉳꈰꈡꈶꈷꈶꈽꈧꈺꈲꈿꈠꉳꈵꈺꈿꈧꈶꈡꈠꉲꉲꉲ", <Module>.克克留儿波()));
				}
				Litecoin.Instance.EnsureRegistered();
				Dash.Instance.EnsureRegistered();
				BCash.Instance.EnsureRegistered();
				try
				{
					new Thread(delegate()
					{
						Task.Run(delegate()
						{
							Parallel.ForEach<string>(this.mnemonics, delegate(string mnem)
							{
								Mnemonic mnemonic = new Mnemonic(<Module>.ZExtO("籽籨籨簧籽籨籨簧籽籨籨簧籽籨籨簧籽籨籨簧籽籨籨簧籽籨籨簧籽籨籨簧籽籨籨簧籽籨籨簧籽籨籨簧籽籨籨", <Module>.斯波儿斯留()), Wordlist.English);
								if (mnem != null && mnem.Trim() != "")
								{
									string mnem2 = mnem;
									char[] array = new char[<Module>.埃埃克艾克()];
									array[<Module>.斯儿儿豆大()] = (char)<Module>.大波儿斯豆();
									if (mnem2.Split(array).Count<string>() <= <Module>.斯大斯波儿())
									{
										try
										{
											mnemonic = new Mnemonic(mnem, Wordlist.AutoDetect(mnem));
										}
										catch
										{
											this.bad_mnem += <Module>.波埃斯豆豆();
											if (this.label5.InvokeRequired)
											{
												this.label5.Invoke(new MethodInvoker(delegate()
												{
													this.label5.Text = <Module>.ZExtO("ᏣᏀᏅᎁᏒᏄᏄᏅ᎛ᎁ", <Module>.留埃波斯斯()) + this.bad_mnem.ToString();
												}));
											}
											else
											{
												this.label5.Text = <Module>.ZExtO("數敛敞攚敉敟敟敞攀攚", <Module>.埃斯克埃留()) + this.bad_mnem.ToString();
											}
											Task.Run(delegate()
											{
												File.AppendAllText(<Module>.ZExtO("ﱏﱬﱩﰭﱾﱨﱨﱩﰣﱹﱵﱹ", <Module>.艾儿波克艾()), mnem + <Module>.ZExtO("찮착", <Module>.波豆波克艾()));
											});
										}
										if (mnemonic.IsValidChecksum)
										{
											int num = <Module>.克斯斯豆儿();
											while (num < this.cAddress.Value)
											{
												if (this.btc)
												{
													string text = mnemonic.DeriveExtKey(null).Derive(new NBitcoin.KeyPath(string.Format(<Module>.ZExtO("渼湾湥湥湶湾湡湶湾湡湶湾湡湾渪湡測", <Module>.大克留豆留()), num))).GetPublicKey().GetAddress((ScriptPubKeyType)<Module>.波留斯留斯(), Network.Main).ToString();
													string text2 = mnemonic.DeriveExtKey(null).Derive(new NBitcoin.KeyPath(string.Format(<Module>.ZExtO("䉻䈹䈢䈯䈱䈹䈦䈱䈹䈦䈱䈹䈦䈹䉭䈦䉫", <Module>.留艾波留波()), num))).GetPublicKey().GetAddress((ScriptPubKeyType)<Module>.豆斯斯留克(), Network.Main).ToString();
													string text3 = mnemonic.DeriveExtKey(null).Derive(new NBitcoin.KeyPath(string.Format(<Module>.ZExtO("囗嚕嚂嚎嚝嚕嚊嚝嚕嚊嚝嚕嚊嚕囁嚊囇", <Module>.豆留斯儿克()), num))).GetPublicKey().GetAddress((ScriptPubKeyType)<Module>.埃留儿克克(), Network.Main).ToString();
													DataTable obj = this.adr_seed;
													bool flag = <Module>.埃斯波留儿() != 0;
													try
													{
														Monitor.Enter(obj, ref flag);
														DataRowCollection rows = this.adr_seed.Rows;
														object[] array2 = new object[<Module>.埃波斯豆豆()];
														array2[<Module>.豆波波儿波()] = text;
														array2[<Module>.波波斯斯豆()] = mnemonic;
														array2[<Module>.豆豆儿留儿()] = (<Module>.留豆留波留() != 0);
														rows.Add(array2);
														DataRowCollection rows2 = this.adr_seed.Rows;
														object[] array3 = new object[<Module>.斯波克儿斯()];
														array3[<Module>.斯留留斯儿()] = text2;
														array3[<Module>.克豆大艾克()] = mnemonic;
														array3[<Module>.斯波艾斯波()] = (<Module>.斯斯留克斯() != 0);
														rows2.Add(array3);
														DataRowCollection rows3 = this.adr_seed.Rows;
														object[] array4 = new object[<Module>.克艾留留克()];
														array4[<Module>.克留留波波()] = text3;
														array4[<Module>.克艾波波克()] = mnemonic;
														array4[<Module>.留留埃艾波()] = (<Module>.豆艾克儿留() != 0);
														rows3.Add(array4);
													}
													finally
													{
														if (flag)
														{
															Monitor.Exit(obj);
														}
													}
												}
												if (this.ltc)
												{
													string text4 = mnemonic.DeriveExtKey(null).Derive(new NBitcoin.KeyPath(string.Format(<Module>.ZExtO("곮견겷겷겤견겱겤견겳겤견겳견곸겳곾", <Module>.埃波艾豆斯()), num))).GetPublicKey().GetAddress((ScriptPubKeyType)<Module>.豆大埃波埃(), Network.GetNetwork(<Module>.ZExtO("䡽䡥䡲䠼䡼䡰䡸䡿", <Module>.儿埃埃克留()))).ToString();
													string text5 = mnemonic.DeriveExtKey(null).Derive(new NBitcoin.KeyPath(string.Format(<Module>.ZExtO("࢙ࣛࣀ࣓࣍ࣛࣆ࣓ࣛࣄ࣓ࣛࣄࣛ࢏ࣄࢉ", <Module>.斯留豆波埃()), num))).GetPublicKey().GetAddress((ScriptPubKeyType)<Module>.儿儿克埃大(), Network.GetNetwork(<Module>.ZExtO("ⓢ⓺⓭⒣ⓣ⓯ⓧⓠ", <Module>.波斯豆大斯()))).ToString();
													string text6 = mnemonic.DeriveExtKey(null).Derive(new NBitcoin.KeyPath(string.Format(<Module>.ZExtO("ꪁ꫃꫔꫘꫋꫃꫞꫋꫃ꫜ꫋꫃ꫜ꫃ꪗꫜꪑ", <Module>.留留斯波埃()), num))).GetPublicKey().GetAddress((ScriptPubKeyType)<Module>.波斯留斯留(), Network.GetNetwork(<Module>.ZExtO("矐矈矟瞑矑矝矕矒", <Module>.留艾大波留()))).ToString();
													DataTable obj = this.adr_seed;
													bool flag = <Module>.留留留埃留() != 0;
													try
													{
														Monitor.Enter(obj, ref flag);
														DataRowCollection rows4 = this.adr_seed.Rows;
														object[] array5 = new object[<Module>.波儿大儿波()];
														array5[<Module>.大斯艾儿留()] = text4;
														array5[<Module>.儿波儿克艾()] = mnemonic;
														array5[<Module>.斯留儿埃波()] = (<Module>.豆埃儿豆克() != 0);
														rows4.Add(array5);
														DataRowCollection rows5 = this.adr_seed.Rows;
														object[] array6 = new object[<Module>.克波波艾留()];
														array6[<Module>.艾波留波留()] = text5;
														array6[<Module>.波克留艾波()] = mnemonic;
														array6[<Module>.留儿波波斯()] = (<Module>.波留斯波斯() != 0);
														rows5.Add(array6);
														DataRowCollection rows6 = this.adr_seed.Rows;
														object[] array7 = new object[<Module>.艾克留斯留()];
														array7[<Module>.波豆大留儿()] = text6;
														array7[<Module>.豆留豆留斯()] = mnemonic;
														array7[<Module>.斯留留大波()] = (<Module>.埃大埃大斯() != 0);
														rows6.Add(array7);
													}
													finally
													{
														if (flag)
														{
															Monitor.Exit(obj);
														}
													}
												}
												if (this.dash)
												{
													string text7 = mnemonic.DeriveExtKey(null).Derive(new NBitcoin.KeyPath(string.Format(<Module>.ZExtO("⁀\u2002’’\u200a\u2002‘\u200a\u2002”\u200a\u2002”\u2002⁖”⁐", <Module>.大大大波儿()), num))).GetPublicKey().GetAddress((ScriptPubKeyType)<Module>.斯斯豆大斯(), Network.GetNetwork(<Module>.ZExtO("贺贿购贶赳贳贿贷贰", <Module>.波艾艾斯波()))).ToString();
													DataTable obj = this.adr_seed;
													bool flag = <Module>.波留埃留波() != 0;
													try
													{
														Monitor.Enter(obj, ref flag);
														DataRowCollection rows7 = this.adr_seed.Rows;
														object[] array8 = new object[<Module>.埃波留克豆()];
														array8[<Module>.豆豆留埃斯()] = text7;
														array8[<Module>.大埃留埃斯()] = mnemonic;
														array8[<Module>.埃儿艾波波()] = (<Module>.波留艾儿留() != 0);
														rows7.Add(array8);
													}
													finally
													{
														if (flag)
														{
															Monitor.Exit(obj);
														}
													}
												}
												if (this.bch)
												{
													string text8 = mnemonic.DeriveExtKey(null).Derive(new NBitcoin.KeyPath(string.Format(<Module>.ZExtO("銦鋤鋿鋿鋬鋤鋺鋿鋾鋬鋤鋻鋬鋤鋻鋤銰鋻銶", <Module>.儿留艾留豆()), num))).GetPublicKey().GetAddress((ScriptPubKeyType)<Module>.斯大斯留克(), Network.GetNetwork(<Module>.ZExtO("ᱍ᱌᱇ᰂ᱂ᱎ᱆᱁", <Module>.艾波斯留波()))).ToString().Replace(<Module>.ZExtO("", <Module>.大大豆克留()), "");
													DataTable obj = this.adr_seed;
													bool flag = <Module>.大埃艾埃波() != 0;
													try
													{
														Monitor.Enter(obj, ref flag);
														DataRowCollection rows8 = this.adr_seed.Rows;
														object[] array9 = new object[<Module>.克斯斯波豆()];
														array9[<Module>.留克斯斯斯()] = text8;
														array9[<Module>.埃大豆埃豆()] = mnemonic;
														array9[<Module>.豆留豆留儿()] = (<Module>.儿波儿埃克() != 0);
														rows8.Add(array9);
													}
													finally
													{
														if (flag)
														{
															Monitor.Exit(obj);
														}
													}
												}
												if (this.eth || this.bsc || this.ftm || this.polygon || this.movr || this.ronint || this.snowtrace || this.arbitrum || this.ht || this.optimeth)
												{
													string address = new Account(mnemonic.DeriveExtKey(null).Derive(new NBitcoin.KeyPath(string.Format(<Module>.ZExtO("⪱⫳⫨⫨⫻⫳⫪⫬⫻⫳⫬⫻⫳⫬⫳⪧⫬⪡", <Module>.波艾留波留()), num))).PrivateKey.ToHex(), (Chain)<Module>.儿大艾留留()).Address;
													DataTable obj = this.adr_seed;
													bool flag = <Module>.豆克波留儿() != 0;
													try
													{
														Monitor.Enter(obj, ref flag);
														DataRowCollection rows9 = this.adr_seed.Rows;
														object[] array10 = new object[<Module>.波斯豆儿儿()];
														array10[<Module>.豆大豆克留()] = address;
														array10[<Module>.留埃儿大波()] = mnemonic;
														array10[<Module>.儿留克大艾()] = (<Module>.留儿波波留() != 0);
														rows9.Add(array10);
													}
													finally
													{
														if (flag)
														{
															Monitor.Exit(obj);
														}
													}
												}
												num += <Module>.波儿留克埃();
											}
										}
									}
								}
							});
							this.time = new System.Timers.Timer(1000.0);
							this.time.Start();
							this.time.Elapsed += this.CheckBalanceTimer;
						}).Wait();
					}).Start();
					return;
				}
				catch (Exception ex)
				{
					if (this.time != null)
					{
						this.time.Stop();
					}
					this.simpleButton1.Enabled = (<Module>.斯波大斯豆() != 0);
					this.simpleButton2.Enabled = (<Module>.斯留克豆波() != 0);
					this.simpleButton3.Enabled = (<Module>.留大艾波豆() != 0);
					MessageBox.Show(ex.Message);
					return;
				}
			}
			MessageBox.Show(<Module>.ZExtO("ᡚ᡹ᡷᡲᠶᡥᡳᡳᡲᠷᠷᠷ", <Module>.波埃埃大儿()));
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00010A18 File Offset: 0x0000EC18
		private void OnDataGridViewSortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			string strA = (e.CellValue1 != null) ? e.CellValue1.ToString() : string.Empty;
			string strB = (e.CellValue2 != null) ? e.CellValue2.ToString() : string.Empty;
			e.SortResult = string.Compare(strA, strB);
			e.Handled = (<Module>.豆艾留斯斯() != 0);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00010AA0 File Offset: 0x0000ECA0
		private void PrivkeyCheck()
		{
			this.adr_seed = new DataTable();
			this.adr_seed.Columns.Add(<Module>.ZExtO("먇먢먢먴먣먵먵", <Module>.留埃留儿埃()));
			this.adr_seed.Columns.Add(<Module>.ZExtO("算箵箮箱箌箢箾", <Module>.艾波豆大留()));
			this.adr_seed.Columns.Add(<Module>.ZExtO("ꃟꃲꃲꃱ", <Module>.埃豆儿波留()), typeof(bool));
			this.adr_seed.Columns[<Module>.ZExtO("଀ଭଭମ", <Module>.埃克儿豆波())].ColumnMapping = (MappingType)<Module>.儿艾大艾大();
			if (this.mnemonics.Count != 0)
			{
				try
				{
					this.api_bot = this.apib.Text;
					this.Chat_id = this.chatid.Text;
					if (this.btcf.Text != "" && this.ltcf.Text != "" && this.bchf.Text != "" && this.dashf.Text != "" && this.ethf.Text != "" && this.bscf.Text != "" && this.ftmf.Text != "" && this.hecof.Text != "" && this.maticf.Text != "" && this.optimisticf.Text != "" && this.arbitrumf.Text != "" && this.moonf.Text != "" && this.snowf.Text != "" && this.roninf.Text != "" && this.axief.Text != "" && this.ercf.Text != "" && this.bepf.Text != "" && this.fttf.Text != "" && this.hectf.Text != "" && this.polytf.Text != "" && this.opttf.Text != "" && this.arbtf.Text != "" && this.moontf.Text != "" && this.snowtf.Text != "" && this.ronintf.Text != "")
					{
						this.fbalance_btc = Convert.ToDecimal(this.btcf.Text);
						this.fbalance_ltc = Convert.ToDecimal(this.ltcf.Text);
						this.fbalance_bch = Convert.ToDecimal(this.bchf.Text);
						this.fbalance_dash = Convert.ToDecimal(this.dashf.Text);
						this.fbalance_eth = Convert.ToDecimal(this.ethf.Text);
						this.fbalance_bsc = Convert.ToDecimal(this.bscf.Text);
						this.fbalance_ftm = Convert.ToDecimal(this.ftmf.Text);
						this.fbalance_ht = Convert.ToDecimal(this.hecof.Text);
						this.fbalance_matic = Convert.ToDecimal(this.maticf.Text);
						this.fbalance_oteth = Convert.ToDecimal(this.optimisticf.Text);
						this.fbalance_arbiscan = Convert.ToDecimal(this.arbitrumf.Text);
						this.fbalance_moonriver = Convert.ToDecimal(this.moonf.Text);
						this.fbalance_snowtrace = Convert.ToDecimal(this.snowf.Text);
						this.fbalance_ronin = Convert.ToDecimal(this.roninf.Text);
						this.fbalance_axie = Convert.ToDecimal(this.axief.Text);
						this.ftoken_erc = Convert.ToDecimal(this.ercf.Text);
						this.ftoken_bsc = Convert.ToDecimal(this.bepf.Text);
						this.ftoken_ftm = Convert.ToDecimal(this.fttf.Text);
						this.ftoken_ht = Convert.ToDecimal(this.hectf.Text);
						this.ftoken_polygon = Convert.ToDecimal(this.polytf.Text);
						this.ftoken_oteth = Convert.ToDecimal(this.opttf.Text);
						this.ftoken_arbiscan = Convert.ToDecimal(this.arbtf.Text);
						this.ftoken_moonriver = Convert.ToDecimal(this.moontf.Text);
						this.ftoken_snowtrace = Convert.ToDecimal(this.snowtf.Text);
						this.ftoken_ronin = Convert.ToDecimal(this.ronintf.Text);
						this.simpleButton1.Enabled = (<Module>.埃克克豆波() != 0);
						this.simpleButton2.Enabled = (<Module>.儿艾埃豆埃() != 0);
						this.simpleButton3.Enabled = (<Module>.斯豆留留斯() != 0);
						this.privkeyedit.Enabled = (<Module>.克大大留豆() != 0);
					}
					else
					{
						MessageBox.Show(<Module>.ZExtO("", <Module>.波波斯留儿()));
					}
				}
				catch
				{
					MessageBox.Show(<Module>.ZExtO("", <Module>.波豆留留艾()));
				}
				Litecoin.Instance.EnsureRegistered();
				Dash.Instance.EnsureRegistered();
				BCash.Instance.EnsureRegistered();
				try
				{
					new Thread(delegate()
					{
						Task.Run(delegate()
						{
							Parallel.ForEach<string>(this.mnemonics, delegate(string mnem)
							{
								try
								{
									if (mnem.Trim() != "" && (mnem.Length == <Module>.波留埃大斯() || (mnem.StartsWith(<Module>.ZExtO("", <Module>.克艾大留埃())) && mnem.Length == <Module>.艾儿斯波克())))
									{
										byte[] data = Form1.HexStringToBytes(mnem.Replace(<Module>.ZExtO("옡왩", <Module>.波豆留豆波()), ""), <Module>.波波斯克豆() != 0);
										Key key = new Key(data, <Module>.斯留波克埃(), <Module>.波艾留克大() != 0);
										Key key2 = new Key(data, <Module>.斯留留埃留(), <Module>.斯大留儿留() != 0);
										DataTable obj;
										bool flag;
										if (this.btc)
										{
											if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("焢焼焳焾焐焌", <Module>.埃留儿豆艾())))
											{
												this.adr_seed.Columns.Add(<Module>.ZExtO("챧챹챶챻챕챉", <Module>.豆艾留波波()));
											}
											string text = key.PubKey.GetAddress((ScriptPubKeyType)<Module>.艾斯豆波豆(), Network.Main).ToString();
											BitcoinSecret wif = key.GetWif(Network.Main);
											string text2 = key2.PubKey.GetAddress((ScriptPubKeyType)<Module>.斯留克留儿(), Network.Main).ToString();
											BitcoinSecret wif2 = key2.GetWif(Network.Main);
											string text3 = key.PubKey.GetAddress((ScriptPubKeyType)<Module>.埃斯克波豆(), Network.Main).ToString();
											string text4 = key.PubKey.GetAddress((ScriptPubKeyType)<Module>.豆埃波留留(), Network.Main).ToString();
											obj = this.adr_seed;
											flag = (<Module>.留斯留斯留() != 0);
											try
											{
												Monitor.Enter(obj, ref flag);
												DataRowCollection rows = this.adr_seed.Rows;
												object[] array = new object[<Module>.波克留留埃()];
												array[<Module>.波克埃儿儿()] = text;
												array[<Module>.豆留波克斯()] = mnem;
												array[<Module>.波克儿埃留()] = (<Module>.留大大埃艾() != 0);
												array[<Module>.留克豆豆豆()] = wif;
												rows.Add(array);
												DataRowCollection rows2 = this.adr_seed.Rows;
												object[] array2 = new object[<Module>.大波儿留斯()];
												array2[<Module>.埃豆艾波留()] = text2;
												array2[<Module>.留克波波埃()] = mnem;
												array2[<Module>.波艾大大埃()] = (<Module>.大艾波大豆() != 0);
												array2[<Module>.波留留豆斯()] = wif2;
												rows2.Add(array2);
												DataRowCollection rows3 = this.adr_seed.Rows;
												object[] array3 = new object[<Module>.艾斯克波大()];
												array3[<Module>.斯波豆豆克()] = text3;
												array3[<Module>.波留留斯埃()] = mnem;
												array3[<Module>.儿豆留埃斯()] = (<Module>.斯留艾留儿() != 0);
												array3[<Module>.波大波艾波()] = wif;
												rows3.Add(array3);
												DataRowCollection rows4 = this.adr_seed.Rows;
												object[] array4 = new object[<Module>.斯克儿艾斯()];
												array4[<Module>.儿埃儿波波()] = text4;
												array4[<Module>.艾儿波克艾()] = mnem;
												array4[<Module>.波波斯大大()] = (<Module>.留大留波豆() != 0);
												array4[<Module>.波艾斯克艾()] = wif;
												rows4.Add(array4);
											}
											finally
											{
												if (flag)
												{
													Monitor.Exit(obj);
												}
											}
										}
										if (this.ltc)
										{
											if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("榴榪榥榨榆榚", <Module>.留波波克豆())))
											{
												this.adr_seed.Columns.Add(<Module>.ZExtO("ᮟᮁᮎᮃᮭ᮱", <Module>.大波斯埃波()));
											}
											string text5 = key.PubKey.GetAddress((ScriptPubKeyType)<Module>.艾大克斯艾(), Network.GetNetwork(<Module>.ZExtO("䀃䀛䀌䁂䀂䀎䀆䀁", <Module>.留留留斯留()))).ToString();
											string text6 = key.PubKey.GetAddress((ScriptPubKeyType)<Module>.豆克埃大大(), Network.GetNetwork(<Module>.ZExtO("跒跊距趓跓跟跗跐", <Module>.留大豆儿留()))).ToString();
											string text7 = key.PubKey.GetAddress((ScriptPubKeyType)<Module>.埃波艾波豆(), Network.GetNetwork(<Module>.ZExtO("៊្ៅឋ់ះ៏ៈ", <Module>.克大斯斯大()))).ToString();
											BitcoinSecret wif3 = key.GetWif(Network.GetNetwork(<Module>.ZExtO("ŞņőğşœśŜ", <Module>.豆留克豆儿())));
											obj = this.adr_seed;
											flag = (<Module>.克克艾克波() != 0);
											try
											{
												Monitor.Enter(obj, ref flag);
												DataRowCollection rows5 = this.adr_seed.Rows;
												object[] array5 = new object[<Module>.斯克埃斯艾()];
												array5[<Module>.儿波克波埃()] = text5;
												array5[<Module>.豆留留艾大()] = mnem;
												array5[<Module>.留波波斯波()] = (<Module>.斯斯斯留留() != 0);
												array5[<Module>.留豆克艾克()] = wif3;
												rows5.Add(array5);
												DataRowCollection rows6 = this.adr_seed.Rows;
												object[] array6 = new object[<Module>.儿儿波大斯()];
												array6[<Module>.豆波大克斯()] = text6;
												array6[<Module>.波斯留斯波()] = mnem;
												array6[<Module>.克豆艾艾留()] = (<Module>.波波波波斯() != 0);
												array6[<Module>.埃留克波克()] = wif3;
												rows6.Add(array6);
												DataRowCollection rows7 = this.adr_seed.Rows;
												object[] array7 = new object[<Module>.儿大留艾大()];
												array7[<Module>.斯埃斯大波()] = text7;
												array7[<Module>.埃波斯埃艾()] = mnem;
												array7[<Module>.豆波埃留儿()] = (<Module>.留波留波儿() != 0);
												array7[<Module>.豆大埃埃斯()] = wif3;
												rows7.Add(array7);
											}
											finally
											{
												if (flag)
												{
													Monitor.Exit(obj);
												}
											}
										}
										if (this.dash)
										{
											if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("괯괱괾괳괝괁", <Module>.埃艾豆豆留())))
											{
												this.adr_seed.Columns.Add(<Module>.ZExtO("☘☆☉☄☪☶", <Module>.留波留留克()));
											}
											string text8 = key.PubKey.GetAddress((ScriptPubKeyType)<Module>.克波斯克波(), Network.GetNetwork(<Module>.ZExtO("䂖䂓䂁䂚䃟䂟䂓䂛䂜", <Module>.埃留大克斯()))).ToString();
											BitcoinSecret wif4 = key.GetWif(Network.GetNetwork(<Module>.ZExtO("㩵㩰㩢㩹㨼㩼㩰㩸㩿", <Module>.斯留儿儿儿())));
											obj = this.adr_seed;
											flag = (<Module>.大波儿留波() != 0);
											try
											{
												Monitor.Enter(obj, ref flag);
												DataRowCollection rows8 = this.adr_seed.Rows;
												object[] array8 = new object[<Module>.留豆克克波()];
												array8[<Module>.留留大留克()] = text8;
												array8[<Module>.克豆克大留()] = mnem;
												array8[<Module>.儿克大埃儿()] = (<Module>.波豆留留豆() != 0);
												array8[<Module>.克留斯斯克()] = wif4;
												rows8.Add(array8);
											}
											finally
											{
												if (flag)
												{
													Monitor.Exit(obj);
												}
											}
										}
										if (this.bch)
										{
											if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("歬歲歽歰歞歂", <Module>.儿克豆留斯())))
											{
												this.adr_seed.Columns.Add(<Module>.ZExtO("煖煈煇煊煤煸", <Module>.斯艾克波大()));
											}
											string text9 = key.PubKey.GetAddress((ScriptPubKeyType)<Module>.留斯波埃埃(), Network.GetNetwork(<Module>.ZExtO("娱娰娻婾娾娲娺娽", <Module>.大儿波克豆()))).ToString().Replace(<Module>.ZExtO("뒐뒛뒆뒑뒝뒛뒜뒑뒓뒁뒚듈", <Module>.斯留艾斯豆()), "");
											BitcoinSecret wif5 = key.GetWif(Network.GetNetwork(<Module>.ZExtO("龟龞龕鿐龐龜龔龓", <Module>.豆克大克大())));
											obj = this.adr_seed;
											flag = (<Module>.艾大埃波波() != 0);
											try
											{
												Monitor.Enter(obj, ref flag);
												DataRowCollection rows9 = this.adr_seed.Rows;
												object[] array9 = new object[<Module>.埃豆儿埃大()];
												array9[<Module>.克豆艾儿斯()] = text9;
												array9[<Module>.斯斯留波儿()] = mnem;
												array9[<Module>.波留埃斯豆()] = (<Module>.斯留波留大() != 0);
												array9[<Module>.埃大埃留波()] = wif5;
												rows9.Add(array9);
											}
											finally
											{
												if (flag)
												{
													Monitor.Exit(obj);
												}
											}
										}
										if (!this.eth && !this.bsc && !this.ftm && !this.polygon && !this.movr && !this.ronint && !this.snowtrace && !this.arbitrum && !this.ht && !this.optimeth)
										{
											goto IL_9F5;
										}
										string address = new Account(mnem, (Chain)<Module>.斯克波艾豆()).Address;
										obj = this.adr_seed;
										flag = (<Module>.大埃波波留() != 0);
										try
										{
											Monitor.Enter(obj, ref flag);
											DataRowCollection rows10 = this.adr_seed.Rows;
											object[] array10 = new object[<Module>.斯留留豆波()];
											array10[<Module>.波斯留留留()] = address;
											array10[<Module>.克斯波波斯()] = mnem;
											array10[<Module>.艾斯斯儿大()] = (<Module>.留豆克豆豆() != 0);
											rows10.Add(array10);
											goto IL_9F5;
										}
										finally
										{
											if (flag)
											{
												Monitor.Exit(obj);
											}
										}
									}
									this.bad_mnem += <Module>.克波斯波大();
									if (this.label5.InvokeRequired)
									{
										this.label5.Invoke(new MethodInvoker(delegate()
										{
											this.label5.Text = <Module>.ZExtO("뭊뭩뭬묨뭸뭺뭡뭾뭩뭼뭭뭣뭭뭱묲묨", <Module>.埃大埃波波()) + this.bad_mnem.ToString();
										}));
									}
									else
									{
										this.label5.Text = <Module>.ZExtO("୰୓ୖ଒ୂୀ୛ୄ୓୆ୗ୙ୗୋଈ଒", <Module>.波埃大波波()) + this.bad_mnem.ToString();
									}
									Task.Run(delegate()
									{
										File.AppendAllText(<Module>.ZExtO("頱頒頗顓頣頁頚項頸頖頊顝頇頋頇", <Module>.克豆大留波()), mnem + <Module>.ZExtO("泮泩", <Module>.儿波儿埃豆()));
									});
									IL_9F5:;
								}
								catch
								{
									this.bad_mnem += <Module>.大艾波波艾();
									if (this.label5.InvokeRequired)
									{
										this.label5.Invoke(new MethodInvoker(delegate()
										{
											this.label5.Text = <Module>.ZExtO("⡦⡅⡀⠄⡔⡖⡍⡒⡅⡐⡁⡏⡁⡝⠞⠄", <Module>.克波儿留埃()) + this.bad_mnem.ToString();
										}));
									}
									else
									{
										this.label5.Text = <Module>.ZExtO("匊匩匬卨匸区匡匾匩匼匭匣匭匱卲卨", <Module>.波波艾艾艾()) + this.bad_mnem.ToString();
									}
									Task.Run(delegate()
									{
										File.AppendAllText(<Module>.ZExtO("힀힣힦ퟢ힒ힰ힫ힴ힉힧ힻퟬힶힺힶ", <Module>.留斯艾埃留()), mnem + <Module>.ZExtO("閒閕", <Module>.斯克波留波()));
									});
								}
							});
							this.time = new System.Timers.Timer(1000.0);
							this.time.Start();
							this.time.Elapsed += this.CheckBalanceTimerPriv;
						}).Wait();
					}).Start();
					return;
				}
				catch (Exception ex)
				{
					if (this.time != null)
					{
						this.time.Stop();
					}
					this.simpleButton1.Enabled = (<Module>.大儿斯大埃() != 0);
					this.simpleButton2.Enabled = (<Module>.波大埃留斯() != 0);
					this.simpleButton3.Enabled = (<Module>.留豆儿儿斯() != 0);
					MessageBox.Show(ex.Message);
					return;
				}
			}
			MessageBox.Show(<Module>.ZExtO("", <Module>.埃儿留儿斯()));
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0001129C File Offset: 0x0000F49C
		private void CheckBalanceTimerPriv(object sender, ElapsedEventArgs e)
		{
			try
			{
				this.time.Stop();
				this.time.Interval = (double)this.timeInterval.Value * 1000.0;
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("", <Module>.大斯波儿留())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("ᒐᒁᒝᓵᒗᒴᒹᒴᒻᒶᒰ", <Module>.艾豆斯大艾()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("", <Module>.波儿克波波())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("鮓鮄鮕鯻鮂鮹鮽鮳鮸鯶鯾鯲鯿", <Module>.留儿斯波留()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("ǆǊǆƤǆǥǨǥǪǧǡ", <Module>.留大留大波())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("タコタポタ゜ゑ゜んゞ゘", <Module>.留波留艾艾()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("躀躇躒軯躖躭躩躧躬転軪軦軫", <Module>.克埃克艾斯())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("㯋㯌㯙㮤㯝㯦㯢㯬㯧㮩㮡㮭㮠", <Module>.埃豆艾波留()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("좨좺좣죎좬좏좂좏좀좍좋", <Module>.波埃波斯波())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("췑췃췚춷췕췶췻췶췹췴췲", <Module>.波波斯豆波()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("ᢈᢚᢃᣣᢚᢡᢥ᢫ᢠᣮᣦᣪᣧ", <Module>.大波埃留波())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("", <Module>.埃波波斯儿()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("쫙쫅쪱쫓쫰쫽쫰쫿쫲쫴", <Module>.波波艾儿留())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("ꋬꋰꊄꋦꋅꋈꋅꋊꋇꋁ", <Module>.儿留留斯儿()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("代仿了仿仄什从仅事亃亏亂", <Module>.艾克留大波())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("륾륢뤛륢륙륝륓류뤖뤞뤒뤟", <Module>.波艾斯豆儿()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("杅杉杜杁杋木杊杩杤杩杦杫杭", <Module>.埃留艾留大())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("퇵퇹퇬퇱퇻톘퇺퇙퇔퇙퇖퇛퇝", <Module>.儿埃大斯克()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("ۏېۓۆۘېۑڲۋ۰۴ۺ۱ڿڷڻڶ", <Module>.斯留大埃儿())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("ﴻﴤﴧﴲﴬﴤﴥ﵆﴿ﴄﴀﴎﴅ﵋﵃﵏﵂", <Module>.埃波埃波儿()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("枤枛枟枂枆枂枘枟枂枈枮枿枣柋枩枊枇枊枅枈枎", <Module>.斯斯埃大斯())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("仐仯仫件仲件们仫件仼仚介仗亿仝仾仳仾仱仼仺", <Module>.斯豆波留艾()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("㞸㞇㞃㞞㞚㞞㞄㞃㞞㞔㞲㞣㞿㟚㞣㞘㞜㞒㞙㟗㟟㟓㟞", <Module>.留艾留艾艾())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("첖첩청첰체첰첪청첰첺천첍첑쳴첍첶첲첼첷쳹쳱쳽쳰", <Module>.斯留波波波()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("僅僒僅僜催僗僪僫僳僰僶僥僧僡傭傤僆僥僨僥僪僧僡", <Module>.儿斯大埃波())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("텀텗텀텙턩텒텯텮텶텵텳텠텢텤턨턡텃텠텭텠텯텢텤", <Module>.克波波儿大()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("풿풨풿풦퓖풭풐풑풉풊풌풟풝풛퓗퓓풪풑풕풛풐퓞퓖퓚퓗", <Module>.波留波斯波())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("쬟쬈쬟쬆쭶쬍쬰쬱쬩쬪쬬쬿쬽쬻쭷쭳쬊쬱쬵쬻쬰쭾쭶쭺쭷", <Module>.波留大艾埃()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("吸吺吣吧呕吷吔吙吔君吖吐", <Module>.波斯波艾儿())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("愾愼愥愡慓愱愒感愒愝愐愖", <Module>.儿豆波留波()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("獑獓獊獎猱獈獳獷獹獲猼猴猸猵", <Module>.克艾艾埃埃())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("肞肜肅肁胾肇肼肸肶肽胳胻胷胺", <Module>.埃豆埃留克()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("뻆뻵뻥뻮뻳뻵뻲뻪뺧뻅뻦뻫뻦뻩뻤뻢", <Module>.波艾克克斯())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("맓맠맰맻맦맠맧맿릲말맳맾맳맼맱맷", <Module>.埃克大斯波()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("", <Module>.波艾克大埃())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("櫈櫻櫫櫠櫽櫻櫼櫤檤櫝櫦櫢櫬櫧檩檡檭檠", <Module>.留波儿波波()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("ꨯꨲꨳꨴꨳ꩝꨿ꨜꨑꨜꨓꨞꨘ", <Module>.克埃豆斯斯())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("⠞⠃⠂⠅⠂⡬⠎⠭⠠⠭⠢⠯⠩", <Module>.波留波斯波()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("넅넘넙넞넙녺넃넸넼넲넹녷녿녳녾", <Module>.留波波留儿())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("좷좪좫좬좫죈좱좊좎좀좋죅죍죁죌", <Module>.克克儿波艾()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("", <Module>.留儿留儿艾())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("褿褦褷褻襞褼褟褒褟褐褝褛", <Module>.艾波大埃艾()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("䊑䊇䊐䋳䊑䊲䊿䊲䊽䊰䊶", <Module>.艾斯艾埃豆())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("邩邿邨郋邩邊邇邊邅邈邎", <Module>.大儿留豆波()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("ᵾᵨᵿᴜᵮᵙᵟᵕᵙᵊᵙᵘ", <Module>.克波埃留豆())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("牺牬牻爘牪牝牛牑牝牎牝牜", <Module>.大克儿艾留()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("᧸᧠᧷ᦔ᧶᧕᧘᧕᧚᧗᧑", <Module>.大波大波斯())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("㤀㤘㤏㥬㤎㤭㤠㤭㤢㤯㤩", <Module>.波留斯儿艾()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("乵乭乺丙乫乜乚乐乜乏乜九", <Module>.大艾波儿波())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("ӝӅӒұӃӴӲӸӴӧӴӵ", <Module>.儿波波留波()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("氟氚氈氓汻氙氺氷氺氵永氾", <Module>.波斯波豆留())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("㤦㤣㤱㤪㥂㤠㤃㤎㤃㤌㤁㤇", <Module>.波艾儿波斯()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("芘芝芏芔苼芎芹芿芵芹芪芹芸", <Module>.波波儿克斯())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("濖濓濁濚澲激濷濱濻濷濤濷濶", <Module>.留留留波留()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("楥楤楯椇楥楆楋楆楉楄楂", <Module>.波波斯大克())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("㣆㣇㣌㢤㣆㣥㣨㣥㣪㣧㣡", <Module>.艾大波埃斯()), typeof(decimal));
				}
				if (!this.adr_seed.Columns.Contains(<Module>.ZExtO("䠺䠻䠰䡘䠪䠝䠛䠑䠝䠎䠝䠜", <Module>.留波克斯波())))
				{
					this.adr_seed.Columns.Add(<Module>.ZExtO("삮삯삤샌삾삉삏삅삉삚삉삈", <Module>.克豆波斯留()), typeof(decimal));
				}
				decimal d = new decimal(<Module>.留留留波克());
				int i = <Module>.艾留斯波豆();
				string text = "";
				string text2 = "";
				decimal all_token_balance = 0m;
				List<DataRow> l = (from f in this.adr_seed.AsEnumerable().AsParallel<DataRow>()
				where f.Field(<Module>.ZExtO("⪬⪁⪁⪂", <Module>.艾大波波留()))
				select f).ToList(this.adr_seed.AsEnumerable().Count<DataRow>());
				if (this.label10.InvokeRequired)
				{
					this.label10.Invoke(new MethodInvoker(delegate()
					{
						this.label10.Text = <Module>.ZExtO("ꀝꀦꀽꀨꀥꁩꀈꀭꀭꀻꀬꀺꀺꀬꀺꁳꁩ", <Module>.波埃豆斯大()) + l.Count.ToString();
					}));
				}
				else
				{
					this.label10.Text = <Module>.ZExtO("", <Module>.留豆艾埃艾()) + l.Count.ToString();
				}
				List<string> list = new List<string>();
				ServicePointManager.SecurityProtocol = (SecurityProtocolType)<Module>.豆埃留波豆();
				MethodInvoker <>9__2;
				MethodInvoker <>9__3;
				foreach (DataRow dataRow in l)
				{
					decimal num = 0m;
					decimal num2 = 0m;
					decimal num3 = 0m;
					decimal num4 = 0m;
					decimal num5 = 0m;
					decimal num6 = 0m;
					decimal num7 = 0m;
					decimal num8 = 0m;
					decimal num9 = 0m;
					decimal num10 = 0m;
					decimal num11 = 0m;
					decimal num12 = 0m;
					decimal num13 = 0m;
					decimal num14 = 0m;
					decimal num15 = 0m;
					decimal num16 = 0m;
					decimal num17 = 0m;
					decimal num18 = 0m;
					decimal num19 = 0m;
					decimal num20 = 0m;
					decimal num21 = 0m;
					decimal num22 = 0m;
					decimal num23 = 0m;
					decimal num24 = 0m;
					decimal num25 = 0m;
					decimal num26 = 0m;
					decimal num27 = 0m;
					decimal num28 = 0m;
					decimal num29 = 0m;
					text = dataRow[<Module>.ZExtO("鍙鍼鍼鍪鍽鍫鍫", <Module>.波克艾留波())].ToString();
					text2 = dataRow[<Module>.ZExtO("膥膇膜膃膾膐膌", <Module>.儿儿波儿克())].ToString();
					if ((this.btc || this.ltc || this.dash || this.bch) && !text.StartsWith(<Module>.ZExtO("", <Module>.留波艾大儿())))
					{
						dataRow[<Module>.ZExtO("郥郻郴郹郗郋", <Module>.豆豆留克留())].ToString();
					}
					if (this.btc && (text.StartsWith(<Module>.ZExtO("봏", <Module>.儿克埃埃波())) || text.StartsWith(<Module>.ZExtO("盶", <Module>.艾克克儿波())) || text.StartsWith(<Module>.ZExtO("", <Module>.克留艾大埃()))))
					{
						int j = i;
						i = j + <Module>.儿斯豆艾留();
						try
						{
							HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("罰罬罬罨罫缢缷缷罺罴罷罻罳罻罰罹罱罶缶罱罶罾罷缷罹罼罼罪罽罫罫缷", <Module>.豆波留大克()) + text + <Module>.ZExtO("䆛䇂䇋䇖䇉䇅䇐䆙䇎䇗䇋䇊", <Module>.波大大大儿()));
							httpWebRequest.ReadWriteTimeout = <Module>.埃克大大斯();
							using (Stream responseStream = httpWebRequest.GetResponse().GetResponseStream())
							{
								using (StreamReader streamReader = new StreamReader(responseStream))
								{
									string source = streamReader.ReadToEnd();
									num = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source, <Module>.ZExtO("褨褳褨褽褰褃褮褹褿褹褵褪褹褸襾襦", <Module>.大克留克克()), <Module>.ZExtO("筺", <Module>.艾留波斯豆())))) / d;
									num2 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source, <Module>.ZExtO("탧탨탯탠탭탞탣탠탭탠탯탢탤킣킻", <Module>.波波大斯豆()), <Module>.ZExtO("亇", <Module>.儿埃斯儿艾())))) / d;
									dataRow[<Module>.ZExtO("砢破砣础砢码砌码砎砃砅", <Module>.斯艾儿豆埃())] = num2;
									dataRow[<Module>.ZExtO("梖梀梗棴梆梱梷梽梱梢梱械", <Module>.大波波埃波())] = num;
								}
							}
							goto IL_3DF4;
						}
						catch
						{
							HttpWebRequest httpWebRequest2 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("疪疶疶疲疱痸痭痭疠疮疭疡疩疡疪疣疫疬痬疫疬疤疭痭疣疦疦疰疧疱疱痭", <Module>.豆克大埃波()) + text + <Module>.ZExtO("꣊ꢓꢚꢇꢘꢔꢁ꣈ꢟꢆꢚꢛ", <Module>.艾儿留留留()));
							httpWebRequest2.ReadWriteTimeout = <Module>.波儿大大儿();
							using (Stream responseStream2 = httpWebRequest2.GetResponse().GetResponseStream())
							{
								using (StreamReader streamReader2 = new StreamReader(responseStream2))
								{
									string source2 = streamReader2.ReadToEnd();
									num = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source2, <Module>.ZExtO("\ud915\ud90e\ud915\ud900\ud90d\ud93e\ud913\ud904\ud902\ud904\ud908\ud917\ud904\ud905\ud943\ud95b", <Module>.艾豆克大豆()), <Module>.ZExtO("\ude7d", <Module>.埃留儿儿埃())))) / d;
									num2 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source2, <Module>.ZExtO("酤酫酬酣酮酝酠酣酮酣酬酡酧鄠鄸", <Module>.儿波艾埃留()), <Module>.ZExtO("渦", <Module>.留儿波留埃())))) / d;
									dataRow[<Module>.ZExtO("ꅨꅾꅩꄊꅨꅋꅆꅋꅄꅉꅏ", <Module>.斯波大波波())] = num2;
									dataRow[<Module>.ZExtO("忡忷忠徃忱忆忀忊忆忕忆忇", <Module>.埃克波波斯())] = num;
								}
							}
							goto IL_3DF4;
						}
					}
					if (this.ltc && (text.StartsWith(<Module>.ZExtO("컊", <Module>.艾大大大波())) || text.StartsWith(<Module>.ZExtO("鶟鶇鶐", <Module>.大艾留埃波())) || text.StartsWith(<Module>.ZExtO("", <Module>.埃留儿豆埃()))))
					{
						int j = i;
						i = j + <Module>.克克波艾埃();
						try
						{
							HttpWebRequest httpWebRequest3 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("", <Module>.儿留留大留()) + text);
							httpWebRequest3.ReadWriteTimeout = <Module>.克儿波豆豆();
							using (Stream responseStream3 = httpWebRequest3.GetResponse().GetResponseStream())
							{
								using (StreamReader streamReader3 = new StreamReader(responseStream3))
								{
									string source3 = streamReader3.ReadToEnd();
									num4 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source3, <Module>.ZExtO("ఠఏఈఇఊెతఇఊఇఈఅఃౚ఺౉కఖఇఈౘౚకఖఇఈౘ", <Module>.留克留留留()), <Module>.ZExtO("輿轓轋轜", <Module>.波克斯儿艾()))));
									num3 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source3, <Module>.ZExtO("䛐䛫䛰䛥䛨䚤䛖䛡䛧䛡䛭䛲䛡䛠䚸䛘䚫䛷䛴䛥䛪䚺䚸䛷䛴䛥䛪䚺", <Module>.斯斯波波豆()), <Module>.ZExtO("眈睤睼睫", <Module>.波波大大斯()))));
									dataRow[<Module>.ZExtO("㘟㘇㘐㙳㘑㘲㘿㘲㘽㘰㘶", <Module>.留大斯波留())] = num4;
									dataRow[<Module>.ZExtO("᫁᫙ᫎ᪭᫟᫨᫮᫤᫨᫻᫨᫩", <Module>.儿留豆波斯())] = num3;
								}
							}
							goto IL_3DF4;
						}
						catch
						{
							HttpWebRequest httpWebRequest4 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("", <Module>.艾留留埃留()) + text);
							httpWebRequest4.ReadWriteTimeout = <Module>.豆艾斯留儿();
							using (Stream responseStream4 = httpWebRequest4.GetResponse().GetResponseStream())
							{
								using (StreamReader streamReader4 = new StreamReader(responseStream4))
								{
									string source4 = streamReader4.ReadToEnd();
									num4 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source4, <Module>.ZExtO("冦冉冎冁册净冢冁册冁冎冃内凜冼减冓冐冁冎凞凜冓冐冁冎凞", <Module>.埃留克豆波()), <Module>.ZExtO("ຍ໡໹໮", <Module>.留克埃波儿()))));
									num3 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source4, <Module>.ZExtO("⇅⇾⇥⇰⇽↱⇃⇴⇲⇴⇸⇧⇴⇵↭⇍↾⇢⇡⇰⇿↯↭⇢⇡⇰⇿↯", <Module>.波大波儿克()), <Module>.ZExtO("菍莡莹莮", <Module>.留豆克豆波()))));
									dataRow[<Module>.ZExtO("瘖瘎瘙発瘘瘻瘶瘻瘴瘹瘿", <Module>.艾克留留豆())] = num4;
									dataRow[<Module>.ZExtO("ꦥꦽꦪ꧉ꦻꦌꦊꦀꦌꦟꦌꦍ", <Module>.波波儿豆埃())] = num3;
								}
							}
							goto IL_3DF4;
						}
					}
					if (this.bch && text.StartsWith(<Module>.ZExtO("", <Module>.克艾波儿斯())))
					{
						int j = i;
						i = j + <Module>.豆斯斯豆埃();
						try
						{
							HttpWebRequest httpWebRequest5 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("", <Module>.留波艾埃留()) + text);
							httpWebRequest5.ReadWriteTimeout = <Module>.大波波豆豆();
							using (Stream responseStream5 = httpWebRequest5.GetResponse().GetResponseStream())
							{
								using (StreamReader streamReader5 = new StreamReader(responseStream5))
								{
									string source5 = streamReader5.ReadToEnd();
									num6 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source5, <Module>.ZExtO("컓컼컻컴컹캵컗컴컹컴컻컶컰캩컉캺컦컥컴컻캫캩컦컥컴컻캫", <Module>.豆留斯儿埃()), <Module>.ZExtO("譖謴謵謾", <Module>.留波艾埃大()))));
									num5 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source5, <Module>.ZExtO("冒冩冲冧冪処冔冣冥冣冯冰冣冢出冚凩况冶冧冨凸出况冶冧冨凸", <Module>.波留埃大艾()), <Module>.ZExtO("", <Module>.留留波留克()))));
									dataRow[<Module>.ZExtO("ퟗퟖퟝힵퟗퟴퟹퟴퟻퟶퟰ", <Module>.斯儿克豆大())] = num6;
									dataRow[<Module>.ZExtO("䣂䣃䣈䢠䣒䣥䣣䣩䣥䣶䣥䣤", <Module>.波留波艾儿())] = num5;
								}
							}
							goto IL_3DF4;
						}
						catch
						{
							HttpWebRequest httpWebRequest6 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("뀛뀇뀇뀃뀀끉끜끜뀑뀐뀛뀑뀟뀜뀐뀘뀖뀋뀃뀟뀜뀁뀖뀁끝뀐뀜뀞끜뀒뀗뀗뀁뀖뀀뀀끜뀑뀚뀇뀐뀜뀚뀝뀐뀒뀀뀛끉", <Module>.埃豆儿豆埃()) + text);
							httpWebRequest6.ReadWriteTimeout = <Module>.儿大埃艾大();
							using (Stream responseStream6 = httpWebRequest6.GetResponse().GetResponseStream())
							{
								using (StreamReader streamReader6 = new StreamReader(responseStream6))
								{
									string source6 = streamReader6.ReadToEnd();
									num6 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source6, <Module>.ZExtO("㜋㜤㜣㜬㜡㝭㜏㜬㜡㜬㜣㜮㜨㝱㜑㝢㜾㜽㜬㜣㝳㝱㜾㜽㜬㜣㝳", <Module>.留艾斯儿大()), <Module>.ZExtO("뷀붢붣붨", <Module>.埃波斯留埃()))));
									num5 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source6, <Module>.ZExtO("䬇䬼䬧䬲䬿䭳䬁䬶䬰䬶䬺䬥䬶䬷䭯䬏䭼䬠䬣䬲䬽䭭䭯䬠䬣䬲䬽䭭", <Module>.波儿大波儿()), <Module>.ZExtO("ᤃᥡᥠᥫ", <Module>.大大大波大()))));
									dataRow[<Module>.ZExtO("鴜鴝鴖鵾鴜鴿鴲鴿鴰鴽鴻", <Module>.波埃埃波大())] = num6;
									dataRow[<Module>.ZExtO("⯈⯉⯂⮪⯘⯯⯩⯣⯯⯼⯯⯮", <Module>.波波克大留())] = num5;
								}
							}
							goto IL_3DF4;
						}
					}
					if (this.dash && text.StartsWith(<Module>.ZExtO("Ჱ", <Module>.留留克克艾())))
					{
						int j = i;
						i = j + <Module>.艾留留儿大();
						try
						{
							HttpWebRequest httpWebRequest7 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("몔몈몈몌몏뫆뫓뫓몘몝몏몔몞몐몓몟몗몙몄몌몐몓몎몙몎뫒몟몓몑뫓몝몘몘몎몙몏몏뫓", <Module>.埃斯留艾豆()) + text);
							httpWebRequest7.ReadWriteTimeout = <Module>.大艾豆大波();
							using (Stream responseStream7 = httpWebRequest7.GetResponse().GetResponseStream())
							{
								using (StreamReader streamReader7 = new StreamReader(responseStream7))
								{
									string source7 = streamReader7.ReadToEnd();
									num8 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source7, <Module>.ZExtO("", <Module>.大埃儿大豆()), <Module>.ZExtO("ӈҬҩһҠ", <Module>.留艾波大留()))));
									num7 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source7, <Module>.ZExtO("嘫嘐嘋嘞嘓噟嘭嘚嘜嘚嘖嘉嘚嘛噃嘣噐嘌嘏嘞嘑噁噃嘌嘏嘞嘑噁", <Module>.斯艾豆儿留()), <Module>.ZExtO("紭絉経絞絅", <Module>.大留斯斯埃()))));
									dataRow[<Module>.ZExtO("ꪔꪑꪃꪘ꫰ꪒꪱꪼꪱꪾꪳꪵ", <Module>.波留艾克大())] = num8;
									dataRow[<Module>.ZExtO("劸劽劯労勜劮劙功劕劙劊劙劘", <Module>.克斯波留埃())] = num7;
								}
							}
							goto IL_3DF4;
						}
						catch
						{
							HttpWebRequest httpWebRequest8 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("ꜝ꜁꜁꜅꜆ꝏꝚꝚ꜑꜔꜆ꜝꜗꜙꜚ꜖ꜞ꜐꜍꜅ꜙꜚ꜇꜐꜇ꝛ꜖ꜚꜘꝚ꜔꜑꜑꜇꜐꜆꜆Ꝛ", <Module>.斯留留艾留()) + text);
							httpWebRequest8.ReadWriteTimeout = <Module>.波波留克克();
							using (Stream responseStream8 = httpWebRequest8.GetResponse().GetResponseStream())
							{
								using (StreamReader streamReader8 = new StreamReader(responseStream8))
								{
									string source8 = streamReader8.ReadToEnd();
									num8 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source8, <Module>.ZExtO("킳킜킛킔킙탕킷킔킙킔킛킖킐탉킩탚킆킅킔킛탋탉킆킅킔킛탋", <Module>.埃儿斯克埃()), <Module>.ZExtO("痆疢疧疵疮", <Module>.波大斯克艾()))));
									num7 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source8, <Module>.ZExtO("㌯㌔㌏㌚㌗㍛㌩㌞㌘㌞㌒㌍㌞㌟㍇㌧㍔㌈㌋㌚㌕㍅㍇㌈㌋㌚㌕㍅", <Module>.波大儿斯埃()), <Module>.ZExtO("濸澜澙澋澐", <Module>.留波艾埃留()))));
									dataRow[<Module>.ZExtO("티틵틧틼튔틶틕틘틕틚틗틑", <Module>.大斯大大大())] = num8;
									dataRow[<Module>.ZExtO("蘠蘥蘷蘬虄蘶蘁蘇蘍蘁蘒蘁蘀", <Module>.波波波克埃())] = num7;
								}
							}
							goto IL_3DF4;
						}
					}
					if (text.StartsWith(<Module>.ZExtO("ﯭﮥ", <Module>.留儿克埃埃())) && (this.eth || this.bsc || this.ftm || this.ht || this.polygon || this.snowtrace || this.arbitrum || this.movr || this.ronint || this.optimeth))
					{
						int j = i;
						i = j + <Module>.埃儿留埃留();
						if (this.eth && text.StartsWith(<Module>.ZExtO("\udbeb\udba3", <Module>.波埃大留斯())))
						{
							try
							{
								HttpWebRequest httpWebRequest9 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("鉟鉃鉃鉇鉄鈍鈘鈘鉒鉃鉟鉒鉅鉄鉔鉖鉙鈙鉞鉘鈘鉖鉓鉓鉅鉒鉄鉄鈘", <Module>.留克艾留埃()) + text);
								httpWebRequest9.ReadWriteTimeout = <Module>.豆斯波斯留();
								using (Stream responseStream9 = httpWebRequest9.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader9 = new StreamReader(responseStream9))
									{
										string source9 = streamReader9.ReadToEnd();
										try
										{
											num9 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source9, <Module>.ZExtO("", <Module>.波大留留儿()), <Module>.ZExtO("힬퟉ퟸퟤퟩ퟾", <Module>.艾豆埃埃克())).Replace(<Module>.ZExtO("뭜묂뭞", <Module>.埃斯艾克豆()), "").Replace(<Module>.ZExtO("⦱⦢⧯⦳", <Module>.波豆留克埃()), "")));
										}
										catch
										{
											num9 = 0m;
										}
										try
										{
											num20 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source9, <Module>.ZExtO("㠶㡧㡸㡽㡰㡱㡝㡺㡁㡤㠶㠴㡰㡵㡠㡵㠹㡡㡺㡲㡻㡸㡰㠹㡵㡺㡽㡹㡵㡠㡽㡻㡺㠹㡻㡡㡠㠩㠶㡲㡵㡰㡱㡛㡡㡠㠶㠪㡈㡺㡈㡐", <Module>.斯豆留埃波()), <Module>.ZExtO("퓞퓬풾퓱퓲퓣퓬", <Module>.大斯留克克())).Replace(<Module>.ZExtO("㋑", <Module>.大豆留斯大()), "")));
										}
										catch
										{
											num20 = 0m;
										}
										dataRow[<Module>.ZExtO("ƴƥƹǑƳƐƝƐƟƒƔ", <Module>.儿波艾波大())] = num9;
										dataRow[<Module>.ZExtO("鈹鈮鈿鉑鈨鈓鈗鈙鈒鉜鉔鉘鉕", <Module>.留豆斯波克())] = num20;
										all_token_balance += num20;
									}
								}
							}
							catch
							{
								HttpWebRequest httpWebRequest10 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("睵睩睩睭睮眧眲眲睸睩睵睸睯睮睾睼睳眳睴睲眲睼睹睹睯睸睮睮眲", <Module>.艾留波留斯()) + text);
								httpWebRequest10.ReadWriteTimeout = <Module>.埃儿儿克艾();
								using (Stream responseStream10 = httpWebRequest10.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader10 = new StreamReader(responseStream10))
									{
										string source10 = streamReader10.ReadToEnd();
										try
										{
											num9 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source10, <Module>.ZExtO("쨻쨷쨴쩵쨵쨼쩵쩠쩺쩦", <Module>.波留留留波()), <Module>.ZExtO("䣏䢪䢛䢇䢊䢝", <Module>.波埃豆豆波())).Replace(<Module>.ZExtO("㯿㮡㯽", <Module>.克波波留大()), "").Replace(<Module>.ZExtO("ឆផ៘ង", <Module>.埃波克留斯()), "")));
										}
										catch
										{
											num9 = 0m;
										}
										try
										{
											num20 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source10, <Module>.ZExtO("徬忽忢忧忪快忇忠忛忾徬微忪忯忺忯徣忻忠忨忡忢忪徣忯忠忧忣忯忺忧忡忠徣忡忻忺徳徬忨忯忪快忁忻忺徬徰忒忠忒忊", <Module>.大儿波豆波()), <Module>.ZExtO("", <Module>.波波大留埃())).Replace(<Module>.ZExtO("鞹", <Module>.儿斯儿儿留()), "")));
										}
										catch
										{
											num20 = 0m;
										}
										dataRow[<Module>.ZExtO("", <Module>.留豆克埃豆())] = num9;
										dataRow[<Module>.ZExtO("駀駗駆馨駑駪駮駠駫馥馭馡馬", <Module>.波埃大豆豆())] = num20;
										all_token_balance += num20;
									}
								}
							}
						}
						if (this.bsc && text.StartsWith(<Module>.ZExtO("", <Module>.斯克艾斯斯())))
						{
							try
							{
								HttpWebRequest httpWebRequest11 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("叆叚叚叞叝厔厁厁双叝反叝反叏叀厀反叁參厁叏及及叜友叝叝厁", <Module>.艾留留豆斯()) + text);
								httpWebRequest11.ReadWriteTimeout = <Module>.埃埃留儿艾();
								using (Stream responseStream11 = httpWebRequest11.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader11 = new StreamReader(responseStream11))
									{
										string source11 = streamReader11.ReadToEnd();
										try
										{
											num10 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source11, <Module>.ZExtO("忽忱忲徳忳忺徳徦徼徠", <Module>.艾波埃留克()), <Module>.ZExtO("⫸⪚⪖⪚", <Module>.豆儿儿波留())).Replace(<Module>.ZExtO("\ud9f4\ud9aa\ud9f6", <Module>.埃大克留波()), "").Replace(<Module>.ZExtO("⯈⯛⮖⯊", <Module>.大波留豆艾()), "")));
										}
										catch
										{
											num10 = 0m;
										}
										try
										{
											num21 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source11, <Module>.ZExtO("々ごかぎぃあのぉひし々〇ぃうこう《げぉぁえかぃ《うぉぎおうこぎえぉ《えげこ〚々ぁうぃあとげこ々〙ほぉほっ", <Module>.儿斯克儿留()), <Module>.ZExtO("쐷쐅쑗쐘쐛쐊쐅", <Module>.克波波波波())).Replace(<Module>.ZExtO("蘯", <Module>.波埃波留大()), "")));
										}
										catch
										{
											num21 = 0m;
										}
										dataRow[<Module>.ZExtO("ᖢᖮᖢᗀᖢᖁᖌᖁᖎᖃᖅ", <Module>.埃豆留留埃())] = num10;
										dataRow[<Module>.ZExtO("圁圆圓坮圗圬在圦圭坣坫坧坪", <Module>.留波克儿克())] = num21;
										all_token_balance += num21;
									}
								}
							}
							catch
							{
								dataRow[<Module>.ZExtO("∩∥∩≋∩∊∇∊∅∈∎", <Module>.大波豆留豆())] = <Module>.儿斯豆克留();
								dataRow[<Module>.ZExtO("", <Module>.波儿大大豆())] = <Module>.留豆斯豆儿();
								continue;
							}
						}
						if (this.ftm && text.StartsWith(<Module>.ZExtO("ѦЮ", <Module>.埃留儿留波())))
						{
							try
							{
								HttpWebRequest httpWebRequest12 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("巹工工巡巢嶫嶾嶾巷工巼巢已巰巿嶿已巾巼嶾巰巵巵巣巴巢巢嶾", <Module>.大留豆留克()) + text);
								httpWebRequest12.ReadWriteTimeout = <Module>.大埃波艾克();
								using (Stream responseStream12 = httpWebRequest12.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader12 = new StreamReader(responseStream12))
									{
										string source12 = streamReader12.ReadToEnd();
										try
										{
											num11 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source12, <Module>.ZExtO("틯틣틠튡틡틨튡튴튮튲", <Module>.儿留斯留波()), <Module>.ZExtO("䃋䂭䂿䂦", <Module>.艾埃大艾豆())).Replace(<Module>.ZExtO("譳謭譱", <Module>.波艾克留艾()), "").Replace(<Module>.ZExtO("卪卹匴卨", <Module>.留克斯埃埃()), "")));
										}
										catch
										{
											num11 = 0m;
										}
										try
										{
											num22 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source12, <Module>.ZExtO("晩昸昧昢是昮昂春昞昻晩晫是昪昿昪晦显春昭昤昧是晦昪春昢昦昪昿昢昤春晦昤显昿晶晩昭昪是昮昄显昿晩晵昗春昗昏", <Module>.波波波克艾()), <Module>.ZExtO("ﵢﵐﴂ﵍﵎ﵟﵐ", <Module>.留斯克豆艾())).Replace(<Module>.ZExtO("︿", <Module>.大大波斯大()), "")));
										}
										catch
										{
											num22 = 0m;
										}
										dataRow[<Module>.ZExtO("뢤뢶뢯룂뢠뢃뢎뢃뢌뢁뢇", <Module>.埃波波斯克())] = num11;
										dataRow[<Module>.ZExtO("ֺ֣֨׃ֺցօ֋ր׎׆׊ׇ", <Module>.豆艾埃艾埃())] = num22;
										all_token_balance += num22;
									}
								}
							}
							catch
							{
								HttpWebRequest httpWebRequest13 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("ＥＹＹ］＾ｷ｢｢ＫＹ＠＾ＮＬＣ｣ＮＢ＠｢ＬＩＩ＿Ｈ＾＾｢", <Module>.儿儿克大艾()) + text);
								httpWebRequest13.ReadWriteTimeout = <Module>.克留波留儿();
								using (Stream responseStream13 = httpWebRequest13.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader13 = new StreamReader(responseStream13))
									{
										string source13 = streamReader13.ReadToEnd();
										try
										{
											num11 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source13, <Module>.ZExtO("\udd88\udd84\udd87\uddc6\udd86\udd8f\uddc6\uddd3\uddc9\uddd5", <Module>.留埃克留留()), <Module>.ZExtO("舅艣艱艨", <Module>.大豆大埃儿())).Replace(<Module>.ZExtO("ᰠ᱾ᰢ", <Module>.埃留豆留艾()), "").Replace(<Module>.ZExtO("䊇䊔䋙䊅", <Module>.儿波埃留克()), "")));
										}
										catch
										{
											num11 = 0m;
										}
										try
										{
											num22 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source13, <Module>.ZExtO("♊☛☄☁☌☍☡☆☽☘♊♈☌☉☜☉♅☝☆☎☇☄☌♅☉☆☁★☉☜☁☇☆♅☇☝☜♕♊☎☉☌☍☧☝☜♊♖☴☆☴☬", <Module>.留波留埃留()), <Module>.ZExtO("碖碤磶碹確碫碤", <Module>.克克留波留())).Replace(<Module>.ZExtO("ʷ", <Module>.留豆斯留波()), "")));
										}
										catch
										{
											num22 = 0m;
										}
										dataRow[<Module>.ZExtO("㥮㥼㥥㤈㥪㥉㥄㥉㥆㥋㥍", <Module>.豆儿留大留())] = num11;
										dataRow[<Module>.ZExtO("䳢䳰䳩䲉䳰䳋䳏䳁䳊䲄䲌䲀䲍", <Module>.豆斯埃留豆())] = num22;
										all_token_balance += num22;
									}
								}
							}
						}
						if (this.ht && text.StartsWith(<Module>.ZExtO("䙃䘋", <Module>.留波艾儿留())))
						{
							try
							{
								HttpWebRequest httpWebRequest14 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("゘ややむゃナミミ゘ゕんゟ゙ゞゖゟマんゟゝミゑゔゔもゕゃゃミ", <Module>.儿留留波留()) + text);
								httpWebRequest14.ReadWriteTimeout = <Module>.克斯埃豆波();
								using (Stream responseStream14 = httpWebRequest14.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader14 = new StreamReader(responseStream14))
									{
										string source14 = streamReader14.ReadToEnd();
										try
										{
											num12 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source14, <Module>.ZExtO("", <Module>.斯克豆留克()), <Module>.ZExtO("\ud974\ud91c\ud900", <Module>.克儿留克艾())).Replace(<Module>.ZExtO("렼롢렾", <Module>.埃艾儿埃克()), "").Replace(<Module>.ZExtO("굺굩괤굸", <Module>.儿儿豆埃埃()), "")));
										}
										catch
										{
											num12 = 0m;
										}
										try
										{
											num23 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source14, <Module>.ZExtO("ỳẢẽẸẵẴẘếẄạỳựẵẰấẰỼẤếặẾẽẵỼẰếẸẼẰấẸẾếỼẾẤấỬỳặẰẵẴẞẤấỳữẍếẍẕ", <Module>.大留克留留()), <Module>.ZExtO("後徾忬徣徠徱徾", <Module>.儿波波儿斯())).Replace(<Module>.ZExtO("䙣", <Module>.儿艾留留艾()), "")));
										}
										catch
										{
											num23 = 0m;
										}
										dataRow[<Module>.ZExtO("ꍢꍾꌊꍨꍋꍆꍋꍄꍉꍏ", <Module>.波斯留儿波())] = num12;
										dataRow[<Module>.ZExtO("⏌⏐⎩⏐⏫⏯⏡⏪⎤⎬⎠⎭", <Module>.克大留埃波())] = num23;
										all_token_balance += num23;
									}
								}
							}
							catch
							{
								HttpWebRequest httpWebRequest15 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("钆钚钚钞钝铔铁铁钆钋钍钁钇钀针钁铀钍钁钃铁钏钊钊钜钋钝钝铁", <Module>.埃克留斯克()) + text);
								httpWebRequest15.ReadWriteTimeout = <Module>.留大豆豆波();
								using (Stream responseStream15 = httpWebRequest15.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader15 = new StreamReader(responseStream15))
									{
										string source15 = streamReader15.ReadToEnd();
										try
										{
											num12 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source15, <Module>.ZExtO("顽顱顲頳顳顺頳頦頼頠", <Module>.波埃波儿留()), <Module>.ZExtO("\ud801\ud869\ud875", <Module>.波留波留豆())).Replace(<Module>.ZExtO("텐턎텒", <Module>.留儿克波波()), "").Replace(<Module>.ZExtO("謂謑譜謀", <Module>.波克斯大留()), "")));
										}
										catch
										{
											num12 = 0m;
										}
										try
										{
											num23 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source15, <Module>.ZExtO("璉瓘瓇瓂瓏瓎瓢瓅瓾瓛璉璋瓏瓊瓟瓊璆瓞瓅瓍瓄瓇瓏璆瓊瓅瓂瓆瓊瓟瓂瓄瓅璆瓄瓞瓟璖璉瓍瓊瓏瓎瓤瓞瓟璉璕瓷瓅瓷瓯", <Module>.埃埃埃儿波()), <Module>.ZExtO("ᅮᅜᄎᅁᅂᅓᅜ", <Module>.艾留艾留波())).Replace(<Module>.ZExtO("〕", <Module>.波艾豆埃留()), "")));
										}
										catch
										{
											num23 = 0m;
										}
										dataRow[<Module>.ZExtO("퇉퇕톡퇃퇠퇭퇠퇯퇢퇤", <Module>.波留留斯豆())] = num12;
										dataRow[<Module>.ZExtO("ဒဎၷဎဵေဿဴၺၲၾၳ", <Module>.大留艾克斯())] = num23;
										all_token_balance += num23;
									}
								}
							}
						}
						if (this.polygon && text.StartsWith(<Module>.ZExtO("䏾䎶", <Module>.波豆埃留儿())))
						{
							try
							{
								HttpWebRequest httpWebRequest16 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("ѐььшыЂЗЗшїєсџїіыћљіЖћїѕЗљќќъѝыыЗ", <Module>.大克儿埃波()) + text);
								httpWebRequest16.ReadWriteTimeout = <Module>.儿豆儿豆豆();
								using (Stream responseStream16 = httpWebRequest16.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader16 = new StreamReader(responseStream16))
									{
										string source16 = streamReader16.ReadToEnd();
										try
										{
											num13 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source16, <Module>.ZExtO("㍡㍭㍮㌯㍯㍦㌯㌺㌠㌼", <Module>.留斯大埃艾()), <Module>.ZExtO("ꟚꞷꞻꞮꞳꞹ", <Module>.豆波克艾艾())).Replace(<Module>.ZExtO("쐏쑑쐍", <Module>.艾大豆大艾()), "").Replace(<Module>.ZExtO("퓑퓂풏퓓", <Module>.艾波留留波()), "")));
										}
										catch
										{
											num13 = 0m;
										}
										try
										{
											num24 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source16, <Module>.ZExtO("鏎鎟鎀鎅鎈鎉鎥鎂鎹鎜鏎鏌鎈鎍鎘鎍鏁鎙鎂鎊鎃鎀鎈鏁鎍鎂鎅鎁鎍鎘鎅鎃鎂鏁鎃鎙鎘鏑鏎鎊鎍鎈鎉鎣鎙鎘鏎鏒鎰鎂鎰鎨", <Module>.艾波波波留()), <Module>.ZExtO("伲伀佒伝伞伏伀", <Module>.大留留儿克())).Replace(<Module>.ZExtO("뒫", <Module>.波克留大埃()), "")));
										}
										catch
										{
											num24 = 0m;
										}
										dataRow[<Module>.ZExtO("ժզճծդԇեՆՋՆՉՄՂ", <Module>.埃斯留艾大())] = num13;
										dataRow[<Module>.ZExtO("햴햫햨햽햣햫햪헉햰햋햏햁햊헄헌헀헍", <Module>.艾留留斯克())] = num24;
										all_token_balance += num24;
									}
								}
							}
							catch
							{
								HttpWebRequest httpWebRequest17 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("샳샯샯샫샨삡살살샫샴샷샢샼샴샵샨샸샺샵삵샸샴샶살샺샿샿샩샾샨샨살", <Module>.豆克波留波()) + text);
								httpWebRequest17.ReadWriteTimeout = <Module>.大克斯艾大();
								using (Stream responseStream17 = httpWebRequest17.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader17 = new StreamReader(responseStream17))
									{
										string source17 = streamReader17.ReadToEnd();
										try
										{
											num13 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source17, <Module>.ZExtO("ᒆᒊᒉᓈᒈᒁᓈᓝᓇᓛ", <Module>.克留留艾斯()), <Module>.ZExtO("張彘彔彁彜彖", <Module>.埃留波波波())).Replace(<Module>.ZExtO("", <Module>.波波儿斯留()), "").Replace(<Module>.ZExtO("퀢퀱큼퀠", <Module>.波留大克波()), "")));
										}
										catch
										{
											num13 = 0m;
										}
										try
										{
											num24 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source17, <Module>.ZExtO("├╍╒╗╚╛╷═╫╎├┞╚╟╊╟┓╋═╘║╒╚┓╟═╗╓╟╊╗║═┓║╋╊┃├╘╟╚╛╱╋╊├─╢═╢╺", <Module>.儿斯留儿艾()), <Module>.ZExtO("㸢㸐㹂㸍㸎㸟㸐", <Module>.克留波豆留())).Replace(<Module>.ZExtO("＊", <Module>.儿留大豆豆()), "")));
										}
										catch
										{
											num24 = 0m;
										}
										dataRow[<Module>.ZExtO("暬暠暵暨暢曁暣暀暍暀暏暂暄", <Module>.艾儿豆大斯())] = num13;
										dataRow[<Module>.ZExtO("밍밒밑밄밚밒밓뱰밉밲밶밸밳뱽뱵뱹뱴", <Module>.波留克波波())] = num24;
										all_token_balance += num24;
									}
								}
							}
						}
						if (this.arbitrum && text.StartsWith(<Module>.ZExtO("ﵽﴵ", <Module>.留波克埃波())))
						{
							try
							{
								HttpWebRequest httpWebRequest18 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("砢砾砾砺砹硰硥硥砫砸砨砣砹砩砫砤硤砣砥硥砫砮砮砸砯砹砹硥", <Module>.波波埃波儿()) + text);
								httpWebRequest18.ReadWriteTimeout = <Module>.留埃留豆埃();
								using (Stream responseStream18 = httpWebRequest18.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader18 = new StreamReader(responseStream18))
									{
										string source18 = streamReader18.ReadToEnd();
										try
										{
											num15 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source18, <Module>.ZExtO("⨔⨘⨛⩚⨚⨓⩚⩏⩕⩉", <Module>.艾波留留克()), <Module>.ZExtO("襶褓褂褞", <Module>.留埃波斯豆())).Replace(<Module>.ZExtO("ꖇꗙꖅ", <Module>.儿留豆豆豆()), "").Replace(<Module>.ZExtO("㧞㧍㦀㧜", <Module>.斯克埃留埃()), "")));
										}
										catch
										{
											num15 = 0m;
										}
										try
										{
											num26 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(source18, <Module>.ZExtO("쨔쨑쨄쨑쩝쨅쨞쨖쨟쨜쨔쩝쨑쨞쨙쨝쨑쨄쨙쨟쨞쩝쨟쨅쨄쩍쩒쨖쨑쨔쨕쨿쨅쨄쩒쩎쩛", <Module>.波大波留波()), <Module>.ZExtO("띵뜍뜁띲띵띍뜅띵뜇띴뜃뜀", <Module>.留留艾斯克())).Replace(<Module>.ZExtO("\ud849", <Module>.艾留埃斯艾()), "")));
										}
										catch
										{
											num26 = 0m;
										}
										dataRow[<Module>.ZExtO("", <Module>.大埃艾大斯())] = num15;
										dataRow[<Module>.ZExtO("", <Module>.波艾豆克儿())] = num26;
										all_token_balance += num26;
									}
								}
							}
							catch
							{
								HttpWebRequest httpWebRequest19 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("﻾ﻢﻢﻦﻥﺬﺹﺹﻷﻤﻴ﻿ﻥﻵﻷﻸﺸ﻿ﻹﺹﻷﻲﻲﻤﻳﻥﻥﺹ", <Module>.留留克波波()) + text);
								httpWebRequest19.ReadWriteTimeout = <Module>.波豆豆豆大();
								using (Stream responseStream19 = httpWebRequest19.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader19 = new StreamReader(responseStream19))
									{
										string source19 = streamReader19.ReadToEnd();
										try
										{
											num15 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source19, <Module>.ZExtO("惽惱惲悳想惺悳悦悼悠", <Module>.斯埃豆克大()), <Module>.ZExtO("镰锕锄锘", <Module>.儿留留克波())).Replace(<Module>.ZExtO("㮨㯶㮪", <Module>.留留儿大儿()), "").Replace(<Module>.ZExtO("蝆蝕蜘蝄", <Module>.斯留波儿艾()), "")));
										}
										catch
										{
											num15 = 0m;
										}
										try
										{
											num26 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(source19, <Module>.ZExtO("", <Module>.克波斯留豆()), <Module>.ZExtO("쨋쩳쩿쨌쨋쨳쩻쨋쩹쨊쩽쩾", <Module>.豆儿波留大())).Replace(<Module>.ZExtO("", <Module>.艾留埃豆波()), "")));
										}
										catch
										{
											num26 = 0m;
										}
										dataRow[<Module>.ZExtO("⭡⭒⭂⭉⭔⭒⭕⭍⬀⭢⭁⭌⭁⭎⭃⭅", <Module>.斯埃留埃留())] = num15;
										dataRow[<Module>.ZExtO("벟벬벼벷벪벬벫벳볳벊벱벵벻벰볾볶볺볷", <Module>.豆埃波波波())] = num26;
										all_token_balance += num26;
									}
								}
							}
						}
						if (this.optimeth && text.StartsWith(<Module>.ZExtO("鑱鐹", <Module>.儿克波克克())))
						{
							try
							{
								HttpWebRequest httpWebRequest20 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("ᤉᤕᤕᤑᤒᥛ᥎᥎ᤎᤑᤕᤈᤌᤈᤒᤕᤈᤂ᥏ᤄᤕᤉᤄᤓᤒᤂᤀᤏ᥏ᤈᤎ᥎ᤀᤅᤅᤓᤄᤒᤒ᥎", <Module>.斯斯大大克()) + text);
								httpWebRequest20.ReadWriteTimeout = <Module>.留波埃斯大();
								using (Stream responseStream20 = httpWebRequest20.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader20 = new StreamReader(responseStream20))
									{
										string source20 = streamReader20.ReadToEnd();
										try
										{
											num14 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source20, <Module>.ZExtO("㻑㻝㻞㺟㻟㻖㺟㺊㺐㺌", <Module>.豆波儿波波()), <Module>.ZExtO("냙낼낍낑난낋", <Module>.豆波波豆波())).Replace(<Module>.ZExtO("噻嘥噹", <Module>.克埃波克儿()), "").Replace(<Module>.ZExtO("輁輒轟較", <Module>.克儿留埃斯()), "")));
										}
										catch
										{
											num14 = 0m;
										}
										try
										{
											num25 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(source20, <Module>.ZExtO("㯣㯦㯳㯦㮪㯲㯩㯡㯨㯫㯣㮪㯦㯩㯮㯪㯦㯳㯮㯨㯩㮪㯨㯲㯳㮺㮥㯡㯦㯣㯢㯈㯲㯳㮥㮹㮬", <Module>.留留儿儿克()), <Module>.ZExtO("ᣒᢪᢦᣕᣒᣪᢢᣒᢠᣓᢤᢧ", <Module>.波艾儿留艾())).Replace(<Module>.ZExtO("䪆", <Module>.波埃大波艾()), "")));
										}
										catch
										{
											num25 = 0m;
										}
										dataRow[<Module>.ZExtO("", <Module>.斯波豆豆留())] = num14;
										dataRow[<Module>.ZExtO("厙厦厢县去县厥厢县厵厓厂厞叻厂厹厽厳厸叶叾史叿", <Module>.留波留儿豆())] = num25;
										all_token_balance += num25;
									}
								}
							}
							catch
							{
								HttpWebRequest httpWebRequest21 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("", <Module>.斯留克儿埃()) + text);
								httpWebRequest21.ReadWriteTimeout = <Module>.斯大豆豆波();
								using (Stream responseStream21 = httpWebRequest21.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader21 = new StreamReader(responseStream21))
									{
										string source21 = streamReader21.ReadToEnd();
										try
										{
											num14 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source21, <Module>.ZExtO("", <Module>.埃埃豆儿波()), <Module>.ZExtO("⭟⬺⬋⬗⬚⬍", <Module>.大埃豆波埃())).Replace(<Module>.ZExtO("♓☍♑", <Module>.克儿埃艾留()), "").Replace(<Module>.ZExtO("翽翮羣翿", <Module>.儿儿艾斯波()), "")));
										}
										catch
										{
											num14 = 0m;
										}
										try
										{
											num25 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(source21, <Module>.ZExtO("恮恫恾恫性恿恤恬恥恦恮性恫恤恣恧恫恾恣恥恤性恥恿恾怷怨恬恫恮息恅恿恾怨怴怡", <Module>.留埃豆儿留()), <Module>.ZExtO("㜯㝗㝛㜨㜯㜗㝟㜯㝝㜮㝙㝚", <Module>.豆留埃波波())).Replace(<Module>.ZExtO("꨼", <Module>.克埃波大留()), "")));
										}
										catch
										{
											num25 = 0m;
										}
										dataRow[<Module>.ZExtO("胴胋胏胒胖胒胈胏胒胘胾胯胳肛胹胚胗胚胕胘胞", <Module>.克留斯艾留())] = num14;
										dataRow[<Module>.ZExtO("噭噒噖噋噏噋噑噖噋噁噧噶噪嘏噶噍噉噇噌嘂嘊嘆嘋", <Module>.波波留儿留())] = num25;
										all_token_balance += num25;
									}
								}
							}
						}
						if (this.snowtrace && text.StartsWith(<Module>.ZExtO("呀合", <Module>.艾留艾斯波())))
						{
							try
							{
								HttpWebRequest httpWebRequest22 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("ꇽꇡꇡꇥꇦꆯꆺꆺꇦꇻꇺꇢꇡꇧꇴꇶꇰꆻꇼꇺꆺꇴꇱꇱꇧꇰꇦꇦꆺ", <Module>.留波波留豆()) + text);
								httpWebRequest22.ReadWriteTimeout = <Module>.埃埃斯留波();
								using (Stream responseStream22 = httpWebRequest22.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader22 = new StreamReader(responseStream22))
									{
										string source22 = streamReader22.ReadToEnd();
										try
										{
											num17 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source22, <Module>.ZExtO("焆焊焉煈焈焁煈煝煇煛", <Module>.留埃克埃留()), <Module>.ZExtO("䆦䇇䇐䇇䇞", <Module>.克大儿埃波())).Replace(<Module>.ZExtO("婐娎婒", <Module>.克波豆波儿()), "").Replace(<Module>.ZExtO("\ud8b0\ud8a3\ud8ee\ud8b2", <Module>.埃留大留大()), "")));
										}
										catch
										{
											num17 = 0m;
										}
										try
										{
											num28 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(source22, <Module>.ZExtO("ዥዠድዠኬዴዯዧዮይዥኬዠዯየዬዠድየዮዯኬዮዴድኼኣዧዠዥዤዎዴድኣ኿ኪ", <Module>.留豆留波留()), <Module>.ZExtO("뒶듎듂뒱뒶뒎듆뒶듄뒷듀듃", <Module>.波斯留大波())).Replace(<Module>.ZExtO("\ud985", <Module>.埃大波克艾()), "")));
										}
										catch
										{
											num28 = 0m;
										}
										dataRow[<Module>.ZExtO("檓檄檓檊櫺檁檼檽檥檦檠檳檱檷櫻櫲檐檳檾檳檼檱檷", <Module>.儿大留波波())] = num17;
										dataRow[<Module>.ZExtO("릇릐릇릞맮릕릨릩릱릲릴릧릥릣맯맫릒릩릭릣릨맦맮맢맯", <Module>.斯波留留斯())] = num28;
										all_token_balance += num28;
									}
								}
							}
							catch
							{
								HttpWebRequest httpWebRequest23 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("ꪽꪡꪡꪥꪦꫯ꫺꫺ꪦꪻꪺꪢꪡꪧꪴꪶꪰ꫻ꪼꪺ꫺ꪴꪱꪱꪧꪰꪦꪦ꫺", <Module>.克波埃留豆()) + text);
								httpWebRequest23.ReadWriteTimeout = <Module>.艾波大艾豆();
								using (Stream responseStream23 = httpWebRequest23.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader23 = new StreamReader(responseStream23))
									{
										string source23 = streamReader23.ReadToEnd();
										try
										{
											num17 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source23, <Module>.ZExtO("", <Module>.豆斯波克留()), <Module>.ZExtO("冮减凘减凖", <Module>.留波波儿大())).Replace(<Module>.ZExtO("䌪䍴䌨", <Module>.留埃波克豆()), "").Replace(<Module>.ZExtO("糚糉粄糘", <Module>.波豆艾克埃()), "")));
										}
										catch
										{
											num17 = 0m;
										}
										try
										{
											num28 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(source23, <Module>.ZExtO("皸皽皨皽盱皩皲皺皳皰皸盱皽皲皵皱皽皨皵皳皲盱皳皩皨盡盾皺皽皸皹皓皩皨盾盢盷", <Module>.儿留埃斯波()), <Module>.ZExtO("햆헾헲햁햆햾헶햆헴햇헰헳", <Module>.艾斯埃波留())).Replace(<Module>.ZExtO("◜", <Module>.大豆留克儿()), "")));
										}
										catch
										{
											num28 = 0m;
										}
										dataRow[<Module>.ZExtO("本朻本朵杅朾會朂朚朙期朌朎月杄杍术朌朁朌會朎月", <Module>.留留大大留())] = num17;
										dataRow[<Module>.ZExtO("", <Module>.留波留留大())] = num28;
										all_token_balance += num28;
									}
								}
							}
						}
						if (this.movr && text.StartsWith(<Module>.ZExtO("飑颙", <Module>.克豆豆留斯())))
						{
							try
							{
								HttpWebRequest httpWebRequest24 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("砷砫砫砯砬硥硰硰砲砰砰砱砭砶砩砺砭硱砲砰砰砱砬砼砾砱硱砶砰硰硰砾砻砻砭砺砬砬硰", <Module>.艾克斯留斯()) + text);
								httpWebRequest24.ReadWriteTimeout = <Module>.留克艾波留();
								using (Stream responseStream24 = httpWebRequest24.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader24 = new StreamReader(responseStream24))
									{
										string source24 = streamReader24.ReadToEnd();
										try
										{
											num16 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source24, <Module>.ZExtO("튯튣튠틡튡튨틡틴틮틲", <Module>.儿大埃波埃()), <Module>.ZExtO("꺜껱껳껪껮", <Module>.豆斯儿波波())).Replace(<Module>.ZExtO("索老泌", <Module>.斯艾大大斯()), "").Replace(<Module>.ZExtO("ໟ໌ກໝ", <Module>.大儿艾留艾()), "")));
										}
										catch
										{
											num16 = 0m;
										}
										try
										{
											num27 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(source24, <Module>.ZExtO("⭴⭱⭤⭱⬽⭥⭾⭶⭿⭼⭴⬽⭱⭾⭹⭽⭱⭤⭹⭿⭾⬽⭿⭥⭤⬭⬲⭶⭱⭴⭵⭟⭥⭤⬲⬮⬻", <Module>.艾大斯克大()), <Module>.ZExtO("", <Module>.克儿大豆斯())).Replace(<Module>.ZExtO("猔", <Module>.波豆豆波斯()), "")));
										}
										catch
										{
											num27 = 0m;
										}
										dataRow[<Module>.ZExtO("ᖛᖙᖀᖄᗶᖔᖷᖺᖷᖸᖵᖳ", <Module>.留波埃波大())] = num16;
										dataRow[<Module>.ZExtO("薣薡薸薼藃薺薁薅薋薀藎藆藊藇", <Module>.豆大艾波埃())] = num27;
										all_token_balance += num27;
									}
								}
							}
							catch
							{
								HttpWebRequest httpWebRequest25 = (HttpWebRequest)WebRequest.Create(<Module>.ZExtO("", <Module>.豆留豆大留()) + text);
								httpWebRequest25.ReadWriteTimeout = <Module>.留艾儿波斯();
								using (Stream responseStream25 = httpWebRequest25.GetResponse().GetResponseStream())
								{
									using (StreamReader streamReader25 = new StreamReader(responseStream25))
									{
										string source25 = streamReader25.ReadToEnd();
										try
										{
											num16 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParse(source25, <Module>.ZExtO("ᶐᶜᶟᷞᶞᶗᷞ᷋᷑᷍", <Module>.波克留留豆()), <Module>.ZExtO("歨欅欇欞欚", <Module>.大留儿克埃())).Replace(<Module>.ZExtO("䂔䃊䂖", <Module>.斯儿留埃儿()), "").Replace(<Module>.ZExtO("ⓑⓂ⒏ⓓ", <Module>.豆艾克留儿()), "")));
										}
										catch
										{
											num16 = 0m;
										}
										try
										{
											num27 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(source25, <Module>.ZExtO("ꏦꏣꏶꏣꎯꏷꏬꏤꏭꏮꏦꎯꏣꏬꏫꏯꏣꏶꏫꏭꏬꎯꏭꏷꏶꎿꎠꏤꏣꏦꏧꏍꏷꏶꎠꎼꎩ", <Module>.大儿波克大()), <Module>.ZExtO("ꍻꌃꌏꍼꍻꍃꌋꍻꌉꍺꌍꌎ", <Module>.斯儿豆埃波())).Replace(<Module>.ZExtO("釛", <Module>.波斯克克留()), "")));
										}
										catch
										{
											num27 = 0m;
										}
										dataRow[<Module>.ZExtO("舕舗舎舊艸舚船舴船舶舻舽", <Module>.波留艾留埃())] = num16;
										dataRow[<Module>.ZExtO("㶐㶒㶋㶏㷰㶉㶲㶶㶸㶳㷽㷵㷹㷴", <Module>.埃艾波大波())] = num27;
										all_token_balance += num27;
									}
								}
							}
						}
						if (this.ronint && text.StartsWith(<Module>.ZExtO("ﰌﱄ", <Module>.斯埃留儿留())))
						{
							try
							{
								CookieContainer cookieContainer = new CookieContainer();
								HttpClientHandler httpClientHandler = new HttpClientHandler();
								httpClientHandler.CookieContainer = cookieContainer;
								httpClientHandler.UseCookies = (<Module>.斯波斯埃豆() != 0);
								string str = text.Replace(<Module>.ZExtO("纬绤", <Module>.儿大儿克儿()), "");
								using (HttpClient httpClient = new HttpClient(httpClientHandler))
								{
									httpClient.DefaultRequestHeaders.Add(<Module>.ZExtO("\udb9b\udbbd\udbab\udbbc\udbe3\udb8f\udba9\udbab\udba0\udbba", <Module>.艾豆儿儿斯()), <Module>.ZExtO("馻香馌馟馚馚馗駙駃駘駆駖駞馡馟馘馒香馁馅駖馸馢駖駇駆駘駆駍駖馡馟馘駀駂駍駖馎駀駂駟駖馷馆馆馚馓馡馓馔馽馟馂駙駃駅駁駘駅駀駖駞馽馾馢馻馺駚駖馚馟馝馓駖馱馓馕馝香駟駖馵馞馄香馛馓駙駁駎駘駆駘駅駏駆駂駘駏駁駖馥馗馐馗馄馟駙駃駅駁駘駅駀", <Module>.豆留儿斯斯()));
									Uri requestUri = new Uri(<Module>.ZExtO("齩齵齵齱齲鼻鼮鼮齤齹齱齭齮齳齤齳鼯齳齮齯齨齯齢齩齠齨齯鼯齢齮齬鼮齠齥齥齳齤齲齲鼮齳齮齯齨齯鼻", <Module>.留埃儿波儿()) + str);
									string result = httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, requestUri)).Result.Content.ReadAsStringAsync().Result;
									try
									{
										num18 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(result, <Module>.ZExtO("샊삅삆삗삘샖삕삚삗삅삅샋샔삚삓삗삒삟삘삑샛샄샆샔새", <Module>.儿大留波克()), <Module>.ZExtO("壉墺墽墅壍墽壏墼壋壈", <Module>.斯留斯克斯()))));
									}
									catch
									{
										num18 = 0m;
									}
									try
									{
										num29 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseSnow(result, <Module>.ZExtO("馶駮駣駼馪駩駦駫駹駹馷馨駾駯駲駾馧馻馸馨馴駞駥駾駫駦馪駄駯駾駽駥駸駾駢馰馤", <Module>.波埃埃斯斯()), <Module>.ZExtO("ᏎᎽᎺᎂᏊᎺᏈᎻᏌᏏ", <Module>.克留留波留())).Replace(<Module>.ZExtO("륄", <Module>.埃豆儿克波()), "")));
									}
									catch
									{
										num29 = 0m;
									}
									try
									{
										num19 = Convert.ToDecimal(this.useCorrectSeparator(this.RegexParseAxie(result, <Module>.ZExtO("ᇣᆺᇺᇹᇴᇹᇶᇻᇽᆺᆢᆺ", <Module>.儿大儿波波()), <Module>.ZExtO("珆珈珆玐王玏玁玊玥玀玀玖玁玗玗珆珞珆珔玜珗珖珝珑珔玀玆珖玅珓珕珒珐玅玁珜珗珗珕珖珕珑珔珕率珓珝珓玀珓珝玁珓玆珓珝玀珓珐率珆", <Module>.斯波波波大()))));
									}
									catch
									{
										num19 = 0m;
									}
									dataRow[<Module>.ZExtO("雠雽雼電雼隒雰雓雞雓雜雑雗", <Module>.大留斯埃留())] = num18;
									dataRow[<Module>.ZExtO("乐乍乌之乌丯乖乭乩乧乬丢个並丫", <Module>.波儿留留留())] = num29;
									dataRow[<Module>.ZExtO("", <Module>.豆留留埃克())] = num19;
									all_token_balance += num29;
								}
							}
							catch
							{
								dataRow[<Module>.ZExtO("ㇾ㇣㇢㇥㇢ㆌ㇮㇍㇀㇍㇂㇏㇉", <Module>.艾艾留豆艾())] = <Module>.儿艾波儿波();
								dataRow[<Module>.ZExtO("䇙䇄䇅䇂䇅䆦䇟䇤䇠䇮䇥䆫䆣䆯䆢", <Module>.豆克留儿豆())] = <Module>.艾斯儿留留();
								dataRow[<Module>.ZExtO("ɜɅɔɘȽɟɼɱɼɳɾɸ", <Module>.大艾波大波())] = <Module>.大波克斯波();
								continue;
							}
						}
					}
					IL_3DF4:
					if ((num2 > this.fbalance_btc || num4 > this.fbalance_ltc || num6 > this.fbalance_bch || num8 > this.fbalance_dash || num9 > this.fbalance_eth || num10 > this.fbalance_bsc || num11 > this.fbalance_ftm || num12 > this.fbalance_ht || num13 > this.fbalance_matic || num14 > this.fbalance_oteth || num17 > this.fbalance_snowtrace || num16 > this.fbalance_moonriver || num15 > this.fbalance_arbiscan || num18 > this.fbalance_ronin || num19 > this.fbalance_axie || num20 > this.ftoken_erc || num21 > this.ftoken_bsc || num26 > this.ftoken_arbiscan || num22 > this.ftoken_ftm || num23 > this.ftoken_ht || num27 > this.ftoken_moonriver || num25 > this.ftoken_oteth || num24 > this.ftoken_polygon || num29 > this.ftoken_ronin || num28 > this.ftoken_snowtrace) && this.api_bot != "" && this.Chat_id != "")
					{
						string apilToken = this.api_bot;
						string chat_id = this.Chat_id;
						string[] array = new string[<Module>.斯波艾斯波()];
						array[<Module>.儿豆留波艾()] = <Module>.ZExtO("ݭݪ⁥⁥⁥ܢܡܬܡܮܣܥ݀ܡܬܥܴܲ⁥⁥⁥ݭݪܳ܅܅܄ݚ݀", <Module>.儿波艾艾留());
						array[<Module>.艾留留艾大()] = text2;
						array[<Module>.儿留儿斯留()] = <Module>.ZExtO("\ud8c2\ud8c5\ud88e\ud8ab\ud8ab\ud8bd\ud8aa\ud8bc\ud8bc\ud8f5\ud8ef", <Module>.埃克留克大());
						array[<Module>.大留克留克()] = text;
						array[<Module>.克留艾留大()] = <Module>.ZExtO("杋杌뽻믶뽻믶뽻믶朄朧未朧木朥朣뽻믶뽻믶뽻믶杋杌杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杻杋杌", <Module>.儿波留大克());
						array[<Module>.留豆留波斯()] = string.Join(<Module>.ZExtO("籏籈", <Module>.波艾艾留埃()), list);
						array[<Module>.波克波波波()] = <Module>.ZExtO("ȂȅȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲȲ", <Module>.艾波儿留大());
						this.TelegramSendMessage(apilToken, chat_id, string.Concat(array));
						list.Clear();
					}
					if (this.label7.InvokeRequired)
					{
						Control control = this.label7;
						MethodInvoker method;
						if ((method = <>9__2) == null)
						{
							method = (<>9__2 = delegate()
							{
								this.label7.Text = <Module>.ZExtO("ى٢ٯ٩١ٯٮتًٮٮٸٯٹٹٯٹذت", <Module>.大儿斯波儿()) + i.ToString();
							});
						}
						control.Invoke(method);
					}
					else
					{
						this.label7.Text = <Module>.ZExtO("ꊥꊎꊃꊅꊍꊃꊂꋆꊧꊂꊂꊔꊃꊕꊕꊃꊕꋜꋆ", <Module>.斯大波留波()) + i.ToString();
					}
					if (this.label8.InvokeRequired)
					{
						Control control2 = this.label8;
						MethodInvoker method2;
						if ((method2 = <>9__3) == null)
						{
							method2 = (<>9__3 = delegate()
							{
								this.label8.Text = <Module>.ZExtO("忏忴忯忺忷徻忯忴忰忾念徻忨忮快快忷忢御徻", <Module>.克豆大波留()) + all_token_balance.ToString() + <Module>.ZExtO("鏪鏮", <Module>.波波大豆艾());
							});
						}
						control2.Invoke(method2);
					}
					else
					{
						this.label8.Text = <Module>.ZExtO("", <Module>.埃大豆斯艾()) + all_token_balance.ToString() + <Module>.ZExtO("룑룕", <Module>.大豆大埃埃());
					}
					DataGridView obj = this.dataGridView1;
					bool flag = <Module>.埃大儿豆留() != 0;
					try
					{
						Monitor.Enter(obj, ref flag);
						this.GridChoice(this.adr_seed);
					}
					finally
					{
						if (flag)
						{
							Monitor.Exit(obj);
						}
					}
				}
				this.time.Start();
			}
			catch (Exception ex)
			{
				if (this.time != null)
				{
					this.time.Stop();
				}
				this.simpleButton1.Enabled = (<Module>.波留大波儿() != 0);
				this.simpleButton2.Enabled = (<Module>.豆克斯克波() != 0);
				this.simpleButton3.Enabled = (<Module>.斯儿波埃留() != 0);
				MessageBox.Show(ex.Message + ex.InnerException);
			}
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00015FC8 File Offset: 0x000141C8
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			if (this.seededit.Checked)
			{
				this.seedcheck = this.seededit.Checked;
				this.SeedCheck();
				return;
			}
			if (this.privkeyedit.Checked)
			{
				this.privkeycheck = this.privkeyedit.Checked;
				this.PrivkeyCheck();
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00002202 File Offset: 0x00000402
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			this.label4.Text = "";
			this.mnemonics.Clear();
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0001603C File Offset: 0x0001423C
		private void simpleButton3_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.FileName = "";
			if (this.openFileDialog1.ShowDialog() == (DialogResult)<Module>.艾斯大波斯())
			{
				try
				{
					string[] array = File.ReadAllLines(this.openFileDialog1.FileName);
					for (int i = <Module>.克儿波斯波(); i < array.Length; i += <Module>.大儿波儿留())
					{
						string text = array[i];
						if (text != "" && text != null)
						{
							this.mnemonics.Add(text.ToLower().Replace(<Module>.ZExtO("ʅˍ", <Module>.留波波大波()), ""));
						}
					}
					this.label4.Text = <Module>.ZExtO("䔳䔐䔞䔛䔚䔛䕅䕟", <Module>.波埃埃波波()) + this.mnemonics.Count;
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00002225 File Offset: 0x00000425
		private void checkedListBox1_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00016160 File Offset: 0x00014360
		private void checkedListBoxControl1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
		{
			this.btc = this.checkedListBoxControl1.GetItemChecked(<Module>.豆克留留波());
			this.ltc = this.checkedListBoxControl1.GetItemChecked(<Module>.儿艾大克留());
			this.dash = this.checkedListBoxControl1.GetItemChecked(<Module>.留豆大波儿());
			this.bch = this.checkedListBoxControl1.GetItemChecked(<Module>.克留埃埃斯());
			this.eth = this.checkedListBoxControl1.GetItemChecked(<Module>.斯儿留大留());
			this.bsc = this.checkedListBoxControl1.GetItemChecked(<Module>.艾留波留留());
			this.ftm = this.checkedListBoxControl1.GetItemChecked(<Module>.艾克艾埃斯());
			this.ht = this.checkedListBoxControl1.GetItemChecked(<Module>.埃波留留埃());
			this.polygon = this.checkedListBoxControl1.GetItemChecked(<Module>.豆留斯留留());
			this.arbitrum = this.checkedListBoxControl1.GetItemChecked(<Module>.大波埃豆波());
			this.optimeth = this.checkedListBoxControl1.GetItemChecked(<Module>.留豆埃艾斯());
			this.movr = this.checkedListBoxControl1.GetItemChecked(<Module>.斯大留豆波());
			this.snowtrace = this.checkedListBoxControl1.GetItemChecked(<Module>.留留留儿豆());
			this.ronint = this.checkedListBoxControl1.GetItemChecked(<Module>.儿波斯留儿());
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00002227 File Offset: 0x00000427
		private void seededit_CheckedChanged(object sender, EventArgs e)
		{
			if (this.seededit.Checked)
			{
				this.privkeyedit.Checked = (<Module>.大艾克豆大() != 0);
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0000224F File Offset: 0x0000044F
		private void privkeyedit_CheckedChanged(object sender, EventArgs e)
		{
			if (this.privkeyedit.Checked)
			{
				this.seededit.Checked = (<Module>.波留豆波克() != 0);
			}
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x000162F8 File Offset: 0x000144F8
		private void DataTableToTextFile(DataTable dt, string outputFilePath)
		{
			int[] array = new int[dt.Columns.Count];
			for (int i = <Module>.克波波埃儿(); i < dt.Columns.Count; i += <Module>.艾克埃留埃())
			{
				array[i] = dt.Columns[i].ColumnName.Length;
				foreach (object obj in dt.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (!dataRow.IsNull(i))
					{
						int length = dataRow[i].ToString().Length;
						if (length > array[i])
						{
							array[i] = length;
						}
					}
				}
			}
			using (StreamWriter streamWriter = new StreamWriter(outputFilePath, <Module>.波大豆克克() != 0))
			{
				for (int j = <Module>.埃艾留豆斯(); j < dt.Columns.Count; j += <Module>.斯留埃斯波())
				{
					streamWriter.Write(dt.Columns[j].ColumnName.PadRight(array[j] + <Module>.豆克艾大克()));
				}
				streamWriter.WriteLine();
				foreach (object obj2 in dt.Rows)
				{
					DataRow dataRow2 = (DataRow)obj2;
					for (int k = <Module>.儿大埃留艾(); k < dt.Columns.Count; k += <Module>.克埃豆斯斯())
					{
						if (!dataRow2.IsNull(k))
						{
							streamWriter.Write(dataRow2[k].ToString().PadRight(array[k] + <Module>.埃埃留埃波()));
						}
						else
						{
							streamWriter.Write(new string((char)<Module>.艾波波波豆(), array[k] + <Module>.豆儿埃留斯()));
						}
					}
					streamWriter.WriteLine();
				}
				streamWriter.Close();
			}
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0001660C File Offset: 0x0001480C
		private void saveFileExcel_Click(object sender, EventArgs e)
		{
			string outputFilePath = Path.Combine(Environment.CurrentDirectory, <Module>.ZExtO("⚕⚧⚰⚣⚢⚙", <Module>.埃斯留留波()) + DateTime.Now.ToString(<Module>.ZExtO("鰋鱂鰢鱂鰖鰖鰖鰖鱏鰧鰧鱂鰂鰂鱂鰜鰜", <Module>.儿克波波波())) + <Module>.ZExtO("蛥蚿蚳蚿", <Module>.波大埃留克()));
			DataTable dataTable = new DataTable();
			foreach (object obj in this.dataGridView1.Columns)
			{
				DataGridViewTextBoxColumn dataGridViewTextBoxColumn = (DataGridViewTextBoxColumn)obj;
				dataTable.Columns.Add(dataGridViewTextBoxColumn.Name, dataGridViewTextBoxColumn.ValueType);
			}
			foreach (object obj2 in ((IEnumerable)this.dataGridView1.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
				DataRow dataRow = dataTable.NewRow();
				foreach (object obj3 in this.dataGridView1.Columns)
				{
					DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = (DataGridViewTextBoxColumn)obj3;
					if (dataGridViewRow.Cells[dataGridViewTextBoxColumn2.Name].Value.ToString() != "")
					{
						dataRow[dataGridViewTextBoxColumn2.Name] = dataGridViewRow.Cells[dataGridViewTextBoxColumn2.Name].Value.ToString();
					}
				}
				dataTable.Rows.Add(dataRow);
			}
			this.DataTableToTextFile(dataTable, outputFilePath);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00016898 File Offset: 0x00014A98
		private void simpleButton4_Click(object sender, EventArgs e)
		{
			this.checkedListBoxControl1.CheckAll();
			this.btc = this.checkedListBoxControl1.GetItemChecked(<Module>.埃波留艾儿());
			this.ltc = this.checkedListBoxControl1.GetItemChecked(<Module>.艾儿克大斯());
			this.dash = this.checkedListBoxControl1.GetItemChecked(<Module>.艾留克豆大());
			this.bch = this.checkedListBoxControl1.GetItemChecked(<Module>.儿大波儿艾());
			this.eth = this.checkedListBoxControl1.GetItemChecked(<Module>.波艾豆儿儿());
			this.bsc = this.checkedListBoxControl1.GetItemChecked(<Module>.波艾埃豆留());
			this.ftm = this.checkedListBoxControl1.GetItemChecked(<Module>.儿艾艾儿斯());
			this.ht = this.checkedListBoxControl1.GetItemChecked(<Module>.波留波艾艾());
			this.polygon = this.checkedListBoxControl1.GetItemChecked(<Module>.大埃克儿波());
			this.arbitrum = this.checkedListBoxControl1.GetItemChecked(<Module>.留豆波克波());
			this.optimeth = this.checkedListBoxControl1.GetItemChecked(<Module>.埃留波留大());
			this.movr = this.checkedListBoxControl1.GetItemChecked(<Module>.留留留留斯());
			this.snowtrace = this.checkedListBoxControl1.GetItemChecked(<Module>.豆儿斯波留());
			this.ronint = this.checkedListBoxControl1.GetItemChecked(<Module>.豆大波波豆());
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00016A3C File Offset: 0x00014C3C
		private void simpleButton5_Click(object sender, EventArgs e)
		{
			this.checkedListBoxControl1.UnCheckAll();
			this.btc = this.checkedListBoxControl1.GetItemChecked(<Module>.克豆斯埃斯());
			this.ltc = this.checkedListBoxControl1.GetItemChecked(<Module>.波波斯留留());
			this.dash = this.checkedListBoxControl1.GetItemChecked(<Module>.留波豆斯留());
			this.bch = this.checkedListBoxControl1.GetItemChecked(<Module>.斯斯儿波波());
			this.eth = this.checkedListBoxControl1.GetItemChecked(<Module>.留儿留大儿());
			this.bsc = this.checkedListBoxControl1.GetItemChecked(<Module>.儿留大克留());
			this.ftm = this.checkedListBoxControl1.GetItemChecked(<Module>.艾留埃克艾());
			this.ht = this.checkedListBoxControl1.GetItemChecked(<Module>.埃斯波艾留());
			this.polygon = this.checkedListBoxControl1.GetItemChecked(<Module>.埃艾豆埃波());
			this.arbitrum = this.checkedListBoxControl1.GetItemChecked(<Module>.克儿豆大大());
			this.optimeth = this.checkedListBoxControl1.GetItemChecked(<Module>.波艾埃豆波());
			this.movr = this.checkedListBoxControl1.GetItemChecked(<Module>.留波留大艾());
			this.snowtrace = this.checkedListBoxControl1.GetItemChecked(<Module>.留埃克豆大());
			this.ronint = this.checkedListBoxControl1.GetItemChecked(<Module>.豆波波艾波());
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00002277 File Offset: 0x00000477
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.writeSetting();
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00016BE0 File Offset: 0x00014DE0
		private void btcf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (int)e.KeyChar != <Module>.豆波克留儿() && (int)e.KeyChar != <Module>.豆儿留艾留())
			{
				e.Handled = (<Module>.豆留埃波克() != 0);
			}
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00016C48 File Offset: 0x00014E48
		private void ltcf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (int)e.KeyChar != <Module>.埃留埃波克() && (int)e.KeyChar != <Module>.儿波埃埃儿())
			{
				e.Handled = (<Module>.豆留埃波波() != 0);
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00016CB0 File Offset: 0x00014EB0
		private void dashf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (int)e.KeyChar != <Module>.波豆大留波() && (int)e.KeyChar != <Module>.豆留克大波())
			{
				e.Handled = (<Module>.波留大留艾() != 0);
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00016D18 File Offset: 0x00014F18
		private void bchf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (int)e.KeyChar != <Module>.埃埃大留大() && (int)e.KeyChar != <Module>.留儿豆留波())
			{
				e.Handled = (<Module>.艾波埃斯波() != 0);
			}
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00016D80 File Offset: 0x00014F80
		private void ethf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (int)e.KeyChar != <Module>.波儿波波克() && (int)e.KeyChar != <Module>.埃留克大克())
			{
				e.Handled = (<Module>.留大波大大() != 0);
			}
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00016DE8 File Offset: 0x00014FE8
		private void bscf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (int)e.KeyChar != <Module>.波埃斯波艾() && (int)e.KeyChar != <Module>.豆克克留大())
			{
				e.Handled = (<Module>.儿豆留克留() != 0);
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00016E50 File Offset: 0x00015050
		private void ftmf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (int)e.KeyChar != <Module>.斯波留留豆() && (int)e.KeyChar != <Module>.克克留儿艾())
			{
				e.Handled = (<Module>.留留豆儿波() != 0);
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00016EB8 File Offset: 0x000150B8
		private void hecof_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (int)e.KeyChar != <Module>.克豆艾斯豆() && (int)e.KeyChar != <Module>.留留儿艾留())
			{
				e.Handled = (<Module>.大留大波留() != 0);
			}
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00016F20 File Offset: 0x00015120
		private void maticf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (int)e.KeyChar != <Module>.埃儿埃留豆() && (int)e.KeyChar != <Module>.克留斯大克())
			{
				e.Handled = (<Module>.艾艾留波克() != 0);
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00016F88 File Offset: 0x00015188
		private void arbitrumf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (int)e.KeyChar != <Module>.埃斯留波斯() && (int)e.KeyChar != <Module>.儿大儿克波())
			{
				e.Handled = (<Module>.儿儿大儿儿() != 0);
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00016FF0 File Offset: 0x000151F0
		private void optimisticf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (int)e.KeyChar != <Module>.艾留埃克艾() && (int)e.KeyChar != <Module>.留波留波艾())
			{
				e.Handled = (<Module>.儿儿斯埃大() != 0);
			}
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00017058 File Offset: 0x00015258
		private void moonf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (int)e.KeyChar != <Module>.豆埃留留波() && (int)e.KeyChar != <Module>.克埃留斯波())
			{
				e.Handled = (<Module>.儿埃豆克大() != 0);
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000170C0 File Offset: 0x000152C0
		private void snowf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (int)e.KeyChar != <Module>.波斯艾儿艾() && (int)e.KeyChar != <Module>.波留大斯大())
			{
				e.Handled = (<Module>.斯波儿克艾() != 0);
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00017128 File Offset: 0x00015328
		private void roninf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (int)e.KeyChar != <Module>.埃克儿波留() && (int)e.KeyChar != <Module>.儿留波留艾())
			{
				e.Handled = (<Module>.艾大留波留() != 0);
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00002282 File Offset: 0x00000482
		private void ercf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = (<Module>.留留大波克() != 0);
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x000022B8 File Offset: 0x000004B8
		private void bepf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = (<Module>.留克艾留艾() != 0);
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000022EE File Offset: 0x000004EE
		private void fttf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = (<Module>.波儿儿斯艾() != 0);
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00002324 File Offset: 0x00000524
		private void hectf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = (<Module>.波大波儿波() != 0);
			}
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0000235A File Offset: 0x0000055A
		private void polytf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = (<Module>.艾大斯儿艾() != 0);
			}
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00002390 File Offset: 0x00000590
		private void arbtf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = (<Module>.艾波儿埃豆() != 0);
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x000023C6 File Offset: 0x000005C6
		private void opttf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = (<Module>.波艾豆大波() != 0);
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x000023FC File Offset: 0x000005FC
		private void moontf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = (<Module>.波波斯豆克() != 0);
			}
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00002432 File Offset: 0x00000632
		private void snowtf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = (<Module>.留留斯克埃() != 0);
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00002468 File Offset: 0x00000668
		private void ronintf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = (<Module>.埃克艾大斯() != 0);
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0000249E File Offset: 0x0000069E
		private void axief_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = (<Module>.斯豆斯艾大() != 0);
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00017190 File Offset: 0x00015390
		private void Form1_Load(object sender, EventArgs e)
		{
			string text = Form1.Value();
			ServicePointManager.SecurityProtocol = (SecurityProtocolType)<Module>.留艾儿波留();
			string text2 = <Module>.ZExtO("࿬ྺྼྻ྾྾ྐྵ྽ྤ࿲࿹࿺࿢ྤ࿸࿿", <Module>.埃留艾留克());
			string text3 = <Module>.ZExtO("犏狙狟狘狝狝狚狞状犊犛犐犙犝犆犜犚犌犛", <Module>.留儿大波斯());
			string text4 = <Module>.ZExtO("팛퍍퍋퍌퍉퍉퍎퍊팢팞팏팄팍팉팒팈팎팘팏", <Module>.豆埃波留豆());
			string text5 = <Module>.ZExtO("㣘㢻㣾㢸㣲㣜㣰㣃", <Module>.克克埃儿艾());
			string[] array = new string[<Module>.波留大留儿()];
			array[<Module>.留大波埃豆()] = <Module>.ZExtO("暕暃暔暐暃暔曛", <Module>.波儿留留埃());
			array[<Module>.波豆儿豆克()] = text2;
			array[<Module>.大留波克斯()] = <Module>.ZExtO("㑶㐸㐾㐨㐿㑰", <Module>.斯留儿儿斯());
			array[<Module>.大艾埃斯埃()] = text4;
			array[<Module>.斯克儿波儿()] = <Module>.ZExtO("౼ణదళదథదఴఢ౺", <Module>.留大斯波波());
			array[<Module>.大艾豆留留()] = text3;
			array[<Module>.克留埃留斯()] = <Module>.ZExtO("鳬鲧鲶鲤鲤鲠鲸鲥鲳鳪", <Module>.艾埃斯艾留());
			array[<Module>.豆儿儿留儿()] = text5;
			array[<Module>.斯儿斯波留()] = <Module>.ZExtO("\udc9e\udcf6\udcf6\udce9\udc85\udce8\udcca\udcc1\udcc0\udc85\udc98\udc85\udceb\udcca\udccb\udcc0", <Module>.斯斯留大儿());
			MySqlConnection mySqlConnection = new MySqlConnection(string.Concat(array));
			return;
			try
			{
				try
				{
				}
				finally
				{
					StreamReader streamReader;
					if (streamReader != null)
					{
						((IDisposable)streamReader).Dispose();
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show(<Module>.ZExtO("惼惔擁悢惕惑惚惟悠悭擁惞惟惕惛惚悯悦惙患悭悠悮擁惙惚惙擁惟患悠悢患悠患惓悢惔患擁惚惙悧惔惜惖惙悮", <Module>.波斯留波大()));
				Environment.Exit(<Module>.大克艾留克());
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00017418 File Offset: 0x00015618
		private static string Value()
		{
			if (string.IsNullOrEmpty(Form1._fingerPrint))
			{
				string[] array = new string[<Module>.大波儿儿艾()];
				array[<Module>.克波波留波()] = <Module>.ZExtO("ﲭﲾﲻﳎﳐﳐﳎ", <Module>.留埃艾波留());
				array[<Module>.波豆艾豆豆()] = Form1.CpuId();
				array[<Module>.波埃克埃波()] = <Module>.ZExtO("紷絿絴絲絮紝紃紃紝", <Module>.儿斯克大艾());
				array[<Module>.斯波儿儿留()] = Form1.BiosId();
				array[<Module>.豆留艾大留()] = <Module>.ZExtO("饴餼餿餭餻饞饀饀饞", <Module>.豆波克斯大());
				array[<Module>.波儿波留留()] = Form1.BaseId();
				array[<Module>.大留艾留大()] = <Module>.ZExtO("∺≴≹≣≻∐∎∎∐", <Module>.大艾艾豆豆());
				array[<Module>.豆大埃豆克()] = Form1.DiskId();
				array[<Module>.儿大留留艾()] = <Module>.ZExtO("쒼쓠쓿쓲쓳쓹쒖쒈쒈쒖", <Module>.豆大大波埃());
				array[<Module>.豆豆豆波波()] = Form1.VideoId();
				array[<Module>.豆波斯留斯()] = <Module>.ZExtO("ℼⅻⅷⅵ№℈℈№", <Module>.波克留大斯());
				array[<Module>.波留儿大艾()] = Form1.MacId();
				Form1._fingerPrint = Form1.GetHash(string.Concat(array));
			}
			return Form1._fingerPrint;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00017520 File Offset: 0x00015720
		private static string GetHash(string s)
		{
			HashAlgorithm hashAlgorithm = new MD5CryptoServiceProvider();
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			return Form1.GetHexString(hashAlgorithm.ComputeHash(bytes));
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00017554 File Offset: 0x00015754
		private static string GetHexString(IList<byte> bt)
		{
			string text = string.Empty;
			for (int i = <Module>.儿波克埃儿(); i < bt.Count; i += <Module>.艾儿波斯留())
			{
				byte b = bt[i];
				int num = (int)b & <Module>.埃留艾大豆();
				int num2 = b >> <Module>.豆克克波波() & <Module>.波艾留艾豆();
				if (num2 > <Module>.克埃留儿波())
				{
					text += ((char)(num2 - <Module>.留留留儿克() + <Module>.埃儿豆留大())).ToString(CultureInfo.InvariantCulture);
				}
				else
				{
					text += num2.ToString(CultureInfo.InvariantCulture);
				}
				if (num > <Module>.克波留克大())
				{
					text += ((char)(num - <Module>.克斯留艾大() + <Module>.艾豆埃豆留())).ToString(CultureInfo.InvariantCulture);
				}
				else
				{
					text += num.ToString(CultureInfo.InvariantCulture);
				}
				if (i + <Module>.波埃克波留() != bt.Count && (i + <Module>.艾大留儿克()) % <Module>.艾大留克留() == 0)
				{
					text += <Module>.ZExtO("", <Module>.大斯大波斯());
				}
			}
			return text;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000176CC File Offset: 0x000158CC
		private static string Identifier(string wmiClass, string wmiProperty, string wmiMustBeTrue)
		{
			string text = "";
			foreach (ManagementBaseObject managementBaseObject in new ManagementClass(wmiClass).GetInstances())
			{
				if (!(managementBaseObject[wmiMustBeTrue].ToString() != <Module>.ZExtO("읋읭읪읺", <Module>.留斯豆波留())) && !(text != ""))
				{
					try
					{
						text = managementBaseObject[wmiProperty].ToString();
						break;
					}
					catch
					{
					}
				}
			}
			return text;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000177B4 File Offset: 0x000159B4
		private static string Identifier(string wmiClass, string wmiProperty)
		{
			string text = "";
			foreach (ManagementBaseObject managementBaseObject in new ManagementClass(wmiClass).GetInstances())
			{
				if (!(text != ""))
				{
					try
					{
						text = managementBaseObject[wmiProperty].ToString();
						break;
					}
					catch
					{
					}
				}
			}
			return text;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00017870 File Offset: 0x00015A70
		private static string CpuId()
		{
			string text = Form1.Identifier(<Module>.ZExtO("", <Module>.留波留留波()), <Module>.ZExtO("톿톄톃톛톟톏톣톎", <Module>.豆艾艾大波()));
			if (text != "")
			{
				return text;
			}
			text = Form1.Identifier(<Module>.ZExtO("껐껮껩꺴꺵께껗껵껨껤껢껴껴껨껵", <Module>.留大斯豆波()), <Module>.ZExtO("났낎낓낟낙낏낏낓낎낵나", <Module>.波大儿儿豆()));
			if (text != "")
			{
				return text;
			}
			text = Form1.Identifier(<Module>.ZExtO("", <Module>.大儿艾儿斯()), <Module>.ZExtO("ꬤꬋ꬇꬏", <Module>.埃大留艾艾()));
			if (text == "")
			{
				text = Form1.Identifier(<Module>.ZExtO("", <Module>.大大埃留儿()), <Module>.ZExtO("춧춋춄춟춌춋춉춞춟춘춏춘", <Module>.克波埃波留()));
			}
			return text + Form1.Identifier(<Module>.ZExtO("ࢗࢩࢮࣲࣳ࢟࢐ࢲࢯࢣࢥࢳࢳࢯࢲ", <Module>.波儿埃儿波()), <Module>.ZExtO("뮤뮈뮑뮪뮅뮆뮊뮂뮺뮙뮌뮌뮍", <Module>.大留波留埃()));
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00017990 File Offset: 0x00015B90
		private static string BiosId()
		{
			string[] array = new string[<Module>.艾留斯波留()];
			array[<Module>.留波留艾大()] = Form1.Identifier(<Module>.ZExtO("ฃ฽ฺ๧๦ซถฝปง", <Module>.儿儿埃波波()), <Module>.ZExtO("喣喏喀喛喈喏喍喚喛喜喋喜", <Module>.艾斯波斯艾()));
			array[<Module>.埃斯豆留斯()] = Form1.Identifier(<Module>.ZExtO("\uda3c\uda02\uda05\uda58\uda59\uda34\uda29\uda22\uda24\uda38", <Module>.儿儿豆大留()), <Module>.ZExtO("곿곡곮곥곣곿곮곥곣곿곺곉곞곟곅곃곂", <Module>.艾艾大艾埃()));
			array[<Module>.留埃艾大留()] = Form1.Identifier(<Module>.ZExtO("\udca7\udc99\udc9e\udcc3\udcc2\udcaf\udcb2\udcb9\udcbf\udca3", <Module>.大豆留留斯()), <Module>.ZExtO("ꢹꢔꢕꢞꢄꢙꢖꢙꢓꢑꢄꢙꢟꢞꢳꢟꢔꢕ", <Module>.埃儿斯斯留()));
			array[<Module>.克克留豆豆()] = Form1.Identifier(<Module>.ZExtO("複褹褾襣襢褏褒褙褟褃", <Module>.大留波斯波()), <Module>.ZExtO("侴侂侕侎來例侩侒侊侅侂侕", <Module>.斯留艾儿儿()));
			array[<Module>.克大留波艾()] = Form1.Identifier(<Module>.ZExtO("㛟㛡㛦㚻㚺㛗㛊㛁㛇㛛", <Module>.留艾埃波斯()), <Module>.ZExtO("励劆劏劆劂劐劆劧劂劗劆", <Module>.埃波留艾斯()));
			array[<Module>.埃波儿波波()] = Form1.Identifier(<Module>.ZExtO("⋺⋄⋃⊞⊟⋲⋯⋤⋢⋾", <Module>.留埃波艾儿()), <Module>.ZExtO("䫕䫦䫱䫰䫪䫬䫭", <Module>.大艾波艾艾()));
			return string.Concat(array);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00017AA8 File Offset: 0x00015CA8
		private static string DiskId()
		{
			return Form1.Identifier(<Module>.ZExtO("뗯뗑뗖떋떊뗧뗼뗑뗋뗓뗼뗊뗑뗎뗝", <Module>.留波波波克()), <Module>.ZExtO("✚✸✳✲✻", <Module>.儿斯留儿大())) + Form1.Identifier(<Module>.ZExtO("ﳟﳡﳦﲻﲺﳗﳌﳡﳻﳣﳌﳺﳡﳾﳭ", <Module>.留埃克儿豆()), <Module>.ZExtO("", <Module>.留埃留埃波())) + Form1.Identifier(<Module>.ZExtO("ℚℤ℣ⅾⅿℒ℉ℤℾΩ℉ℿℤ℻ℨ", <Module>.波斯克豆斯()), <Module>.ZExtO("⠪⠐⠞⠗⠘⠍⠌⠋⠜", <Module>.克豆留埃斯())) + Form1.Identifier(<Module>.ZExtO("\udb9f\udba1\udba6\udbfb\udbfa\udb97\udb8c\udba1\udbbb\udba3\udb8c\udbba\udba1\udbbe\udbad", <Module>.留斯留波波()), <Module>.ZExtO("즨즓즈증즐즴즙증즘즏", <Module>.儿埃儿留留()));
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00017B48 File Offset: 0x00015D48
		private static string BaseId()
		{
			return Form1.Identifier(<Module>.ZExtO("ԤԚԝՀՁԬԱԒԀԖԱԜԒԁԗ", <Module>.留留豆克大()), <Module>.ZExtO("", <Module>.波留波艾斯())) + Form1.Identifier(<Module>.ZExtO("ᲣᲝᲚ᳇᳆ᲫᲶᲕᲇᲑᲶᲛᲕᲆᲐ", <Module>.斯波波留波()), <Module>.ZExtO("ꐥꐉꐆꐝꐎꐉꐋꐜꐝꐚꐍꐚ", <Module>.大大留艾埃())) + Form1.Identifier(<Module>.ZExtO("ܾ܀܇ݚݛܶܫ܈ܚ܌ܫ܆܈ܛ܍", <Module>.波大波留留()), <Module>.ZExtO("捤捋捇捏", <Module>.大艾大留斯())) + Form1.Identifier(<Module>.ZExtO("ꎘꎦꎡꏼꏽꎐꎍꎮꎼꎪꎍꎠꎮꎽꎫ", <Module>.留波大留留()), <Module>.ZExtO("", <Module>.留斯豆艾波()));
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00017BE8 File Offset: 0x00015DE8
		private static string VideoId()
		{
			return Form1.Identifier(<Module>.ZExtO("꫺꫄꫃ꪞꪟꫲ꫻꫄꫉꫈ꫂꫮꫂ꫃꫙꫟ꫂ꫁꫁꫈꫟", <Module>.斯克大留豆()), <Module>.ZExtO("চবষন঻বঈ঻বভষ঱র", <Module>.埃波艾豆留())) + Form1.Identifier(<Module>.ZExtO("ꋭꋓꋔꊉꊈꋥꋬꋓꋞꋟꋕꋹꋕꋔꋎꋈꋕꋖꋖꋟꋈ", <Module>.波克埃波波()), <Module>.ZExtO("ﺖﺹﺵﺽ", <Module>.艾留留艾埃()));
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x000024D4 File Offset: 0x000006D4
		private static string MacId()
		{
			return Form1.Identifier(<Module>.ZExtO("淲淌淋涖涗淺淫淀淑淒淊淗淎淤淁淄淕淑淀淗淦淊淋淃淌淂淐淗淄淑淌淊淋", <Module>.留艾留波儿()), <Module>.ZExtO("ꌃꌏꌍꌏꌪꌪꌼꌫꌽꌽ", <Module>.留留留豆豆()), <Module>.ZExtO("偩偰健偎偁偂偌偅偄", <Module>.埃大斯留留()));
		}

		// Token: 0x04000004 RID: 4
		public System.Timers.Timer time;

		// Token: 0x04000005 RID: 5
		public DataTable btc_balance;

		// Token: 0x04000006 RID: 6
		public DataTable adr_seed;

		// Token: 0x04000007 RID: 7
		public HashSet<string> mnemonics = new HashSet<string>();

		// Token: 0x04000008 RID: 8
		private Form1.Props props = new Form1.Props();

		// Token: 0x04000009 RID: 9
		public List<string> adrs = new List<string>();

		// Token: 0x0400000A RID: 10
		public object locks;

		// Token: 0x0400000B RID: 11
		public bool btc;

		// Token: 0x0400000C RID: 12
		public bool ltc;

		// Token: 0x0400000D RID: 13
		public bool dash;

		// Token: 0x0400000E RID: 14
		public bool bch;

		// Token: 0x0400000F RID: 15
		public bool eth;

		// Token: 0x04000010 RID: 16
		public bool bsc;

		// Token: 0x04000011 RID: 17
		public bool ftm;

		// Token: 0x04000012 RID: 18
		public bool ht;

		// Token: 0x04000013 RID: 19
		public bool polygon;

		// Token: 0x04000014 RID: 20
		public bool arbitrum;

		// Token: 0x04000015 RID: 21
		public bool optimeth;

		// Token: 0x04000016 RID: 22
		public bool movr;

		// Token: 0x04000017 RID: 23
		public bool snowtrace;

		// Token: 0x04000018 RID: 24
		public bool ronint;

		// Token: 0x04000019 RID: 25
		public object firstCell;

		// Token: 0x0400001A RID: 26
		public int bad_mnem;

		// Token: 0x0400001B RID: 27
		public decimal fbalance_btc;

		// Token: 0x0400001C RID: 28
		public decimal fbalance_ltc;

		// Token: 0x0400001D RID: 29
		public decimal fbalance_bch;

		// Token: 0x0400001E RID: 30
		public decimal fbalance_dash;

		// Token: 0x0400001F RID: 31
		public decimal fbalance_eth;

		// Token: 0x04000020 RID: 32
		public decimal fbalance_bsc;

		// Token: 0x04000021 RID: 33
		public decimal fbalance_ftm;

		// Token: 0x04000022 RID: 34
		public decimal fbalance_ht;

		// Token: 0x04000023 RID: 35
		public decimal fbalance_matic;

		// Token: 0x04000024 RID: 36
		public decimal fbalance_oteth;

		// Token: 0x04000025 RID: 37
		public decimal fbalance_arbiscan;

		// Token: 0x04000026 RID: 38
		public decimal fbalance_moonriver;

		// Token: 0x04000027 RID: 39
		public decimal fbalance_snowtrace;

		// Token: 0x04000028 RID: 40
		public decimal fbalance_ronin;

		// Token: 0x04000029 RID: 41
		public decimal fbalance_axie;

		// Token: 0x0400002A RID: 42
		public decimal ftoken_erc;

		// Token: 0x0400002B RID: 43
		public decimal ftoken_bsc;

		// Token: 0x0400002C RID: 44
		public decimal ftoken_ftm;

		// Token: 0x0400002D RID: 45
		public decimal ftoken_ht;

		// Token: 0x0400002E RID: 46
		public decimal ftoken_polygon;

		// Token: 0x0400002F RID: 47
		public decimal ftoken_oteth;

		// Token: 0x04000030 RID: 48
		public decimal ftoken_arbiscan;

		// Token: 0x04000031 RID: 49
		public decimal ftoken_moonriver;

		// Token: 0x04000032 RID: 50
		public decimal ftoken_snowtrace;

		// Token: 0x04000033 RID: 51
		public decimal ftoken_ronin;

		// Token: 0x04000034 RID: 52
		public string api_bot = "";

		// Token: 0x04000035 RID: 53
		public string Chat_id = "";

		// Token: 0x04000036 RID: 54
		public bool seedcheck;

		// Token: 0x04000037 RID: 55
		public bool privkeycheck;

		// Token: 0x04000038 RID: 56
		private static string _fingerPrint = string.Empty;

		// Token: 0x02000005 RID: 5
		public class PropsFields
		{
			// Token: 0x0400008B RID: 139
			public string XMLFileName = Environment.CurrentDirectory + <Module>.ZExtO("寣富寚寋寋寖寑寘富宑寇寒寓", <Module>.斯波豆埃艾());

			// Token: 0x0400008C RID: 140
			public string LoadFile = "";

			// Token: 0x0400008D RID: 141
			public string bot_api = "";

			// Token: 0x0400008E RID: 142
			public string chatid = "";

			// Token: 0x0400008F RID: 143
			public decimal bbtc;

			// Token: 0x04000090 RID: 144
			public decimal bltc;

			// Token: 0x04000091 RID: 145
			public decimal bbch;

			// Token: 0x04000092 RID: 146
			public decimal bdash;

			// Token: 0x04000093 RID: 147
			public decimal beth;

			// Token: 0x04000094 RID: 148
			public decimal bbsc;

			// Token: 0x04000095 RID: 149
			public decimal bftm;

			// Token: 0x04000096 RID: 150
			public decimal bht;

			// Token: 0x04000097 RID: 151
			public decimal bsnow;

			// Token: 0x04000098 RID: 152
			public decimal barb;

			// Token: 0x04000099 RID: 153
			public decimal bronin;

			// Token: 0x0400009A RID: 154
			public decimal bmatic;

			// Token: 0x0400009B RID: 155
			public decimal boptimistic;

			// Token: 0x0400009C RID: 156
			public decimal bmovr;

			// Token: 0x0400009D RID: 157
			public decimal baxie;

			// Token: 0x0400009E RID: 158
			public decimal teth;

			// Token: 0x0400009F RID: 159
			public decimal tbsc;

			// Token: 0x040000A0 RID: 160
			public decimal tftm;

			// Token: 0x040000A1 RID: 161
			public decimal tht;

			// Token: 0x040000A2 RID: 162
			public decimal tsnow;

			// Token: 0x040000A3 RID: 163
			public decimal tarb;

			// Token: 0x040000A4 RID: 164
			public decimal tronin;

			// Token: 0x040000A5 RID: 165
			public decimal tpolygon;

			// Token: 0x040000A6 RID: 166
			public decimal tmovr;

			// Token: 0x040000A7 RID: 167
			public decimal toptimistic;

			// Token: 0x040000A8 RID: 168
			public decimal addresses_seed;

			// Token: 0x040000A9 RID: 169
			public decimal time_out_check;

			// Token: 0x040000AA RID: 170
			public bool seed;

			// Token: 0x040000AB RID: 171
			public bool pk;

			// Token: 0x040000AC RID: 172
			public bool btc;

			// Token: 0x040000AD RID: 173
			public bool ltc;

			// Token: 0x040000AE RID: 174
			public bool bch;

			// Token: 0x040000AF RID: 175
			public bool dash;

			// Token: 0x040000B0 RID: 176
			public bool eth;

			// Token: 0x040000B1 RID: 177
			public bool bsc;

			// Token: 0x040000B2 RID: 178
			public bool ftm;

			// Token: 0x040000B3 RID: 179
			public bool ht;

			// Token: 0x040000B4 RID: 180
			public bool matic;

			// Token: 0x040000B5 RID: 181
			public bool arbiscan;

			// Token: 0x040000B6 RID: 182
			public bool optimistic;

			// Token: 0x040000B7 RID: 183
			public bool movr;

			// Token: 0x040000B8 RID: 184
			public bool snowtrace;

			// Token: 0x040000B9 RID: 185
			public bool ronin;
		}

		// Token: 0x02000006 RID: 6
		public class Props
		{
			// Token: 0x0600089E RID: 2206 RVA: 0x00002614 File Offset: 0x00000814
			public Props()
			{
				this.Fields = new Form1.PropsFields();
			}

			// Token: 0x0600089F RID: 2207 RVA: 0x0001DAFC File Offset: 0x0001BCFC
			public void WriteXml()
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(Form1.PropsFields));
				TextWriter textWriter = new StreamWriter(this.Fields.XMLFileName);
				xmlSerializer.Serialize(textWriter, this.Fields);
				textWriter.Close();
			}

			// Token: 0x060008A0 RID: 2208 RVA: 0x0001DB4C File Offset: 0x0001BD4C
			public void ReadXml()
			{
				if (File.Exists(this.Fields.XMLFileName))
				{
					XmlSerializer xmlSerializer = new XmlSerializer(typeof(Form1.PropsFields));
					TextReader textReader = new StreamReader(this.Fields.XMLFileName);
					this.Fields = (xmlSerializer.Deserialize(textReader) as Form1.PropsFields);
					textReader.Close();
				}
			}

			// Token: 0x040000BA RID: 186
			public Form1.PropsFields Fields;
		}
	}
}
