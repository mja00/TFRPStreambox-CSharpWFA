using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using System.Windows;
using WPFCustomMessageBox;
using System.Net.Sockets;
using TFRPStreambox;

namespace TFRPStreambox_CSharpWFA
{

    public partial class Form1 : Form
    {
        public async static void reopenOptions()
        {
            OptionsBox reopenOptions = new OptionsBox();
            await Task.Delay(200);
            reopenOptions.Show();
        }

        public static string streamercount;
        public static int i;
        public static int bar;
        public static string OAuthToken;

        public Form1()
        {
            InitializeComponent();
            /*_1GUnit1ToolTip.SetToolTip(_1GUnit1, "Character: Jimmy Bean");
            _1GUnit1ToolTip.SetToolTip(AbdulHD, "Character: Abdul ALRahim");
            _1GUnit1ToolTip.SetToolTip(AgentNorth, "Character: Billy Roadstar");
            _1GUnit1ToolTip.SetToolTip(BFLY003, "Characters: Alei Nightingale | Anastacia Ortiz");
            _1GUnit1ToolTip.SetToolTip(AndyMilonakis, "Characters: Herbert Ward | Tameca Nakazawa");
            _1GUnit1ToolTip.SetToolTip(anthonyz_, "Character: Tony Corleone");
            _1GUnit1ToolTip.SetToolTip(BFLY003, "Character: Torah Hart");
            _1GUnit1ToolTip.SetToolTip(boscoreli_gaming, "Character: Mike Boscoreli");*/
            _1GUnit1ToolTip.SetToolTip(BPZ, "Character: Skeeter Fontaine");
            _1GUnit1ToolTip.SetToolTip(BuckkNaked, "Character: Bucky Savage");
            _1GUnit1ToolTip.SetToolTip(BurkeBlack, "Characters: Big Momma | Walter Diddlesticks");
            _1GUnit1ToolTip.SetToolTip(Ch1ckenb0ne, "Characters: Angel Blaze | Randall Cage | Tiberius Kingston");
            _1GUnit1ToolTip.SetToolTip(ChiefDas, "Character: Baada Ka");
            _1GUnit1ToolTip.SetToolTip(ClassyPax, "Characters: Deuce Montgomery | Francis Sinclair | Gordie Whitman | Hobo Harry | Lenny Wright | Madam Ming | Richard Oakes");
            _1GUnit1ToolTip.SetToolTip(CletusBueford, "Characters: Cletus Bueford | Cooter Beuford");
            _1GUnit1ToolTip.SetToolTip(CoolidgeHD, "Characters: Bob Coolidge | Frank Murdock | Willy Jett");
            _1GUnit1ToolTip.SetToolTip(dasMehdi, "Character: Nino Chavez");
            _1GUnit1ToolTip.SetToolTip(DisbeArex, "Character: Fanny Pudding");
            _1GUnit1ToolTip.SetToolTip(djkwix, "Character: Candy Moist");
            _1GUnit1ToolTip.SetToolTip(DrunkBabyYoshi, "Characters: Grant Mchenry | Merle Mchenry");
            _1GUnit1ToolTip.SetToolTip(Esoluu, "Character: Aaron Smooth");
            _1GUnit1ToolTip.SetToolTip(Finkone, "Characters: Jason Doyle | Peanut Butter");
            _1GUnit1ToolTip.SetToolTip(FistofTheWalrus, "Characters: Al Timers | Fabio Magnifico | Lazarus West");
            _1GUnit1ToolTip.SetToolTip(Five0AnthO, "Character: Tony Andrews");
            _1GUnit1ToolTip.SetToolTip(GeeFamous92, "Character: Garrett Famous");
            _1GUnit1ToolTip.SetToolTip(GhilleGuyTV, "Characters: Dannie Slater | Duke Mason | Mickey Pikey");
            _1GUnit1ToolTip.SetToolTip(GiantFaffle, "Character: Felix Marks");
            _1GUnit1ToolTip.SetToolTip(GloryD, "Characters: Dequan Mathis | Keaf Strong");
            _1GUnit1ToolTip.SetToolTip(Harryow, "Character: Harry Brown");
            _1GUnit1ToolTip.SetToolTip(Hazard, "Character: Mav Doretto");
            _1GUnit1ToolTip.SetToolTip(Hirona, "Characters: Alexis Freeman | Debbie Murdock");
            _1GUnit1ToolTip.SetToolTip(IAmSp00n, "Character: Flint Wilson");
            _1GUnit1ToolTip.SetToolTip(ImmortalLive, "Characters: Johnny Davidson | Ryan Dewitt");
            _1GUnit1ToolTip.SetToolTip(ironmonkeytv, "Characters: Bobby Goodman | Jason Freeman");
            _1GUnit1ToolTip.SetToolTip(itzButch, "Character: Sam Butcher");
            _1GUnit1ToolTip.SetToolTip(J_Reed, "Characters: Byrone Tiggum | Jack Reed");
            _1GUnit1ToolTip.SetToolTip(JaboodyShow, "Characters: Chang Wei | Jerry Curl");
            _1GUnit1ToolTip.SetToolTip(jake_terek, "Characters: Charles Deacon | Lance Amadeus | Michelle Townsend | Ray Thomas");
            _1GUnit1ToolTip.SetToolTip(JmxTwiztid, "Character: Jason Diggs");
            _1GUnit1ToolTip.SetToolTip(John782, "Characters: David Thomas | John Thomas");
            _1GUnit1ToolTip.SetToolTip(Jolly__Jess, "Characters: Bambi Carter | Frankie Walker");
            _1GUnit1ToolTip.SetToolTip(JTtroy, "Character: Kal Clark");
            _1GUnit1ToolTip.SetToolTip(kaceytron, "Character: Ruth Winfrey");
            _1GUnit1ToolTip.SetToolTip(KaptainKpress, "Character: Darrelle Baitor");
            _1GUnit1ToolTip.SetToolTip(KatieRouu, "Characters: Alice Novoa | Amanda Covert | Keira Webb | Lily Baker");
            _1GUnit1ToolTip.SetToolTip(Kithicor27, "Character: Geoffrey Kregdale");
            _1GUnit1ToolTip.SetToolTip(LarryX7, "Character: Tyrese Tyrone");
            _1GUnit1ToolTip.SetToolTip(lawdog1096, "Character: Johnathan Murdock");
            _1GUnit1ToolTip.SetToolTip(LiftYourGame, "Characters: Chuck Pickles | Lutrell Skinner");
            _1GUnit1ToolTip.SetToolTip(loveANF3L, "Character: Angel McKenzie");
            _1GUnit1ToolTip.SetToolTip(mart1n_g, "Characters: John Mason | Louis Bloom | Pat Clifton | Tommy-Lee Wyatt");
            _1GUnit1ToolTip.SetToolTip(MiltonTPike1, "Characters: Alice Malone | Bernice Jacques | Daniel Ding | Doug Brewster | Gloria Munroe | Kiki Chanel | William Ding");
            _1GUnit1ToolTip.SetToolTip(MintsTV, "Characters: Donnie Romano | Trey Preston");
            _1GUnit1ToolTip.SetToolTip(MrMoonsHouse, "Character: Freddy Price");
            _1GUnit1ToolTip.SetToolTip(MsDeathRabbit, "Character: Vivien Lake");
            _1GUnit1ToolTip.SetToolTip(Og_BluePill, "Characters: George Thurgood | Johnny Thurgood | Momma Jones | Taiwon Jones");
            _1GUnit1ToolTip.SetToolTip(PENTAhearth, "Characters: Bernie Sandusky | Bershawnda Jackson | Jack Jackson | John Shoemaker | Rachael Sandusky | Robert Right | Victor Bigglesworth");
            _1GUnit1ToolTip.SetToolTip(Pinky, "Characters: Mae Gusta | Veronica Neptune");
            _1GUnit1ToolTip.SetToolTip(PmsProxy, "Characters: Ella Stone | Katie Rage");
            _1GUnit1ToolTip.SetToolTip(PorkMarshmallow, "Characters: Abe Allsack | Herb Allsack");
            _1GUnit1ToolTip.SetToolTip(PrimusPalus, "Characters: John Shields | Sal Eisenberg");
            _1GUnit1ToolTip.SetToolTip(Purrluna, "Character: Kitty Cox");
            _1GUnit1ToolTip.SetToolTip(Pydrex, "Character: James Doakes");
            _1GUnit1ToolTip.SetToolTip(RajjPatel, "Character: Rajj Patel");
            _1GUnit1ToolTip.SetToolTip(Rastafied, "Character: Milly Bays");
            _1GUnit1ToolTip.SetToolTip(RastaRafikii, "Character: Dean Dimes");
            _1GUnit1ToolTip.SetToolTip(SAMZHIT, "Characters: Dimitri Barkov | Earl Higgs | John Hill");
            _1GUnit1ToolTip.SetToolTip(Sarapocalypse, "Characters: Jessie Jones | Spencer Rhodes");
            _1GUnit1ToolTip.SetToolTip(SayeedBlack, "Character: Sayeed White");
            _1GUnit1ToolTip.SetToolTip(SeanKingV, "Character: Gerald Choppins");
            _1GUnit1ToolTip.SetToolTip(Selvek, "Character: Jeffrey Connors");
            _1GUnit1ToolTip.SetToolTip(ShaZ, "Character: Buc Lauo");
            _1GUnit1ToolTip.SetToolTip(SheepDog59, "Character: Adam Stone");
            _1GUnit1ToolTip.SetToolTip(SheriffEli, "Characters: Duke | Eli Thompson | Scott McCloud");
            _1GUnit1ToolTip.SetToolTip(SHPTV, "Character: Bruce Greenwell");
            _1GUnit1ToolTip.SetToolTip(SilentSentry, "Character: Clarence Williams");
            _1GUnit1ToolTip.SetToolTip(SimplyJulian, "Character: Julian Santorno");
            _1GUnit1ToolTip.SetToolTip(SirCoffeestain, "Characters: Roger Steel | Samuel Walken");
            _1GUnit1ToolTip.SetToolTip(SirPinkleton00, "Character: Reginald Bigglesby");
            _1GUnit1ToolTip.SetToolTip(SkipGently, "Character: Jack Deakins");
            _1GUnit1ToolTip.SetToolTip(SomeTexas_Dude, "Character: Nolan Ryan");
            _1GUnit1ToolTip.SetToolTip(Ssaab, "Character: Al Saab");
            // _1GUnit1ToolTip.SetToolTip(TastyTV, "Characters: Bobby Irvine | Harold Wilson | Norman Wilson | Patrick Flanegan | William Parker");
            _1GUnit1ToolTip.SetToolTip(Thadrius, "Characters: Brayben Dazzler | Johnny Dazzler | Slappy McGaffey");
            _1GUnit1ToolTip.SetToolTip(TheBuddha3, "Characters: Lang Buddha | Tyrone Jones");
            _1GUnit1ToolTip.SetToolTip(thelawmangaming, "Character: Robert Beck");
            _1GUnit1ToolTip.SetToolTip(TheRealSpectral, "Character: Tony Caprioni");
            _1GUnit1ToolTip.SetToolTip(TigerWriter, "Character: Juan Goodman");
            _1GUnit1ToolTip.SetToolTip(Timmac, "Characters: Shaggy Dankweed | Timmy Macapone");
            _1GUnit1ToolTip.SetToolTip(TVSBOH, "Characters: Chester Heartsong | Tommy Silver");
            _1GUnit1ToolTip.SetToolTip(UndeadBaron, "Character: Yazumitsu Fujikawa");
            _1GUnit1ToolTip.SetToolTip(ValkyrieSpirit, "Characters: Bianca Ellis | Stella Bouche");
            _1GUnit1ToolTip.SetToolTip(Will_ko, "Character: Edward Payne");
            _1GUnit1ToolTip.SetToolTip(willitkimchi, "Characters: Lee Kimchi | Will Kimchi");
            _1GUnit1ToolTip.SetToolTip(Wish, "Characters: Avery Jenkins | Miranda Wrights | Willow Nova");
            _1GUnit1ToolTip.SetToolTip(X_xZimx_X, "Character: Zim Pontes");
            _1GUnit1ToolTip.SetToolTip(Xiceman, "Characters: Mike Bayo | Rusty Dawns");
            _1GUnit1ToolTip.SetToolTip(XProph3cyx, "Character: Ichiro Suyaki");
            _1GUnit1ToolTip.SetToolTip(Zaquelle, "Characters: Amanda Williams | Emma Moore | Zoey Lyrais");
            _1GUnit1ToolTip.SetToolTip(Mythematic, "Characters: Harhiko Oshima | Jack Wolfe | Mike RosoftSam");
            _1GUnit1ToolTip.SetToolTip(SaffyPie101, "Characters: Holly Frost | Lily Murdock");
            AutoUpdater.Start("http://kivl.playat.ch/tfrpupdate.xml");
            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.ShowRemindLaterButton = false;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            var versionInfo = System.Windows.Forms.Application.ProductVersion;
            this.Text = "The FamilyRP Streambox v" + versionInfo;
            if (TFRPStreambox.Properties.Settings.Default.OAuth == "CHANGEME")
            {
                OAuthPrompt oauthprompt = new OAuthPrompt();

                oauthprompt.ShowDialog(this);
            }
            WebRequest request = WebRequest.Create(@"https://api.twitch.tv/kraken/base?client_id=xskte44y2wfqin464ayecyc09nikcj");
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                refreshBackgroundWorker.RunWorkerAsync();
                refreshButton.Text = "Refreshing";
                refreshButton.Enabled = false;
            }
            catch (WebException)
            {
                MessageBoxResult result = CustomMessageBox.ShowOKCancel(
                "Twitch API seems to be down! This program wont work!",
                "Uh oh",
                "Ok",
                "Cancel");
                if (result == MessageBoxResult.OK)
                {
                    this.Close();
                }
            }
            WebClient client = new WebClient();
            client.Headers.Add("Client-ID", OAuthToken);

        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //   AutoUpdater.Start("http://kivl.playat.ch/tfrpupdate.xml");
        //}



        public static string streamer;

        public static void displayStream()
        {

            MessageBoxResult result = CustomMessageBox.ShowYesNoCancel(
                "Which type of stream would you like open?",
                "Choose stream type",
                "VLC + Chat",
                "Twitch Redirect",
                "Just VLC");
            if (result == MessageBoxResult.Yes)
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                cmd.StartInfo.Arguments = "/C data\\Streamlink.exe --player=" + "\"" + TFRPStreambox.Properties.Settings.Default.VLCLocation + "\" " + "http://twitch.tv/" + streamer + " best --twitch-disable-hosting";
                cmd.Start();
                Process.Start("https://twitch.tv/" + streamer + "/chat");
            }
            else if (result == MessageBoxResult.No)
            {
                Process.Start("https://twitch.tv/" + streamer);
            }
            else if (result == MessageBoxResult.Cancel)
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                cmd.StartInfo.Arguments = "/C data\\Streamlink.exe --player=" + "\"" + TFRPStreambox.Properties.Settings.Default.VLCLocation + "\" " + "http://twitch.tv/" + streamer + " best --twitch-disable-hosting";
                cmd.Start();
            }
        }
        private async void _1GUnit1_Click(object sender, EventArgs e)
        {
            _1GUnit1.Text = "Loading";
            Form1.streamer = "1GUnit1";
            Form1.displayStream();
            await Task.Delay(10000);
            _1GUnit1.Text = "1GUnit1";
        }

        private async void AbdulHD_Click(object sender, EventArgs e)
        {
            AbdulHD.Text = "Loading";
            Form1.streamer = "Abdulhd";
            Form1.displayStream();
            await Task.Delay(10000);
            AbdulHD.Text = "AbdulHD";
        }

        private async void AgentNorth_Click(object sender, EventArgs e)
        {
            AgentNorth.Text = "Loading";
            Form1.streamer = "agentnorth";
            Form1.displayStream();
            await Task.Delay(10000);
            AgentNorth.Text = "AgentNorth";
        }

        private async void alexusnightingale_Click(object sender, EventArgs e)
        {
            alexusnightingale.Text = "Loading";
            Form1.streamer = "alexusnightingale";
            Form1.displayStream();
            await Task.Delay(10000);
            alexusnightingale.Text = "alexusnightinga";
        }

        private async void AndyMilonakis_Click(object sender, EventArgs e)
        {
            AndyMilonakis.Text = "Loading";
            Form1.streamer = "andymilonakis";
            Form1.displayStream();
            await Task.Delay(10000);
            AndyMilonakis.Text = "AndyMilonakis";
        }

        private async void anthonyz__Click(object sender, EventArgs e)
        {
            anthonyz_.Text = "Loading";
            Form1.streamer = "anthonyz_";
            Form1.displayStream();
            await Task.Delay(10000);
            anthonyz_.Text = "anthonyz_";
        }

        private async void BFLY003_Click(object sender, EventArgs e)
        {
            BFLY003.Text = "Loading";
            Form1.streamer = "bfly003";
            Form1.displayStream();
            await Task.Delay(10000);
            BFLY003.Text = "BFLY003";
        }

        private async void boscoreli_gaming_Click(object sender, EventArgs e)
        {
            boscoreli_gaming.Text = "Loading";
            Form1.streamer = "boscoreli_gaming";
            Form1.displayStream();
            await Task.Delay(10000);
            boscoreli_gaming.Text = "boscoreli";
        }

        private async void BPZ_Click(object sender, EventArgs e)
        {
            BPZ.Text = "Loading";
            Form1.streamer = "bpz";
            Form1.displayStream();
            await Task.Delay(10000);
            BPZ.Text = "bpz";
        }

        private async void BuckkNaked_Click(object sender, EventArgs e)
        {
            BuckkNaked.Text = "Loading";
            Form1.streamer = "buckknaked";
            Form1.displayStream();
            await Task.Delay(10000);
            BuckkNaked.Text = "BuckkNaked";
        }

        private async void BurkeBlack_Click(object sender, EventArgs e)
        {
            BurkeBlack.Text = "Loading";
            Form1.streamer = "burkeblack";
            Form1.displayStream();
            await Task.Delay(10000);
            BurkeBlack.Text = "BurkeBlack";
        }

        private async void Ch1ckenb0ne_Click(object sender, EventArgs e)
        {
            Ch1ckenb0ne.Text = "Loading";
            Form1.streamer = "ch1ckenb0ne";
            Form1.displayStream();
            await Task.Delay(10000);
            Ch1ckenb0ne.Text = "Ch1ckenb0ne";
        }

        private async void ChiefDas_Click(object sender, EventArgs e)
        {
            ChiefDas.Text = "Loading";
            Form1.streamer = "chiefdas";
            Form1.displayStream();
            await Task.Delay(10000);
            ChiefDas.Text = "ChiefDas";
        }

        private async void ClassyPax_Click(object sender, EventArgs e)
        {
            ClassyPax.Text = "Loading";
            Form1.streamer = "classypax";
            Form1.displayStream();
            await Task.Delay(10000);
            ClassyPax.Text = "ClassyPax";
        }

        private async void CletusBeuford_Click(object sender, EventArgs e)
        {
            CletusBueford.Text = "Loading";
            Form1.streamer = "cletusbeuford";
            Form1.displayStream();
            await Task.Delay(10000);
            CletusBueford.Text = "CletusBeuford";
        }

        private async void CoolidgeHD_Click(object sender, EventArgs e)
        {
            CoolidgeHD.Text = "Loading";
            Form1.streamer = "coolidgehd";
            Form1.displayStream();
            await Task.Delay(10000);
            CoolidgeHD.Text = "CoolidgeHD";
        }

        private async void dasMehdi_Click(object sender, EventArgs e)
        {
            dasMehdi.Text = "Loading";
            Form1.streamer = "dasmehdi";
            Form1.displayStream();
            await Task.Delay(10000);
            dasMehdi.Text = "dasMehdi";
        }

        private async void DisbeArex_Click(object sender, EventArgs e)
        {
            DisbeArex.Text = "Loading";
            Form1.streamer = "disbearex";
            Form1.displayStream();
            await Task.Delay(10000);
            DisbeArex.Text = "DisbeArex";
        }

        private async void djkwix_Click(object sender, EventArgs e)
        {
            djkwix.Text = "Loading";
            Form1.streamer = "djkwix";
            Form1.displayStream();
            await Task.Delay(10000);
            djkwix.Text = "djkwix";
        }

        private async void DrunkBabyYoshi_Click(object sender, EventArgs e)
        {
            DrunkBabyYoshi.Text = "Loading";
            Form1.streamer = "drunkbabyyoshi";
            Form1.displayStream();
            await Task.Delay(10000);
            DrunkBabyYoshi.Text = "DrunkBabyYo";
        }

        private async void Esoluu_Click(object sender, EventArgs e)
        {
            Esoluu.Text = "Loading";
            Form1.streamer = "esoluu";
            Form1.displayStream();
            await Task.Delay(10000);
            Esoluu.Text = "Esoluu";
        }

        private async void FinKone_Click(object sender, EventArgs e)
        {
            Finkone.Text = "Loading";
            Form1.streamer = "finkone";
            Form1.displayStream();
            await Task.Delay(10000);
            Finkone.Text = "FinKone";
        }

        private async void FistOfTheWalrus_Click(object sender, EventArgs e)
        {
            FistofTheWalrus.Text = "Loading";
            Form1.streamer = "fistofthewalrus";
            Form1.displayStream();
            await Task.Delay(10000);
            FistofTheWalrus.Text = "FistOfTheWalrus";
        }

        private async void Five0AnthO_Click(object sender, EventArgs e)
        {
            Five0AnthO.Text = "Loading";
            Form1.streamer = "five0anth0";
            Form1.displayStream();
            await Task.Delay(10000);
            Five0AnthO.Text = "Five0AnthO";
        }

        private async void GeeFamous92_Click(object sender, EventArgs e)
        {
            GeeFamous92.Text = "Loading";
            Form1.streamer = "geefamous92";
            Form1.displayStream();
            await Task.Delay(10000);
            GeeFamous92.Text = "GeeFamous92";
        }

        private async void GhilleGuyTV_Click(object sender, EventArgs e)
        {
            GhilleGuyTV.Text = "Loading";
            Form1.streamer = "ghilleguytv";
            Form1.displayStream();
            await Task.Delay(10000);
            GhilleGuyTV.Text = "GhilleGuyTV";
        }

        private async void GiantFaffle_Click(object sender, EventArgs e)
        {
            GiantFaffle.Text = "Loading";
            Form1.streamer = "giantfaffle";
            Form1.displayStream();
            await Task.Delay(10000);
            GiantFaffle.Text = "GiantFaffle";
        }

        private async void GloryD_Click(object sender, EventArgs e)
        {
            GloryD.Text = "Loading";
            Form1.streamer = "gloryd";
            Form1.displayStream();
            await Task.Delay(10000);
            GloryD.Text = "GloryD";
        }

        private async void Harryow_Click(object sender, EventArgs e)
        {
            Harryow.Text = "Loading";
            Form1.streamer = "harryow";
            Form1.displayStream();
            await Task.Delay(10000);
            Harryow.Text = "Harryow";
        }

        private async void Hazard_Click(object sender, EventArgs e)
        {
            Hazard.Text = "Loading";
            Form1.streamer = "hazard";
            Form1.displayStream();
            await Task.Delay(10000);
            Hazard.Text = "Hazard";
        }

        private async void Hirona_Click(object sender, EventArgs e)
        {
            Hirona.Text = "Loading";
            Form1.streamer = "hirona";
            Form1.displayStream();
            await Task.Delay(10000);
            Hirona.Text = "Hirona";
        }

        private async void IAmSp00n_Click(object sender, EventArgs e)
        {
            IAmSp00n.Text = "Loading";
            Form1.streamer = "iamsp00n";
            Form1.displayStream();
            await Task.Delay(10000);
            IAmSp00n.Text = "IAmSp00n";
        }

        private async void ImmortalLive_Click(object sender, EventArgs e)
        {
            ImmortalLive.Text = "Loading";
            Form1.streamer = "immortallive";
            Form1.displayStream();
            await Task.Delay(10000);
            ImmortalLive.Text = "ImmortalLive";
        }

        private async void ironmonkeytv_Click(object sender, EventArgs e)
        {
            ironmonkeytv.Text = "Loading";
            Form1.streamer = "ironmonkeytv";
            Form1.displayStream();
            await Task.Delay(10000);
            ironmonkeytv.Text = "IronMonkeyTV";
        }

        private async void itzButch_Click(object sender, EventArgs e)
        {
            itzButch.Text = "Loading";
            Form1.streamer = "itzbutch";
            Form1.displayStream();
            await Task.Delay(10000);
            itzButch.Text = "itzButch";
        }

        private async void J_Reed_Click(object sender, EventArgs e)
        {
            J_Reed.Text = "Loading";
            Form1.streamer = "j_reed";
            Form1.displayStream();
            await Task.Delay(10000);
            J_Reed.Text = "J_Reed";
        }

        private async void JaboodyShow_Click(object sender, EventArgs e)
        {
            JaboodyShow.Text = "Loading";
            Form1.streamer = "jaboodyshow";
            Form1.displayStream();
            await Task.Delay(10000);
            JaboodyShow.Text = "JaboodyShow";
        }

        private async void jake_terek_Click(object sender, EventArgs e)
        {
            jake_terek.Text = "Loading";
            Form1.streamer = "jake_terek";
            Form1.displayStream();
            await Task.Delay(10000);
            jake_terek.Text = "Jake_Terek";
        }

        private async void JmxTwiztid_Click(object sender, EventArgs e)
        {
            JmxTwiztid.Text = "Loading";
            Form1.streamer = "jmxtwiztid";
            Form1.displayStream();
            await Task.Delay(10000);
            JmxTwiztid.Text = "JmxTwiztid";
        }

        private async void John782_Click(object sender, EventArgs e)
        {
            John782.Text = "Loading";
            Form1.streamer = "john782";
            Form1.displayStream();
            await Task.Delay(10000);
            John782.Text = "John782";
        }

        private async void Jolly__Jess_Click(object sender, EventArgs e)
        {
            Jolly__Jess.Text = "Loading";
            Form1.streamer = "Jolly__Jess";
            Form1.displayStream();
            await Task.Delay(10000);
            Jolly__Jess.Text = "Jolly__Jess";
        }

        private async void JTtroy_Click(object sender, EventArgs e)
        {
            JTtroy.Text = "Loading";
            Form1.streamer = "JTtroy";
            Form1.displayStream();
            await Task.Delay(10000);
            JTtroy.Text = "JTtroy";
        }

        private async void kaceytron_Click(object sender, EventArgs e)
        {
            kaceytron.Text = "Loading";
            Form1.streamer = "kaceytron";
            Form1.displayStream();
            await Task.Delay(10000);
            kaceytron.Text = "kaceytron"; ;
        }

        private async void KaptainKpress_Click(object sender, EventArgs e)
        {
            KaptainKpress.Text = "Loading";
            Form1.streamer = "kaptainkpress";
            Form1.displayStream();
            await Task.Delay(10000);
            KaptainKpress.Text = "kaptainkpress";
        }

        private async void KatieRouu_Click(object sender, EventArgs e)
        {
            KatieRouu.Text = "Loading";
            Form1.streamer = "KatieRouu";
            Form1.displayStream();
            await Task.Delay(10000);
            KatieRouu.Text = "KatieRouu";
        }

        private async void Kithicor27_Click(object sender, EventArgs e)
        {
            Kithicor27.Text = "Loading";
            Form1.streamer = "kithicor27";
            Form1.displayStream();
            await Task.Delay(10000);
            Kithicor27.Text = "kithicore27";
        }

        private async void LarryX7_Click(object sender, EventArgs e)
        {
            LarryX7.Text = "Loading";
            Form1.streamer = "larryx7";
            Form1.displayStream();
            await Task.Delay(10000);
            LarryX7.Text = "LarryX7";
        }

        private async void lawdog1096_Click(object sender, EventArgs e)
        {
            lawdog1096.Text = "Loading";
            Form1.streamer = "lawdog1096";
            Form1.displayStream();
            await Task.Delay(10000);
            lawdog1096.Text = "lawdog1096";
        }

        private async void LiftYourGame_Click(object sender, EventArgs e)
        {
            LiftYourGame.Text = "Loading";
            Form1.streamer = "LiftYourGame";
            Form1.displayStream();
            await Task.Delay(10000);
            LiftYourGame.Text = "LiftYourGame";
        }

        private async void loveANF3L_Click(object sender, EventArgs e)
        {
            loveANF3L.Text = "Loading";
            Form1.streamer = "loveANG3L";
            Form1.displayStream();
            await Task.Delay(10000);
            loveANF3L.Text = "loveANG3L";
        }

        private async void mart1n_g_Click(object sender, EventArgs e)
        {
            mart1n_g.Text = "Loading";
            Form1.streamer = "mart1n_g";
            Form1.displayStream();
            await Task.Delay(10000);
            mart1n_g.Text = "mart1n_g";
        }

        private async void MiltonTPike1_Click(object sender, EventArgs e)
        {
            MiltonTPike1.Text = "Loading";
            Form1.streamer = "miltontpike1";
            Form1.displayStream();
            await Task.Delay(10000);
            MiltonTPike1.Text = "MiltonTPike1";
        }

        private async void MintsTV_Click(object sender, EventArgs e)
        {
            MintsTV.Text = "Loading";
            Form1.streamer = "mintstv";
            Form1.displayStream();
            await Task.Delay(10000);
            MintsTV.Text = "MintsTV";
        }

        private async void MrMoonsHouse_Click(object sender, EventArgs e)
        {
            MrMoonsHouse.Text = "Loading";
            Form1.streamer = "mrmoonshouse";
            Form1.displayStream();
            await Task.Delay(10000);
            MrMoonsHouse.Text = "MrMoonsHouse";
        }

        private async void MsDeathRabbit_Click(object sender, EventArgs e)
        {
            MsDeathRabbit.Text = "Loading";
            Form1.streamer = "MsDeathRabbit";
            Form1.displayStream();
            await Task.Delay(10000);
            MsDeathRabbit.Text = "MsDeathRabbit";
        }

        private async void Og_BluePill_Click(object sender, EventArgs e)
        {
            Og_BluePill.Text = "Loading";
            Form1.streamer = "og_bluepill";
            Form1.displayStream();
            await Task.Delay(10000);
            Og_BluePill.Text = "Og_BluePill";
        }

        private async void PENTAhearth_Click(object sender, EventArgs e)
        {
            PENTAhearth.Text = "Loading";
            Form1.streamer = "pentahearth";
            Form1.displayStream();
            await Task.Delay(10000);
            PENTAhearth.Text = "PENTAhearth";
        }

        private async void Pinky_Click(object sender, EventArgs e)
        {
            Pinky.Text = "Loading";
            Form1.streamer = "pinky";
            Form1.displayStream();
            await Task.Delay(10000);
            Pinky.Text = "Pinky";
        }

        private async void PmsProxy_Click(object sender, EventArgs e)
        {
            PmsProxy.Text = "Loading";
            Form1.streamer = "PmsProxy";
            Form1.displayStream();
            await Task.Delay(10000);
            PmsProxy.Text = "PmsProxy";
        }

        private async void PorkMarshmallow_Click(object sender, EventArgs e)
        {
            PorkMarshmallow.Text = "Loading";
            Form1.streamer = "porkmarshmallow";
            Form1.displayStream();
            await Task.Delay(10000);
            PorkMarshmallow.Text = "PorkMarshmallow";
        }

        private async void PrimusPalus_Click(object sender, EventArgs e)
        {
            PrimusPalus.Text = "Loading";
            Form1.streamer = "PrimusPalus";
            Form1.displayStream();
            await Task.Delay(10000);
            PrimusPalus.Text = "PrimusPalus";
        }

        private async void Purrluna_Click(object sender, EventArgs e)
        {
            Purrluna.Text = "Loading";
            Form1.streamer = "Purrluna";
            Form1.displayStream();
            await Task.Delay(10000);
            Purrluna.Text = "Purrluna";
        }

        private async void Pydrex_Click(object sender, EventArgs e)
        {
            Pydrex.Text = "Loading";
            Form1.streamer = "Pydrex";
            Form1.displayStream();
            await Task.Delay(10000);
            Pydrex.Text = "Pydrex";
        }

        private async void RajjPatel_Click(object sender, EventArgs e)
        {
            RajjPatel.Text = "Loading";
            Form1.streamer = "rajjpatel";
            Form1.displayStream();
            await Task.Delay(10000);
            RajjPatel.Text = "RajjPatel";
        }

        private async void Rastafied_Click(object sender, EventArgs e)
        {
            Rastafied.Text = "Loading";
            Form1.streamer = "Rastafied";
            Form1.displayStream();
            await Task.Delay(10000);
            Rastafied.Text = "Rastafied";
        }

        private async void RastaRafikii_Click(object sender, EventArgs e)
        {
            RastaRafikii.Text = "Loading";
            Form1.streamer = "RastaRafikii";
            Form1.displayStream();
            await Task.Delay(10000);
            RastaRafikii.Text = "RastaRafikii";
        }

        private async void SAMZHIT_Click(object sender, EventArgs e)
        {
            SAMZHIT.Text = "Loading";
            Form1.streamer = "SAMZHIT";
            Form1.displayStream();
            await Task.Delay(10000);
            SAMZHIT.Text = "SAMZHIT";
        }

        private async void Sarapocalypse_Click(object sender, EventArgs e)
        {
            Sarapocalypse.Text = "Loading";
            Form1.streamer = "Sarapocalypse";
            Form1.displayStream();
            await Task.Delay(10000);
            Sarapocalypse.Text = "Sarapocalypse";
        }

        private async void SayeedBlack_Click(object sender, EventArgs e)
        {
            SayeedBlack.Text = "Loading";
            Form1.streamer = "Jolly__Jess";
            Form1.displayStream();
            await Task.Delay(10000);
            SayeedBlack.Text = "Jolly__Jess";
        }

        private async void SeanKingV_Click(object sender, EventArgs e)
        {
            SeanKingV.Text = "Loading";
            Form1.streamer = "SeanKingV";
            Form1.displayStream();
            await Task.Delay(10000);
            SeanKingV.Text = "SeanKingV";
        }

        private async void Selvek_Click(object sender, EventArgs e)
        {
            Selvek.Text = "Loading";
            Form1.streamer = "Selvek";
            Form1.displayStream();
            await Task.Delay(10000);
            Selvek.Text = "Selvek";
        }

        private async void ShaZ_Click(object sender, EventArgs e)
        {
            ShaZ.Text = "Loading";
            Form1.streamer = "ShaZ";
            Form1.displayStream();
            await Task.Delay(10000);
            ShaZ.Text = "ShaZ";
        }

        private async void SheriffEli_Click(object sender, EventArgs e)
        {
            SheriffEli.Text = "Loading";
            Form1.streamer = "sheriffeli";
            Form1.displayStream();
            await Task.Delay(10000);
            SheriffEli.Text = "SheriffEli";
        }

        private async void SHPTV_Click(object sender, EventArgs e)
        {
            SHPTV.Text = "Loading";
            Form1.streamer = "SHPTV";
            Form1.displayStream();
            await Task.Delay(10000);
            SHPTV.Text = "SHPTV";
        }

        private async void SilentSentry_Click(object sender, EventArgs e)
        {
            SilentSentry.Text = "Loading";
            Form1.streamer = "SilentSentry";
            Form1.displayStream();
            await Task.Delay(10000);
            SilentSentry.Text = "SilentSentry";
        }

        private async void SimplyJulian_Click(object sender, EventArgs e)
        {
            SimplyJulian.Text = "Loading";
            Form1.streamer = "SimplyJulian";
            Form1.displayStream();
            await Task.Delay(10000);
            SimplyJulian.Text = "SimplyJulian";
        }

        private async void SirCoffeestain_Click(object sender, EventArgs e)
        {
            SirCoffeestain.Text = "Loading";
            Form1.streamer = "SirCoffeestain";
            Form1.displayStream();
            await Task.Delay(10000);
            SirCoffeestain.Text = "SirCoffeestain";
        }

        private async void SirPinkleston00_Click(object sender, EventArgs e)
        {
            SirPinkleton00.Text = "Loading";
            Form1.streamer = "SirPinkleton00";
            Form1.displayStream();
            await Task.Delay(10000);
            SirPinkleton00.Text = "SirPinkleston00";
        }

        private async void SkipGently_Click(object sender, EventArgs e)
        {
            SkipGently.Text = "Loading";
            Form1.streamer = "SkipGently";
            Form1.displayStream();
            await Task.Delay(10000);
            SkipGently.Text = "SkipGently";
        }

        private async void SomeTexas_Dude_Click(object sender, EventArgs e)
        {
            SomeTexas_Dude.Text = "Loading";
            Form1.streamer = "Some_Texas_Dude";
            Form1.displayStream();
            await Task.Delay(10000);
            SomeTexas_Dude.Text = "Some_Texas";
        }

        private async void Ssaab_Click(object sender, EventArgs e)
        {
            Ssaab.Text = "Loading";
            Form1.streamer = "ssaab";
            Form1.displayStream();
            await Task.Delay(10000);
            Ssaab.Text = "Ssaab";
        }

        private async void TastyTV_Click(object sender, EventArgs e)
        {
            TastyTV.Text = "Loading";
            Form1.streamer = "TastyTV";
            Form1.displayStream();
            await Task.Delay(10000);
            TastyTV.Text = "TastyTV";
        }

        private async void Thadrius_Click(object sender, EventArgs e)
        {
            Thadrius.Text = "Loading";
            Form1.streamer = "thadrius";
            Form1.displayStream();
            await Task.Delay(10000);
            Thadrius.Text = "Thadrius";
        }

        private async void TheBuddha3_Click(object sender, EventArgs e)
        {
            TheBuddha3.Text = "Loading";
            Form1.streamer = "thebuddha3";
            Form1.displayStream();
            await Task.Delay(10000);
            TheBuddha3.Text = "TheBuddha3";
        }

        private async void thelawmangaming_Click(object sender, EventArgs e)
        {
            thelawmangaming.Text = "Loading";
            Form1.streamer = "thelawmangaming";
            Form1.displayStream();
            await Task.Delay(10000);
            thelawmangaming.Text = "thelawmangaming";
        }

        private async void TigerWriter_Click(object sender, EventArgs e)
        {
            TigerWriter.Text = "Loading";
            Form1.streamer = "TigerWriter";
            Form1.displayStream();
            await Task.Delay(10000);
            TigerWriter.Text = "TigerWriter";
        }

        private async void Timmac_Click(object sender, EventArgs e)
        {
            Timmac.Text = "Loading";
            Form1.streamer = "Timmac";
            Form1.displayStream();
            await Task.Delay(10000);
            Timmac.Text = "Timmac";
        }

        private async void TVSBOH_Click(object sender, EventArgs e)
        {
            TVSBOH.Text = "Loading";
            Form1.streamer = "TVSBOH";
            Form1.displayStream();
            await Task.Delay(10000);
            TVSBOH.Text = "TVSBOH";
        }

        private async void UndeadBaron_Click(object sender, EventArgs e)
        {
            UndeadBaron.Text = "Loading";
            Form1.streamer = "UndeadBaron";
            Form1.displayStream();
            await Task.Delay(10000);
            UndeadBaron.Text = "UndeadBaron";
        }

        private async void ValkyrieSpirit_Click(object sender, EventArgs e)
        {
            ValkyrieSpirit.Text = "Loading";
            Form1.streamer = "ValkyrieSpirit";
            Form1.displayStream();
            await Task.Delay(10000);
            ValkyrieSpirit.Text = "ValkyrieSpirit";
        }

        private async void Will_ko_Click(object sender, EventArgs e)
        {
            Will_ko.Text = "Loading";
            Form1.streamer = "will_ko";
            Form1.displayStream();
            await Task.Delay(10000);
            Will_ko.Text = "Will_ko";
        }

        private async void willitkimchi_Click(object sender, EventArgs e)
        {
            willitkimchi.Text = "Loading";
            Form1.streamer = "willitkimchi";
            Form1.displayStream();
            await Task.Delay(10000);
            willitkimchi.Text = "willitkimchi";
        }

        private async void Wish_Click(object sender, EventArgs e)
        {
            Wish.Text = "Loading";
            Form1.streamer = "wish";
            Form1.displayStream();
            await Task.Delay(10000);
            Wish.Text = "Wish";
        }

        private async void X_xZimx_X_Click(object sender, EventArgs e)
        {
            X_xZimx_X.Text = "Loading";
            Form1.streamer = "X_xZimx_X";
            Form1.displayStream();
            await Task.Delay(10000);
            X_xZimx_X.Text = "X_xZimx_X";
        }

        private async void Xiceman_Click(object sender, EventArgs e)
        {
            Xiceman.Text = "Loading";
            Form1.streamer = "Xiceman";
            Form1.displayStream();
            await Task.Delay(10000);
            Xiceman.Text = "Xiceman";
        }

        private async void XProph3cyx_Click(object sender, EventArgs e)
        {
            XProph3cyx.Text = "Loading";
            Form1.streamer = "xproph3cyx";
            Form1.displayStream();
            await Task.Delay(10000);
            XProph3cyx.Text = "XProph3cyx";
        }

        private async void Zaquelle_Click(object sender, EventArgs e)
        {
            Zaquelle.Text = "Loading";
            Form1.streamer = "Zaquelle";
            Form1.displayStream();
            await Task.Delay(10000);
            Zaquelle.Text = "Zaquelle";
        }

        private async void SheepDog59_Click(object sender, EventArgs e)
        {
            SheepDog59.Text = "Loading";
            Form1.streamer = "sheepdog59";
            Form1.displayStream();
            await Task.Delay(10000);
            SheepDog59.Text = "SheepDog59";
        }

        private async void TheRealSpectral_Click(object sender, EventArgs e)
        {
            TheRealSpectral.Text = "Loading";
            Form1.streamer = "therealspectral";
            Form1.displayStream();
            await Task.Delay(10000);
            TheRealSpectral.Text = "TheRealSpectr";
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshButton.Text = "Refreshing";
            refreshButton.Enabled = false;
            refreshBackgroundWorker.RunWorkerAsync();
        }

        public void refreshBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            int bar = 1;
            string OAuthToken = TFRPStreambox.Properties.Settings.Default.OAuth;

            //Start of the live check

            //1GUnit1 live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string _1guu = @"https://api.twitch.tv/kraken/streams/1gunit1?client_id=" + OAuthToken;;
                var _1guj = new WebClient().DownloadString(_1guu);
                Rootobject _1gur = JsonConvert.DeserializeObject<Rootobject>(_1guj);
                try
                {
                    string status = _1gur.stream.channel.status;
                    if (_1gur.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            _1GUnit1.BeginInvoke((Action)delegate () { _1GUnit1.BackColor = Color.LightGreen; });
                        }
                        else
                        {
                            _1GUnit1.BeginInvoke((Action)delegate () { _1GUnit1.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        _1GUnit1.BeginInvoke((Action)delegate () { _1GUnit1.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    _1GUnit1.BeginInvoke((Action)delegate () { _1GUnit1.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {}
            //AbdulHD Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string abdulhdurl = @"https://api.twitch.tv/kraken/streams/AbDulHD?client_id=" + OAuthToken;;

                var abdulhdjson = new WebClient().DownloadString(abdulhdurl);

                Rootobject abdulhdr = JsonConvert.DeserializeObject<Rootobject>(abdulhdjson);
                try
                {
                    string status = abdulhdr.stream.channel.status;
                    if (abdulhdr.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            AbdulHD.BeginInvoke((Action)delegate () { AbdulHD.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            AbdulHD.BeginInvoke((Action)delegate () { AbdulHD.BackColor = Color.Yellow; });
                            bool b = status.Contains("FamilyRP");
                            Console.WriteLine(b);
                        }
                        
                    }
                    else
                    {
                        AbdulHD.BeginInvoke((Action)delegate () { AbdulHD.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    AbdulHD.BeginInvoke((Action)delegate () { AbdulHD.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {}
            //AgentNorth live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string agentnorthurl = @"https://api.twitch.tv/kraken/streams/agentnorth?client_id=" + OAuthToken;;
                var agentnorthjson = new WebClient().DownloadString(agentnorthurl);
                Rootobject agentnorthr = JsonConvert.DeserializeObject<Rootobject>(agentnorthjson);
                try
                {
                    string status = agentnorthr.stream.channel.status;
                    if (agentnorthr.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            AgentNorth.BeginInvoke((Action)delegate () { AgentNorth.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            AgentNorth.BeginInvoke((Action)delegate () { AgentNorth.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        AgentNorth.BeginInvoke((Action)delegate () { AgentNorth.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    AgentNorth.BeginInvoke((Action)delegate () { AgentNorth.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //alexusnightingale live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/alexusnightingale?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            alexusnightingale.BeginInvoke((Action)delegate () { alexusnightingale.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            alexusnightingale.BeginInvoke((Action)delegate () { alexusnightingale.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        alexusnightingale.BeginInvoke((Action)delegate () { alexusnightingale.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    alexusnightingale.BeginInvoke((Action)delegate () { alexusnightingale.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //AndyMilonakis live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/AndyMilonakis?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            AndyMilonakis.BeginInvoke((Action)delegate () { AndyMilonakis.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            AndyMilonakis.BeginInvoke((Action)delegate () { AndyMilonakis.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        AndyMilonakis.BeginInvoke((Action)delegate () { AndyMilonakis.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    AndyMilonakis.BeginInvoke((Action)delegate () { AndyMilonakis.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //anthonyz_ live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/anthonyz_?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            anthonyz_.BeginInvoke((Action)delegate () { anthonyz_.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            anthonyz_.BeginInvoke((Action)delegate () { anthonyz_.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        anthonyz_.BeginInvoke((Action)delegate () { anthonyz_.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    anthonyz_.BeginInvoke((Action)delegate () { anthonyz_.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //BFLY003 live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/BFLY003?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            BFLY003.BeginInvoke((Action)delegate () { BFLY003.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            BFLY003.BeginInvoke((Action)delegate () { BFLY003.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        BFLY003.BeginInvoke((Action)delegate () { BFLY003.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    BFLY003.BeginInvoke((Action)delegate () { BFLY003.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //boscoreli live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/boscoreli_gaming?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            boscoreli_gaming.BeginInvoke((Action)delegate () { boscoreli_gaming.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            boscoreli_gaming.BeginInvoke((Action)delegate () { boscoreli_gaming.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        boscoreli_gaming.BeginInvoke((Action)delegate () { boscoreli_gaming.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    boscoreli_gaming.BeginInvoke((Action)delegate () { boscoreli_gaming.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //BPZ live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/BPZ?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            BPZ.BeginInvoke((Action)delegate () { BPZ.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            BPZ.BeginInvoke((Action)delegate () { BPZ.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        BPZ.BeginInvoke((Action)delegate () { BPZ.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    BPZ.BeginInvoke((Action)delegate () { BPZ.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //BuckkNaked live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/BuckkNaked?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            BuckkNaked.BeginInvoke((Action)delegate () { BuckkNaked.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            BuckkNaked.BeginInvoke((Action)delegate () { BuckkNaked.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        BuckkNaked.BeginInvoke((Action)delegate () { BuckkNaked.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    BuckkNaked.BeginInvoke((Action)delegate () { BuckkNaked.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //BurkeBlack live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/BurkeBlack?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            BurkeBlack.BeginInvoke((Action)delegate () { BurkeBlack.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            BurkeBlack.BeginInvoke((Action)delegate () { BurkeBlack.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        BurkeBlack.BeginInvoke((Action)delegate () { BurkeBlack.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    BurkeBlack.BeginInvoke((Action)delegate () { BurkeBlack.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Ch1ckenb0ne live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Ch1ckenb0ne?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Ch1ckenb0ne.BeginInvoke((Action)delegate () { Ch1ckenb0ne.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Ch1ckenb0ne.BeginInvoke((Action)delegate () { Ch1ckenb0ne.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Ch1ckenb0ne.BeginInvoke((Action)delegate () { Ch1ckenb0ne.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Ch1ckenb0ne.BeginInvoke((Action)delegate () { Ch1ckenb0ne.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //ChiefDas live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/ChiefDas?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            ChiefDas.BeginInvoke((Action)delegate () { ChiefDas.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            ChiefDas.BeginInvoke((Action)delegate () { ChiefDas.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        ChiefDas.BeginInvoke((Action)delegate () { ChiefDas.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    ChiefDas.BeginInvoke((Action)delegate () { ChiefDas.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //classypax live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/ClassyPax?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            ClassyPax.BeginInvoke((Action)delegate () { ClassyPax.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            ClassyPax.BeginInvoke((Action)delegate () { ClassyPax.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        ClassyPax.BeginInvoke((Action)delegate () { ClassyPax.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    ClassyPax.BeginInvoke((Action)delegate () { ClassyPax.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //cletusbueford live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Cletusbueford?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            CletusBueford.BeginInvoke((Action)delegate () { CletusBueford.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            CletusBueford.BeginInvoke((Action)delegate () { CletusBueford.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        CletusBueford.BeginInvoke((Action)delegate () { CletusBueford.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    CletusBueford.BeginInvoke((Action)delegate () { CletusBueford.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //CoolidgeHD live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/CoolidgeHD?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            CoolidgeHD.BeginInvoke((Action)delegate () { CoolidgeHD.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            CoolidgeHD.BeginInvoke((Action)delegate () { CoolidgeHD.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        CoolidgeHD.BeginInvoke((Action)delegate () { CoolidgeHD.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    CoolidgeHD.BeginInvoke((Action)delegate () { CoolidgeHD.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //dasMehdi live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
            	string dasu = @"https://api.twitch.tv/kraken/streams/dasmehdi?client_id=" + OAuthToken;
                var dasj = new WebClient().DownloadString(dasu);
            	Rootobject dasr = JsonConvert.DeserializeObject<Rootobject>(dasj);
                try
                {
                    string dasstatus = dasr.stream.channel.status;
                    if (dasr.stream != null && dasr.stream.game == "Grand Theft Auto V")
                    {
                        if (dasstatus.Contains("FamilyRP"))
                        {
                            dasMehdi.BeginInvoke((Action)delegate () { dasMehdi.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            dasMehdi.BeginInvoke((Action)delegate () { dasMehdi.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        dasMehdi.BeginInvoke((Action)delegate () { dasMehdi.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    dasMehdi.BeginInvoke((Action)delegate () { dasMehdi.BackColor = Color.IndianRed; });
                }
        	}
        	catch (WebException)
        	{
        		
        	}
            //DisbeArex live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/DisbeArex?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            DisbeArex.BeginInvoke((Action)delegate () { DisbeArex.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            DisbeArex.BeginInvoke((Action)delegate () { DisbeArex.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        DisbeArex.BeginInvoke((Action)delegate () { DisbeArex.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    DisbeArex.BeginInvoke((Action)delegate () { DisbeArex.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //djkwix live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/djkwix?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            djkwix.BeginInvoke((Action)delegate () { djkwix.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            djkwix.BeginInvoke((Action)delegate () { djkwix.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        djkwix.BeginInvoke((Action)delegate () { djkwix.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    djkwix.BeginInvoke((Action)delegate () { djkwix.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //DrunkBabyYoshi live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/DrunkBabyYoshi?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            DrunkBabyYoshi.BeginInvoke((Action)delegate () { DrunkBabyYoshi.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            DrunkBabyYoshi.BeginInvoke((Action)delegate () { DrunkBabyYoshi.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        DrunkBabyYoshi.BeginInvoke((Action)delegate () { DrunkBabyYoshi.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    DrunkBabyYoshi.BeginInvoke((Action)delegate () { DrunkBabyYoshi.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Esoluu live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Esoluu?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Esoluu.BeginInvoke((Action)delegate () { Esoluu.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Esoluu.BeginInvoke((Action)delegate () { Esoluu.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Esoluu.BeginInvoke((Action)delegate () { Esoluu.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Esoluu.BeginInvoke((Action)delegate () { Esoluu.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //finkone live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Finkone?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Finkone.BeginInvoke((Action)delegate () { Finkone.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Finkone.BeginInvoke((Action)delegate () { Finkone.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Finkone.BeginInvoke((Action)delegate () { Finkone.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Finkone.BeginInvoke((Action)delegate () { Finkone.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Fistofthewalrus live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/FistofTheWalrus?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            FistofTheWalrus.BeginInvoke((Action)delegate () { FistofTheWalrus.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            FistofTheWalrus.BeginInvoke((Action)delegate () { FistofTheWalrus.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        FistofTheWalrus.BeginInvoke((Action)delegate () { FistofTheWalrus.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    FistofTheWalrus.BeginInvoke((Action)delegate () { FistofTheWalrus.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Five0anthO live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Five0AnthO?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Five0AnthO.BeginInvoke((Action)delegate () { Five0AnthO.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Five0AnthO.BeginInvoke((Action)delegate () { Five0AnthO.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Five0AnthO.BeginInvoke((Action)delegate () { Five0AnthO.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Five0AnthO.BeginInvoke((Action)delegate () { Five0AnthO.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //GeeFamous92 live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/GeeFamous92?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            GeeFamous92.BeginInvoke((Action)delegate () { GeeFamous92.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            GeeFamous92.BeginInvoke((Action)delegate () { GeeFamous92.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        GeeFamous92.BeginInvoke((Action)delegate () { GeeFamous92.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    GeeFamous92.BeginInvoke((Action)delegate () { GeeFamous92.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //GhilleGuyTV live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/GhilleGuyTV?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            GhilleGuyTV.BeginInvoke((Action)delegate () { GhilleGuyTV.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            GhilleGuyTV.BeginInvoke((Action)delegate () { GhilleGuyTV.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        GhilleGuyTV.BeginInvoke((Action)delegate () { GhilleGuyTV.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    GhilleGuyTV.BeginInvoke((Action)delegate () { GhilleGuyTV.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //GiantFaffle live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/GiantFaffle?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            GiantFaffle.BeginInvoke((Action)delegate () { GiantFaffle.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            GiantFaffle.BeginInvoke((Action)delegate () { GiantFaffle.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        GiantFaffle.BeginInvoke((Action)delegate () { GiantFaffle.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    GiantFaffle.BeginInvoke((Action)delegate () { GiantFaffle.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //GloryD live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/GloryD?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            GloryD.BeginInvoke((Action)delegate () { GloryD.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            GloryD.BeginInvoke((Action)delegate () { GloryD.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        GloryD.BeginInvoke((Action)delegate () { GloryD.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    GloryD.BeginInvoke((Action)delegate () { GloryD.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Harryow live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Harryow?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Harryow.BeginInvoke((Action)delegate () { Harryow.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Harryow.BeginInvoke((Action)delegate () { Harryow.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Harryow.BeginInvoke((Action)delegate () { Harryow.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Harryow.BeginInvoke((Action)delegate () { Harryow.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Hazard live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Hazard?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Hazard.BeginInvoke((Action)delegate () { Hazard.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Hazard.BeginInvoke((Action)delegate () { Hazard.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Hazard.BeginInvoke((Action)delegate () { Hazard.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Hazard.BeginInvoke((Action)delegate () { Hazard.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Hirona live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Hirona?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Hirona.BeginInvoke((Action)delegate () { Hirona.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Hirona.BeginInvoke((Action)delegate () { Hirona.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Hirona.BeginInvoke((Action)delegate () { Hirona.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Hirona.BeginInvoke((Action)delegate () { Hirona.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //IamSp00n live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/IAmSp00n?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            IAmSp00n.BeginInvoke((Action)delegate () { IAmSp00n.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            IAmSp00n.BeginInvoke((Action)delegate () { IAmSp00n.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        IAmSp00n.BeginInvoke((Action)delegate () { IAmSp00n.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    IAmSp00n.BeginInvoke((Action)delegate () { IAmSp00n.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //ImmortalLive live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/ImmortalLive?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            ImmortalLive.BeginInvoke((Action)delegate () { ImmortalLive.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            ImmortalLive.BeginInvoke((Action)delegate () { ImmortalLive.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        ImmortalLive.BeginInvoke((Action)delegate () { ImmortalLive.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    ImmortalLive.BeginInvoke((Action)delegate () { ImmortalLive.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //ironmonkeytv live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/ironmonkeytv?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            ironmonkeytv.BeginInvoke((Action)delegate () { ironmonkeytv.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            ironmonkeytv.BeginInvoke((Action)delegate () { ironmonkeytv.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        ironmonkeytv.BeginInvoke((Action)delegate () { ironmonkeytv.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    ironmonkeytv.BeginInvoke((Action)delegate () { ironmonkeytv.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //itzButch live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/itzButch?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            itzButch.BeginInvoke((Action)delegate () { itzButch.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            itzButch.BeginInvoke((Action)delegate () { itzButch.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        itzButch.BeginInvoke((Action)delegate () { itzButch.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    itzButch.BeginInvoke((Action)delegate () { itzButch.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //J_Reed live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/J_Reed?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            J_Reed.BeginInvoke((Action)delegate () { J_Reed.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            J_Reed.BeginInvoke((Action)delegate () { J_Reed.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        J_Reed.BeginInvoke((Action)delegate () { J_Reed.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    J_Reed.BeginInvoke((Action)delegate () { J_Reed.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //JAboodyShow live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/JaboodyShow?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            JaboodyShow.BeginInvoke((Action)delegate () { JaboodyShow.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            JaboodyShow.BeginInvoke((Action)delegate () { JaboodyShow.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        JaboodyShow.BeginInvoke((Action)delegate () { JaboodyShow.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    JaboodyShow.BeginInvoke((Action)delegate () { JaboodyShow.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //jake_terek live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/jake_terek?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            jake_terek.BeginInvoke((Action)delegate () { jake_terek.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            jake_terek.BeginInvoke((Action)delegate () { jake_terek.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        jake_terek.BeginInvoke((Action)delegate () { jake_terek.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    jake_terek.BeginInvoke((Action)delegate () { jake_terek.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //JmxTwiztid live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/JmxTwiztid?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            JmxTwiztid.BeginInvoke((Action)delegate () { JmxTwiztid.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            JmxTwiztid.BeginInvoke((Action)delegate () { JmxTwiztid.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        JmxTwiztid.BeginInvoke((Action)delegate () { JmxTwiztid.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    JmxTwiztid.BeginInvoke((Action)delegate () { JmxTwiztid.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //John782 live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/John782?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            John782.BeginInvoke((Action)delegate () { John782.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            John782.BeginInvoke((Action)delegate () { John782.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        John782.BeginInvoke((Action)delegate () { John782.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    John782.BeginInvoke((Action)delegate () { John782.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Jolly__Jess live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Jolly__Jess?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Jolly__Jess.BeginInvoke((Action)delegate () { Jolly__Jess.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Jolly__Jess.BeginInvoke((Action)delegate () { Jolly__Jess.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Jolly__Jess.BeginInvoke((Action)delegate () { Jolly__Jess.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Jolly__Jess.BeginInvoke((Action)delegate () { Jolly__Jess.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //JTtroy live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/JTtroy?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            JTtroy.BeginInvoke((Action)delegate () { JTtroy.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            JTtroy.BeginInvoke((Action)delegate () { JTtroy.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        JTtroy.BeginInvoke((Action)delegate () { JTtroy.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    JTtroy.BeginInvoke((Action)delegate () { JTtroy.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //kaceytron live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/kaceytron?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            kaceytron.BeginInvoke((Action)delegate () { kaceytron.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            kaceytron.BeginInvoke((Action)delegate () { kaceytron.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        kaceytron.BeginInvoke((Action)delegate () { kaceytron.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    kaceytron.BeginInvoke((Action)delegate () { kaceytron.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //KaptainKPress live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/KaptainKpress?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            KaptainKpress.BeginInvoke((Action)delegate () { KaptainKpress.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            KaptainKpress.BeginInvoke((Action)delegate () { KaptainKpress.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        KaptainKpress.BeginInvoke((Action)delegate () { KaptainKpress.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    KaptainKpress.BeginInvoke((Action)delegate () { KaptainKpress.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //KatieRouu live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/KatieRouu?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            KatieRouu.BeginInvoke((Action)delegate () { KatieRouu.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            KatieRouu.BeginInvoke((Action)delegate () { KatieRouu.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        KatieRouu.BeginInvoke((Action)delegate () { KatieRouu.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    KatieRouu.BeginInvoke((Action)delegate () { KatieRouu.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Kithicor27 live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Kithicor27?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Kithicor27.BeginInvoke((Action)delegate () { Kithicor27.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Kithicor27.BeginInvoke((Action)delegate () { Kithicor27.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Kithicor27.BeginInvoke((Action)delegate () { Kithicor27.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Kithicor27.BeginInvoke((Action)delegate () { Kithicor27.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //LarryX7 live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/LarryX7?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            LarryX7.BeginInvoke((Action)delegate () { LarryX7.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            LarryX7.BeginInvoke((Action)delegate () { LarryX7.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        LarryX7.BeginInvoke((Action)delegate () { LarryX7.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    LarryX7.BeginInvoke((Action)delegate () { LarryX7.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //lawdog1096 live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/lawdog1096?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            lawdog1096.BeginInvoke((Action)delegate () { lawdog1096.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            lawdog1096.BeginInvoke((Action)delegate () { lawdog1096.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        lawdog1096.BeginInvoke((Action)delegate () { lawdog1096.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    lawdog1096.BeginInvoke((Action)delegate () { lawdog1096.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //LiftYourGame live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/LiftYourGame?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            LiftYourGame.BeginInvoke((Action)delegate () { LiftYourGame.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            LiftYourGame.BeginInvoke((Action)delegate () { LiftYourGame.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        LiftYourGame.BeginInvoke((Action)delegate () { LiftYourGame.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    LiftYourGame.BeginInvoke((Action)delegate () { LiftYourGame.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //loveANG3L live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/loveANG3L?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            loveANF3L.BeginInvoke((Action)delegate () { loveANF3L.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            loveANF3L.BeginInvoke((Action)delegate () { loveANF3L.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        loveANF3L.BeginInvoke((Action)delegate () { loveANF3L.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    loveANF3L.BeginInvoke((Action)delegate () { loveANF3L.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //mart1n_g live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/mart1n_g?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            mart1n_g.BeginInvoke((Action)delegate () { mart1n_g.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            mart1n_g.BeginInvoke((Action)delegate () { mart1n_g.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        mart1n_g.BeginInvoke((Action)delegate () { mart1n_g.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    mart1n_g.BeginInvoke((Action)delegate () { mart1n_g.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //MiltonTPike1 live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/MiltonTPike1?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            MiltonTPike1.BeginInvoke((Action)delegate () { MiltonTPike1.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            MiltonTPike1.BeginInvoke((Action)delegate () { MiltonTPike1.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        MiltonTPike1.BeginInvoke((Action)delegate () { MiltonTPike1.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    MiltonTPike1.BeginInvoke((Action)delegate () { MiltonTPike1.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //MintsTV live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/MintsTV?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            MintsTV.BeginInvoke((Action)delegate () { MintsTV.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            MintsTV.BeginInvoke((Action)delegate () { MintsTV.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        MintsTV.BeginInvoke((Action)delegate () { MintsTV.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    MintsTV.BeginInvoke((Action)delegate () { MintsTV.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //MrMoonsHouse live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/MrMoonsHouse?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            MrMoonsHouse.BeginInvoke((Action)delegate () { MrMoonsHouse.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            MrMoonsHouse.BeginInvoke((Action)delegate () { MrMoonsHouse.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        MrMoonsHouse.BeginInvoke((Action)delegate () { MrMoonsHouse.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    MrMoonsHouse.BeginInvoke((Action)delegate () { MrMoonsHouse.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //MsDeathRabbit live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/MsDeathRabbit?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            MsDeathRabbit.BeginInvoke((Action)delegate () { MsDeathRabbit.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            MsDeathRabbit.BeginInvoke((Action)delegate () { MsDeathRabbit.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        MsDeathRabbit.BeginInvoke((Action)delegate () { MsDeathRabbit.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    MsDeathRabbit.BeginInvoke((Action)delegate () { MsDeathRabbit.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //OG_BluePill live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Og_BluePill?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Og_BluePill.BeginInvoke((Action)delegate () { Og_BluePill.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Og_BluePill.BeginInvoke((Action)delegate () { Og_BluePill.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Og_BluePill.BeginInvoke((Action)delegate () { Og_BluePill.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Og_BluePill.BeginInvoke((Action)delegate () { Og_BluePill.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //PENTAhearth live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/PENTAhearth?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            PENTAhearth.BeginInvoke((Action)delegate () { PENTAhearth.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            PENTAhearth.BeginInvoke((Action)delegate () { PENTAhearth.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        PENTAhearth.BeginInvoke((Action)delegate () { PENTAhearth.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    PENTAhearth.BeginInvoke((Action)delegate () { PENTAhearth.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Pinky live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Pinky?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Pinky.BeginInvoke((Action)delegate () { Pinky.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Pinky.BeginInvoke((Action)delegate () { Pinky.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Pinky.BeginInvoke((Action)delegate () { Pinky.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Pinky.BeginInvoke((Action)delegate () { Pinky.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //PmsProxy live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/PmsProxy?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            PmsProxy.BeginInvoke((Action)delegate () { PmsProxy.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            PmsProxy.BeginInvoke((Action)delegate () { PmsProxy.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        PmsProxy.BeginInvoke((Action)delegate () { PmsProxy.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    PmsProxy.BeginInvoke((Action)delegate () { PmsProxy.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //PorkMarshmallow live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/PorkMarshmallow?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            PorkMarshmallow.BeginInvoke((Action)delegate () { PorkMarshmallow.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            PorkMarshmallow.BeginInvoke((Action)delegate () { PorkMarshmallow.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        PorkMarshmallow.BeginInvoke((Action)delegate () { PorkMarshmallow.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    PorkMarshmallow.BeginInvoke((Action)delegate () { PorkMarshmallow.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //PrimusPalus live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/PrimusPalus?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            PrimusPalus.BeginInvoke((Action)delegate () { PrimusPalus.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            PrimusPalus.BeginInvoke((Action)delegate () { PrimusPalus.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        PrimusPalus.BeginInvoke((Action)delegate () { PrimusPalus.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    PrimusPalus.BeginInvoke((Action)delegate () { PrimusPalus.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Purrluna live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Purrluna?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Purrluna.BeginInvoke((Action)delegate () { Purrluna.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Purrluna.BeginInvoke((Action)delegate () { Purrluna.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Purrluna.BeginInvoke((Action)delegate () { Purrluna.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Purrluna.BeginInvoke((Action)delegate () { Purrluna.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Pydrex live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Pydrex?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Pydrex.BeginInvoke((Action)delegate () { Pydrex.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Pydrex.BeginInvoke((Action)delegate () { Pydrex.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Pydrex.BeginInvoke((Action)delegate () { Pydrex.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Pydrex.BeginInvoke((Action)delegate () { Pydrex.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //RajjPatel Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/RajjPatel?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            RajjPatel.BeginInvoke((Action)delegate () { RajjPatel.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            RajjPatel.BeginInvoke((Action)delegate () { RajjPatel.BackColor = Color.Yellow; });
                        }

                    }
                    else
                    {
                        RajjPatel.BeginInvoke((Action)delegate () { RajjPatel.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    RajjPatel.BeginInvoke((Action)delegate () { RajjPatel.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Rastafied Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Rastafied?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Rastafied.BeginInvoke((Action)delegate () { Rastafied.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Rastafied.BeginInvoke((Action)delegate () { Rastafied.BackColor = Color.Yellow; });
                        }

                    }
                    else
                    {
                        Rastafied.BeginInvoke((Action)delegate () { Rastafied.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Rastafied.BeginInvoke((Action)delegate () { Rastafied.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //RastaRafikii Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/RastaRafikii?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            RastaRafikii.BeginInvoke((Action)delegate () { RastaRafikii.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            RastaRafikii.BeginInvoke((Action)delegate () { RastaRafikii.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        RastaRafikii.BeginInvoke((Action)delegate () { RastaRafikii.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    RastaRafikii.BeginInvoke((Action)delegate () { RastaRafikii.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Samzhit Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/SAMZHIT?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            SAMZHIT.BeginInvoke((Action)delegate () { SAMZHIT.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            SAMZHIT.BeginInvoke((Action)delegate () { SAMZHIT.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        SAMZHIT.BeginInvoke((Action)delegate () { SAMZHIT.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    SAMZHIT.BeginInvoke((Action)delegate () { SAMZHIT.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Sarapocalypse Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Sarapocalypse?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Sarapocalypse.BeginInvoke((Action)delegate () { Sarapocalypse.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Sarapocalypse.BeginInvoke((Action)delegate () { Sarapocalypse.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Sarapocalypse.BeginInvoke((Action)delegate () { Sarapocalypse.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Sarapocalypse.BeginInvoke((Action)delegate () { Sarapocalypse.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //SayeedBlack Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/SayeedBlack?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            SayeedBlack.BeginInvoke((Action)delegate () { SayeedBlack.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            SayeedBlack.BeginInvoke((Action)delegate () { SayeedBlack.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        SayeedBlack.BeginInvoke((Action)delegate () { SayeedBlack.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    SayeedBlack.BeginInvoke((Action)delegate () { SayeedBlack.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //SeanKingV Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/SeanKingV?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            SeanKingV.BeginInvoke((Action)delegate () { SeanKingV.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            SeanKingV.BeginInvoke((Action)delegate () { SeanKingV.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        SeanKingV.BeginInvoke((Action)delegate () { SeanKingV.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    SeanKingV.BeginInvoke((Action)delegate () { SeanKingV.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Selvek Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Selvek?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Selvek.BeginInvoke((Action)delegate () { Selvek.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Selvek.BeginInvoke((Action)delegate () { Selvek.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Selvek.BeginInvoke((Action)delegate () { Selvek.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Selvek.BeginInvoke((Action)delegate () { Selvek.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //ShaZ Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/ShaZ?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            ShaZ.BeginInvoke((Action)delegate () { ShaZ.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            ShaZ.BeginInvoke((Action)delegate () { ShaZ.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        ShaZ.BeginInvoke((Action)delegate () { ShaZ.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    ShaZ.BeginInvoke((Action)delegate () { ShaZ.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //SheriffEli Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/SheriffEli?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            SheriffEli.BeginInvoke((Action)delegate () { SheriffEli.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            SheriffEli.BeginInvoke((Action)delegate () { SheriffEli.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        SheriffEli.BeginInvoke((Action)delegate () { SheriffEli.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    SheriffEli.BeginInvoke((Action)delegate () { SheriffEli.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //SHP_TV Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/SHPTV?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            SHPTV.BeginInvoke((Action)delegate () { SHPTV.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            SHPTV.BeginInvoke((Action)delegate () { SHPTV.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        SHPTV.BeginInvoke((Action)delegate () { SHPTV.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    SHPTV.BeginInvoke((Action)delegate () { SHPTV.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //SilentSentry Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/SilentSentry?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            SilentSentry.BeginInvoke((Action)delegate () { SilentSentry.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            SilentSentry.BeginInvoke((Action)delegate () { SilentSentry.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        SilentSentry.BeginInvoke((Action)delegate () { SilentSentry.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    SilentSentry.BeginInvoke((Action)delegate () { SilentSentry.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //SimplyJulian Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/SimplyJulian?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            SimplyJulian.BeginInvoke((Action)delegate () { SimplyJulian.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            SimplyJulian.BeginInvoke((Action)delegate () { SimplyJulian.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        SimplyJulian.BeginInvoke((Action)delegate () { SimplyJulian.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    SimplyJulian.BeginInvoke((Action)delegate () { SimplyJulian.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //SirCoffeestain Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/SirCoffeestain?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            SirCoffeestain.BeginInvoke((Action)delegate () { SirCoffeestain.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            SirCoffeestain.BeginInvoke((Action)delegate () { SirCoffeestain.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        SirCoffeestain.BeginInvoke((Action)delegate () { SirCoffeestain.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    SirCoffeestain.BeginInvoke((Action)delegate () { SirCoffeestain.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //SirPinkleston00 Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/SirPinkleton00?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            SirPinkleton00.BeginInvoke((Action)delegate () { SirPinkleton00.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            SirPinkleton00.BeginInvoke((Action)delegate () { SirPinkleton00.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        SirPinkleton00.BeginInvoke((Action)delegate () { SirPinkleton00.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    SirPinkleton00.BeginInvoke((Action)delegate () { SirPinkleton00.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //SkipGently Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/SkipGently?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            SkipGently.BeginInvoke((Action)delegate () { SkipGently.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            SkipGently.BeginInvoke((Action)delegate () { SkipGently.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        SkipGently.BeginInvoke((Action)delegate () { SkipGently.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    SkipGently.BeginInvoke((Action)delegate () { SkipGently.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Some_Texas_Dude Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/SomeTexas_Dude?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            SomeTexas_Dude.BeginInvoke((Action)delegate () { SomeTexas_Dude.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            SomeTexas_Dude.BeginInvoke((Action)delegate () { SomeTexas_Dude.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        SomeTexas_Dude.BeginInvoke((Action)delegate () { SomeTexas_Dude.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    SomeTexas_Dude.BeginInvoke((Action)delegate () { SomeTexas_Dude.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Ssaab Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Ssaab?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Ssaab.BeginInvoke((Action)delegate () { Ssaab.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Ssaab.BeginInvoke((Action)delegate () { Ssaab.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Ssaab.BeginInvoke((Action)delegate () { Ssaab.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Ssaab.BeginInvoke((Action)delegate () { Ssaab.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //TastyTV Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/TastyTV?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            TastyTV.BeginInvoke((Action)delegate () { TastyTV.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            TastyTV.BeginInvoke((Action)delegate () { TastyTV.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        TastyTV.BeginInvoke((Action)delegate () { TastyTV.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    TastyTV.BeginInvoke((Action)delegate () { TastyTV.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Thadrius Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Thadrius?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Thadrius.BeginInvoke((Action)delegate () { Thadrius.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Thadrius.BeginInvoke((Action)delegate () { Thadrius.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Thadrius.BeginInvoke((Action)delegate () { Thadrius.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Thadrius.BeginInvoke((Action)delegate () { Thadrius.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //TheBuddha3 Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/TheBuddha3?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            TheBuddha3.BeginInvoke((Action)delegate () { TheBuddha3.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            TheBuddha3.BeginInvoke((Action)delegate () { TheBuddha3.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        TheBuddha3.BeginInvoke((Action)delegate () { TheBuddha3.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    TheBuddha3.BeginInvoke((Action)delegate () { TheBuddha3.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //thelawmangaming Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/thelawmangaming?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            thelawmangaming.BeginInvoke((Action)delegate () { thelawmangaming.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            thelawmangaming.BeginInvoke((Action)delegate () { thelawmangaming.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        thelawmangaming.BeginInvoke((Action)delegate () { thelawmangaming.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    thelawmangaming.BeginInvoke((Action)delegate () { thelawmangaming.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //TigerWrite Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/TigerWriter?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            TigerWriter.BeginInvoke((Action)delegate () { TigerWriter.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            TigerWriter.BeginInvoke((Action)delegate () { TigerWriter.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        TigerWriter.BeginInvoke((Action)delegate () { TigerWriter.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    TigerWriter.BeginInvoke((Action)delegate () { TigerWriter.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Timmac Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Timmac?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Timmac.BeginInvoke((Action)delegate () { Timmac.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Timmac.BeginInvoke((Action)delegate () { Timmac.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Timmac.BeginInvoke((Action)delegate () { Timmac.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Timmac.BeginInvoke((Action)delegate () { Timmac.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //TVSBOH Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/TVSBOH?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            TVSBOH.BeginInvoke((Action)delegate () { TVSBOH.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            TVSBOH.BeginInvoke((Action)delegate () { TVSBOH.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        TVSBOH.BeginInvoke((Action)delegate () { TVSBOH.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    TVSBOH.BeginInvoke((Action)delegate () { TVSBOH.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //UndeadBaron Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/UndeadBaron?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            UndeadBaron.BeginInvoke((Action)delegate () { UndeadBaron.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            UndeadBaron.BeginInvoke((Action)delegate () { UndeadBaron.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        UndeadBaron.BeginInvoke((Action)delegate () { UndeadBaron.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    UndeadBaron.BeginInvoke((Action)delegate () { UndeadBaron.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //ValkyrieSpirit Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/ValkyrieSpirit?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            ValkyrieSpirit.BeginInvoke((Action)delegate () { ValkyrieSpirit.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            ValkyrieSpirit.BeginInvoke((Action)delegate () { ValkyrieSpirit.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        ValkyrieSpirit.BeginInvoke((Action)delegate () { ValkyrieSpirit.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    ValkyrieSpirit.BeginInvoke((Action)delegate () { ValkyrieSpirit.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Will_ko Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Will_ko?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Will_ko.BeginInvoke((Action)delegate () { Will_ko.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Will_ko.BeginInvoke((Action)delegate () { Will_ko.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Will_ko.BeginInvoke((Action)delegate () { Will_ko.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Will_ko.BeginInvoke((Action)delegate () { Will_ko.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //willitkimchi Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/willitkimchi?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            willitkimchi.BeginInvoke((Action)delegate () { willitkimchi.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            willitkimchi.BeginInvoke((Action)delegate () { willitkimchi.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        willitkimchi.BeginInvoke((Action)delegate () { willitkimchi.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    willitkimchi.BeginInvoke((Action)delegate () { willitkimchi.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Wish Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Wish?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Wish.BeginInvoke((Action)delegate () { Wish.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Wish.BeginInvoke((Action)delegate () { Wish.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Wish.BeginInvoke((Action)delegate () { Wish.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Wish.BeginInvoke((Action)delegate () { Wish.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //X_xZimx_X Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/X_xZimx_X?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            X_xZimx_X.BeginInvoke((Action)delegate () { X_xZimx_X.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            X_xZimx_X.BeginInvoke((Action)delegate () { X_xZimx_X.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        X_xZimx_X.BeginInvoke((Action)delegate () { X_xZimx_X.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    X_xZimx_X.BeginInvoke((Action)delegate () { X_xZimx_X.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Xiceman Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Xiceman?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Xiceman.BeginInvoke((Action)delegate () { Xiceman.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Xiceman.BeginInvoke((Action)delegate () { Xiceman.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Xiceman.BeginInvoke((Action)delegate () { Xiceman.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Xiceman.BeginInvoke((Action)delegate () { Xiceman.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //XProph3cyx Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/XProph3cyx?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            XProph3cyx.BeginInvoke((Action)delegate () { XProph3cyx.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            XProph3cyx.BeginInvoke((Action)delegate () { XProph3cyx.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        XProph3cyx.BeginInvoke((Action)delegate () { XProph3cyx.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    XProph3cyx.BeginInvoke((Action)delegate () { XProph3cyx.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Zaquelle Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Zaquelle?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Zaquelle.BeginInvoke((Action)delegate () { Zaquelle.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Zaquelle.BeginInvoke((Action)delegate () { Zaquelle.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Zaquelle.BeginInvoke((Action)delegate () { Zaquelle.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Zaquelle.BeginInvoke((Action)delegate () { Zaquelle.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //TheRealSpectral Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/TheRealSpectral?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            TheRealSpectral.BeginInvoke((Action)delegate () { TheRealSpectral.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            TheRealSpectral.BeginInvoke((Action)delegate () { TheRealSpectral.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        TheRealSpectral.BeginInvoke((Action)delegate () { TheRealSpectral.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    TheRealSpectral.BeginInvoke((Action)delegate () { TheRealSpectral.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //SheepDog59 Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/SheepDog59?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            SheepDog59.BeginInvoke((Action)delegate () { SheepDog59.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            SheepDog59.BeginInvoke((Action)delegate () { SheepDog59.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        SheepDog59.BeginInvoke((Action)delegate () { SheepDog59.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    SheepDog59.BeginInvoke((Action)delegate () { SheepDog59.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //SAffypie101 Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Saffypie101?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            SaffyPie101.BeginInvoke((Action)delegate () { SaffyPie101.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            SaffyPie101.BeginInvoke((Action)delegate () { SaffyPie101.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        SaffyPie101.BeginInvoke((Action)delegate () { SaffyPie101.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    SaffyPie101.BeginInvoke((Action)delegate () { SaffyPie101.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //mythematic Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Mythematic?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Mythematic.BeginInvoke((Action)delegate () { Mythematic.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Mythematic.BeginInvoke((Action)delegate () { Mythematic.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        Mythematic.BeginInvoke((Action)delegate () { Mythematic.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Mythematic.BeginInvoke((Action)delegate () { Mythematic.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //slaughterco Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/SlaughterCo?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            SlaughterCo.BeginInvoke((Action)delegate () { SlaughterCo.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            SlaughterCo.BeginInvoke((Action)delegate () { SlaughterCo.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        SlaughterCo.BeginInvoke((Action)delegate () { SlaughterCo.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    SlaughterCo.BeginInvoke((Action)delegate () { SlaughterCo.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //peebro Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/peebro?client_id=" + OAuthToken;;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            peebro.BeginInvoke((Action)delegate () { peebro.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            peebro.BeginInvoke((Action)delegate () { peebro.BackColor = Color.Yellow; });
                        }
                        
                    }
                    else
                    {
                        peebro.BeginInvoke((Action)delegate () { peebro.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    peebro.BeginInvoke((Action)delegate () { peebro.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }
            //Zehring Live check
            refreshBackgroundWorker.ReportProgress(bar++);
            try
            {
                string url = @"https://api.twitch.tv/kraken/streams/Zehring?client_id=" + OAuthToken; ;
                var json = new WebClient().DownloadString(url);
                Rootobject stream = JsonConvert.DeserializeObject<Rootobject>(json);
                try
                {
                    string status = stream.stream.channel.status;
                    if (stream.stream.game == "Grand Theft Auto V")
                    {
                        if (status.Contains("FamilyRP") || status.Contains("Nothing") || status.Contains("TFRP") || status.Contains("Family RP"))
                        {
                            Zehring.BeginInvoke((Action)delegate () { Zehring.BackColor = Color.LightGreen; });
                            
                        }
                        else
                        {
                            Zehring.BeginInvoke((Action)delegate () { Zehring.BackColor = Color.Yellow; });
                        }

                    }
                    else
                    {
                        Zehring.BeginInvoke((Action)delegate () { Zehring.BackColor = Color.Orange; });
                    }
                    i++;
                }
                catch (Exception)
                {
                    Zehring.BeginInvoke((Action)delegate () { Zehring.BackColor = Color.IndianRed; });
                }
            }
            catch (WebException)
            {

            }

            Form1.streamercount = i.ToString();
        }

        public void refreshBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            bunifuCircleProgressbar1.BeginInvoke((Action)delegate () { bunifuCircleProgressbar1.Value = e.ProgressPercentage; });
            Random rnd = new Random();
            //Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //bunifuCircleProgressbar1.BeginInvoke((Action)delegate () { bunifuCircleProgressbar1.ProgressColor = randomColor; });
            bunifuCircleProgressbar1.BeginInvoke((Action)delegate () { bunifuCircleProgressbar1.Update(); });
        }

        public async void refreshBackgroundWorker_Complete(object sender, RunWorkerCompletedEventArgs e)
        {
            StreamerCount.BeginInvoke((Action)delegate () { StreamerCount.Text = "Streamers Online: " + streamercount; });
            refreshButton.BeginInvoke((Action)delegate () { refreshButton.BackColor = Color.LightGreen; });
            refreshButton.BeginInvoke((Action)delegate () { refreshButton.Text = "Refreshed"; });
            refreshButton.BeginInvoke((Action)delegate () { refreshButton.Enabled = false; });
            await Task.Delay(8000);
            refreshButton.BeginInvoke((Action)delegate () { refreshButton.BackColor = Color.White; });
            refreshButton.BeginInvoke((Action)delegate () { refreshButton.Text = "Refresh"; });
            refreshButton.BeginInvoke((Action)delegate () { refreshButton.Enabled = true; });
            await Task.Delay(30000);
            refreshBackgroundWorker.RunWorkerAsync();
            refreshButton.BeginInvoke((Action)delegate () { refreshButton.Text = "Refreshing"; });
            refreshButton.BeginInvoke((Action)delegate () { refreshButton.Enabled = false; });
        }

        private void vlcbutton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.videolan.org/vlc/index.html");
        }

        private async void Mythematic_Click(object sender, EventArgs e)
        {
            Mythematic.Text = "Loading";
            Form1.streamer = "mythematic";
            Form1.displayStream();
            await Task.Delay(10000);
            Mythematic.Text = "Mythematic";
        }

        private async void SaffyPie101_Click(object sender, EventArgs e)
        {
            SaffyPie101.Text = "Loading";
            Form1.streamer = "saffypie101";
            Form1.displayStream();
            await Task.Delay(10000);
            SaffyPie101.Text = "SaffyPie101";
        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCircleProgressbar1_Click(object sender, EventArgs e)
        {
            refreshBackgroundWorker.RunWorkerAsync();
        }

        private async void SlaughterCo_Click(object sender, EventArgs e)
        {
            SlaughterCo.Text = "Loading";
            Form1.streamer = "slaughterco";
            Form1.displayStream();
            await Task.Delay(10000);
            SlaughterCo.Text = "SlaughterCo";
        }

        private async void peebro_Click(object sender, EventArgs e)
        {
            peebro.Text = "Loading";
            Form1.streamer = "peebro";
            Form1.displayStream();
            await Task.Delay(10000);
            peebro.Text = "peebro";
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OptionsBox optionsBox = new OptionsBox();

            optionsBox.ShowDialog(this);
        }

        private async void Zehring_Click(object sender, EventArgs e)
        {
            Zehring.Text = "Loading";
            Form1.streamer = "zehring";
            Form1.displayStream();
            await Task.Delay(10000);
            Zehring.Text = "Zehring";
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBoxResult result = CustomMessageBox.ShowOK(
            "Orange box means the streamer is live. Yellow means they're playing GTA but possibly not on FamilyRP.",
            "Help",
            "Ok");
        }
    }

    public class Rootobject
    {
        public Stream stream { get; set; }
        public _Links2 _links { get; set; }
    }

    public class Stream
    {
        public long _id { get; set; }
        public string game { get; set; }
        public int viewers { get; set; }
        public int video_height { get; set; }
        public int delay { get; set; }
        public DateTime created_at { get; set; }
        public bool is_playlist { get; set; }
        public string stream_type { get; set; }
        public Preview preview { get; set; }
        public Channel channel { get; set; }
        public _Links1 _links { get; set; }
    }

    public class Preview
    {
        public string small { get; set; }
        public string medium { get; set; }
        public string large { get; set; }
        public string template { get; set; }
    }

    public class Channel
    {
        public bool mature { get; set; }
        public bool partner { get; set; }
        public string status { get; set; }
        public string broadcaster_language { get; set; }
        public string display_name { get; set; }
        public string game { get; set; }
        public string language { get; set; }
        public int _id { get; set; }
        public string name { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public object delay { get; set; }
        public string logo { get; set; }
        public object banner { get; set; }
        public string video_banner { get; set; }
        public object background { get; set; }
        public string profile_banner { get; set; }
        public string profile_banner_background_color { get; set; }
        public string url { get; set; }
        public int views { get; set; }
        public int followers { get; set; }
        public _Links _links { get; set; }
    }

    public class _Links
    {
        public string self { get; set; }
        public string follows { get; set; }
        public string commercial { get; set; }
        public string stream_key { get; set; }
        public string chat { get; set; }
        public string features { get; set; }
        public string subscriptions { get; set; }
        public string editors { get; set; }
        public string teams { get; set; }
        public string videos { get; set; }
    }

    public class _Links1
    {
        public string self { get; set; }
    }

    public class _Links2
    {
        public string self { get; set; }
        public string channel { get; set; }
    }
}
