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

namespace TFRPStreambox_CSharpWFA
{

    public partial class Form1 : Form
    {
        public static string streamercount;
        public Form1()
        {
            InitializeComponent();
            _1GUnit1ToolTip.SetToolTip(_1GUnit1, "Character: Jimmy Bean");
            _1GUnit1ToolTip.SetToolTip(AbdulHD, "Character: Abdul ALRahim");
            _1GUnit1ToolTip.SetToolTip(AgentNorth, "Character: Billy Roadstar");
            _1GUnit1ToolTip.SetToolTip(alexusnightingale, "Characters: Alei Nightingale | Anastacia Ortiz");
            _1GUnit1ToolTip.SetToolTip(AndyMilonakis, "Characters: Herbert Ward | Tameca Nakazawa");
            _1GUnit1ToolTip.SetToolTip(anthonyz_, "Character: Tony Corleone");
            _1GUnit1ToolTip.SetToolTip(BFLY003, "Character: Torah Hart");
            _1GUnit1ToolTip.SetToolTip(boscoreli_gaming, "Character: Mike Boscoreli");
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
            refreshBackgroundWorker.RunWorkerAsync();
            refreshButton.Text = "Refreshing";
            refreshButton.Enabled = false;
            FormBorderStyle = FormBorderStyle.Fixed3D;

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
                "Cancel");
            if (result == MessageBoxResult.Yes)
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                cmd.StartInfo.Arguments = "/C data\\streamlink.exe http://twitch.tv/" + streamer + " best";
                cmd.Start();
                Process.Start("https://twitch.tv/" + streamer + "/chat");
            }
            else if (result == MessageBoxResult.No)
            {
                Process.Start("https://twitch.tv/" + streamer);
            }
        }
        private  async void _1GUnit1_Click(object sender, EventArgs e)
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
            alexusnightingale.Text = "alexusnightingal";
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
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/jttroy best");
        }

        private async void kaceytron_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/kaceytron best");
        }

        private async void KaptainKpress_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/kaptainkpress best");
        }

        private async void KatieRouu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/katierouu best");
        }

        private async void Kithicor27_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/kithicor27 best");
        }

        private async void LarryX7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/larrx7 best");
        }

        private async void lawdog1096_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/lawdog1096 best");
        }

        private async void LiftYourGame_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/liftyourgame best");
        }

        private async void loveANF3L_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/loveang3l best");
        }

        private async void mart1n_g_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/mart1n_g best");
        }

        private async void MiltonTPike1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/miltontpike1 best");
        }

        private async void MintsTV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/mintstv best");
        }

        private async void MrMoonsHouse_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/mrmoonshouse best");
        }

        private async void MsDeathRabbit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/msdeathrabbit best");
        }

        private async void Og_BluePill_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/og_bluepill best");
        }

        private async void PENTAhearth_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/pentahearth best");
        }

        private async void Pinky_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/pinky best");
        }

        private async void PmsProxy_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/pmsproxy best");
        }

        private async void PorkMarshmallow_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/marshmallow best");
        }

        private async void PrimusPalus_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/primuspalus best");
        }

        private async void Purrluna_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/purrluna best");
        }

        private async void Pydrex_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/pydrex best");
        }

        private async void RajjPatel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/rajjpatel best");
        }

        private async void Rastafied_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/rastafied best");
        }

        private async void RastaRafikii_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/rastarafikii best");
        }

        private async void SAMZHIT_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/samzhit best");
        }

        private async void Sarapocalypse_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/sarapocalypse best");
        }

        private async void SayeedBlack_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/sayeedblack best");
        }

        private async void SeanKingV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/seankingv best");
        }

        private async void Selvek_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/selvek best");
        }

        private async void ShaZ_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/shaz best");
        }

        private async void SheriffEli_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/sheriffeli best");
        }

        private async void SHPTV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/shptv best");
        }

        private async void SilentSentry_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/silentsentry best");
        }

        private async void SimplyJulian_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/simplyjulian best");
        }

        private async void SirCoffeestain_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/sircoffeestain best");
        }

        private async void SirPinkleston00_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/sirpinkleston00 best");
        }

        private async void SkipGently_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/skipgently best");
        }

        private async void SomeTexas_Dude_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/some_texas_dude best");
        }

        private async void Ssaab_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/ssaab best");
        }

        private async void TastyTV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/tastytv best");
        }

        private async void Thadrius_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/thadrius best");
        }

        private async void TheBuddha3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/thebuddha3 best");
        }

        private async void thelawmangaming_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/thelawmangaming best");
        }

        private async void TigerWriter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/tigerwriter best");
        }

        private async void Timmac_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/timmac best");
        }

        private async void TVSBOH_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/tvsboh best");
        }

        private async void UndeadBaron_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/undeadbaron best");
        }

        private async void ValkyrieSpirit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/valkyriespirit best");
        }

        private async void Will_ko_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/will_ko best");
        }

        private async void willitkimchi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/willitkimchi best");
        }

        private async void Wish_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/wish best");
        }

        private async void X_xZimx_X_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/x_xzimx_x best");
        }

        private async void Xiceman_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/xiceman best");
        }

        private async void XProph3cyx_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/xproph3cyx best");
        }

        private async void Zaquelle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/zaquelle best");
        }

        private async void SheepDog59_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/sheepdog59 best");
        }

        private async void TheRealSpectral_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/therealspectral best");
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshButton.Text = "Refreshing";
            refreshButton.Enabled = false;
            refreshBackgroundWorker.RunWorkerAsync();
        }

        public void refreshBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            String str2 = "true";
            int i = 0;

            int bar = 1;

            //Start of the live check

            //1GUnit1 live check
            string _1guu = @"https://api.twitch.tv/kraken/streams/1gunit1?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var _1guj = new WebClient().DownloadString(_1guu);

            Rootobject _1gur = JsonConvert.DeserializeObject<Rootobject>(_1guj);
            refreshBackgroundWorker.ReportProgress(bar++);
            if (_1gur.stream != null && _1gur.stream.game == "Grand Theft Auto V")
            {
                LiveCheck._1GUnit1Live = "true";
            }
            else
            {
                LiveCheck._1GUnit1Live = "false";
            }
            //AbdulHD Live check
            string abdulhdurl = @"https://api.twitch.tv/kraken/streams/AbDulHD?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var abdulhdjson = new WebClient().DownloadString(abdulhdurl);

            Rootobject abdulhdr = JsonConvert.DeserializeObject<Rootobject>(abdulhdjson);
            refreshBackgroundWorker.ReportProgress(bar++);
            if (abdulhdr.stream != null && abdulhdr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.AbdulHDLive = "true";
            }
            else
            {
                LiveCheck.AbdulHDLive = "false";
            }
            //AgentNorth live check
            string agentnorthurl = @"https://api.twitch.tv/kraken/streams/agentnorth?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var agentnorthjson = new WebClient().DownloadString(agentnorthurl);

            Rootobject agentnorthr = JsonConvert.DeserializeObject<Rootobject>(agentnorthjson);
            refreshBackgroundWorker.ReportProgress(bar++);
            if (agentnorthr.stream != null && agentnorthr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.AgentNorthLive = "true";
            }
            else
            {
                LiveCheck.AgentNorthLive = "false";
            }
            //alexusnightingale live check
            string alexusnightingaleurl = @"https://api.twitch.tv/kraken/streams/alexusnightingale?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var alexusnightingalejson = new WebClient().DownloadString(alexusnightingaleurl);

            Rootobject alexusnightingaler = JsonConvert.DeserializeObject<Rootobject>(alexusnightingalejson);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(alexusnightingaler.stream);
            if (alexusnightingaler.stream != null && alexusnightingaler.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.alexuslive = "true";
            }
            else
            {
                LiveCheck.alexuslive = "false";
            }
            //AndyMilonakis live check
            string andyurl = @"https://api.twitch.tv/kraken/streams/andymilonakis?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var andyjson = new WebClient().DownloadString(andyurl);

            Rootobject andyr = JsonConvert.DeserializeObject<Rootobject>(andyjson);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(andyr.stream);
            if (andyr.stream != null && andyr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.AndyLive = "true";
            }
            else
            {
                LiveCheck.AndyLive = "false";
            }
            //anthonyz_ live check
            string anturl = @"https://api.twitch.tv/kraken/streams/anthonyz_?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var antjson = new WebClient().DownloadString(anturl);

            Rootobject antr = JsonConvert.DeserializeObject<Rootobject>(antjson);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(antr.stream);
            if (antr.stream != null && antr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.antlive = "true";
            }
            else
            {
                LiveCheck.antlive = "false";
            }
            //BFLY003 live check
            string bflyurl = @"https://api.twitch.tv/kraken/streams/BFLY003?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var bflyjson = new WebClient().DownloadString(bflyurl);

            Rootobject bflyr = JsonConvert.DeserializeObject<Rootobject>(bflyjson);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(bflyr.stream);
            if (bflyr.stream != null && bflyr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.bflylive = "true";
            }
            else
            {
                LiveCheck.bflylive = "false";
            }
            //boscoreli live check
            string boscoreliurl = @"https://api.twitch.tv/kraken/streams/boscoreli_gaming?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var boscorelijson = new WebClient().DownloadString(boscoreliurl);

            Rootobject boscorelir = JsonConvert.DeserializeObject<Rootobject>(boscorelijson);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(boscorelir.stream);
            if (boscorelir.stream != null && boscorelir.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.boscolive = "true";
            }
            else
            {
                LiveCheck.boscolive = "false";
            }
            //BPZ live check
            string bpzurl = @"https://api.twitch.tv/kraken/streams/BPZ?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var bpzjson = new WebClient().DownloadString(bpzurl);

            Rootobject bpzr = JsonConvert.DeserializeObject<Rootobject>(bpzjson);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(bpzr.stream);
            if (bpzr.stream != null && bpzr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.bpzlive = "true";
            }
            else
            {
                LiveCheck.bpzlive = "false";
            }
            //BuckkNaked live check
            string buckurl = @"https://api.twitch.tv/kraken/streams/buckknaked?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var buckjson = new WebClient().DownloadString(buckurl);

            Rootobject buckr = JsonConvert.DeserializeObject<Rootobject>(buckjson);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(buckr.stream);
            if (buckr.stream != null && buckr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.bucklive = "true";
            }
            else
            {
                LiveCheck.bucklive = "false";
            }
            //BurkeBlack live check
            string burkeurl = @"https://api.twitch.tv/kraken/streams/BurkeBlack?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var burkej = new WebClient().DownloadString(burkeurl);

            Rootobject burker = JsonConvert.DeserializeObject<Rootobject>(burkej);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(burker.stream);
            if (burker.stream != null && burker.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.burkelive = "true";
            }
            else
            {
                LiveCheck.burkelive = "false";
            }
            //Ch1ckenb0ne live check
            string chicku = @"https://api.twitch.tv/kraken/streams/ch1ckenb0ne?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var chickj = new WebClient().DownloadString(chicku);

            Rootobject chickr = JsonConvert.DeserializeObject<Rootobject>(chickj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(chickr.stream);
            if (chickr.stream != null && chickr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.chicklive = "true";
            }
            else
            {
                LiveCheck.chicklive = "false";
            }
            //ChiefDas live check
            string chiefu = @"https://api.twitch.tv/kraken/streams/ChiefDas?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var chiefj = new WebClient().DownloadString(chiefu);

            Rootobject chiefr = JsonConvert.DeserializeObject<Rootobject>(chiefj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(chiefr.stream);
            if (chiefr.stream != null && chiefr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.chieflive = "true";
            }
            else
            {
                LiveCheck.chieflive = "false";
            }
            //classypax live check
            string classyu = @"https://api.twitch.tv/kraken/streams/ClassyPax?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var classyj = new WebClient().DownloadString(classyu);

            Rootobject classyr = JsonConvert.DeserializeObject<Rootobject>(classyj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(classyr.stream);
            if (classyr.stream != null && classyr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.classlive = "true";
            }
            else
            {
                LiveCheck.classlive = "false";
            }
            //cletusbueford live check
            string cletu = @"https://api.twitch.tv/kraken/streams/cletusbeuford?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var cletj = new WebClient().DownloadString(cletu);

            Rootobject cletr = JsonConvert.DeserializeObject<Rootobject>(cletj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(cletr.stream);
            if (cletr.stream != null && cletr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.cletlive = "true";
            }
            else
            {
                LiveCheck.cletlive = "false";
            }
            //CoolidgeHD live check
            string coolu = @"https://api.twitch.tv/kraken/streams/coolidgehd?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var coolj = new WebClient().DownloadString(coolu);

            Rootobject coolr = JsonConvert.DeserializeObject<Rootobject>(coolj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(coolr.stream);
            if (coolr.stream != null && coolr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.coollive = "true";
            }
            else
            {
                LiveCheck.coollive = "false";
            }
            //dasMehdi live check
            string dasu = @"https://api.twitch.tv/kraken/streams/dasmehdi?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var dasj = new WebClient().DownloadString(dasu);

            Rootobject dasr = JsonConvert.DeserializeObject<Rootobject>(dasj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(dasr.stream);
            if (dasr.stream != null && dasr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.daslive = "true";
            }
            else
            {
                LiveCheck.daslive = "false";
            }
            //DisbeArex live check
            string disu = @"https://api.twitch.tv/kraken/streams/disbearex?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var disj = new WebClient().DownloadString(disu);

            Rootobject disr = JsonConvert.DeserializeObject<Rootobject>(disj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(disr.stream);
            if (disr.stream != null && disr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.dislive = "true";
            }
            else
            {
                LiveCheck.dislive = "false";
            }
            //djkwix live check
            string djku = @"https://api.twitch.tv/kraken/streams/djkwix?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var djkj = new WebClient().DownloadString(djku);

            Rootobject djkr = JsonConvert.DeserializeObject<Rootobject>(djkj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(djkr.stream);
            if (djkr.stream != null && djkr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.djklive = "true";
            }
            else
            {
                LiveCheck.djklive = "false";
            }
            //DrunkBabyYoshi live check
            string drunu = @"https://api.twitch.tv/kraken/streams/drunkbabyyoshi?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var drunj = new WebClient().DownloadString(drunu);

            Rootobject drunr = JsonConvert.DeserializeObject<Rootobject>(drunj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(drunr.stream);
            if (drunr.stream != null && drunr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.drunklive = "true";
            }
            else
            {
                LiveCheck.drunklive = "false";
            }
            //Esoluu live check
            string esou = @"https://api.twitch.tv/kraken/streams/esoluu?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var esoj = new WebClient().DownloadString(esou);

            Rootobject esor = JsonConvert.DeserializeObject<Rootobject>(esoj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(esor.stream);
            if (esor.stream != null && esor.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.esolive = "true";
            }
            else
            {
                LiveCheck.esolive = "false";
            }
            //finkone live check
            string finu = @"https://api.twitch.tv/kraken/streams/finkone?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var finj = new WebClient().DownloadString(finu);

            Rootobject finr = JsonConvert.DeserializeObject<Rootobject>(finj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(finr.stream);
            if (finr.stream != null && finr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.finlive = "true";
            }
            else
            {
                LiveCheck.finlive = "false";
            }
            //Fistofthewalrus live check
            string fisu = @"https://api.twitch.tv/kraken/streams/fistofthewalrus?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var fisj = new WebClient().DownloadString(fisu);

            Rootobject fisr = JsonConvert.DeserializeObject<Rootobject>(fisj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(fisr.stream);
            if (fisr.stream != null && fisr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.fistlive = "true";
            }
            else
            {
                LiveCheck.fistlive = "false";
            }
            //Five0anthO live check
            string fiveu = @"https://api.twitch.tv/kraken/streams/five0antho?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var fivej = new WebClient().DownloadString(fiveu);

            Rootobject fiver = JsonConvert.DeserializeObject<Rootobject>(fivej);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(fiver.stream);
            if (fiver.stream != null && fiver.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.fivelive = "true";
            }
            else
            {
                LiveCheck.fivelive = "false";
            }
            //GeeFamous92 live check
            string geeu = @"https://api.twitch.tv/kraken/streams/geefamous92?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var geej = new WebClient().DownloadString(geeu);

            Rootobject geer = JsonConvert.DeserializeObject<Rootobject>(geej);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(geer.stream);
            if (geer.stream != null && geer.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.geelive = "true";
            }
            else
            {
                LiveCheck.geelive = "false";
            }
            //GhilleGuyTV live check
            string ghiu = @"https://api.twitch.tv/kraken/streams/ghilleguytv?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var ghij = new WebClient().DownloadString(ghiu);

            Rootobject ghir = JsonConvert.DeserializeObject<Rootobject>(ghij);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(ghir.stream);
            if (ghir.stream != null && ghir.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.ghillelive = "true";
            }
            else
            {
                LiveCheck.ghillelive = "false";
            }
            //GiantFaffle live check
            string giau = @"https://api.twitch.tv/kraken/streams/giantfaffle?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var giaj = new WebClient().DownloadString(giau);

            Rootobject giar = JsonConvert.DeserializeObject<Rootobject>(giaj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(giar.stream);
            if (giar.stream != null && giar.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.giantlive = "true";
            }
            else
            {
                LiveCheck.giantlive = "false";
            }
            //GloryD live check
            string glou = @"https://api.twitch.tv/kraken/streams/gloryd?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var gloj = new WebClient().DownloadString(glou);

            Rootobject glor = JsonConvert.DeserializeObject<Rootobject>(gloj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(glor.stream);
            if (glor.stream != null && glor.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.glorylive = "true";
            }
            else
            {
                LiveCheck.glorylive = "false";
            }
            //Harryow live check
            string haru = @"https://api.twitch.tv/kraken/streams/harryow?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var harj = new WebClient().DownloadString(haru);

            Rootobject harr = JsonConvert.DeserializeObject<Rootobject>(harj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(harr.stream);
            if (harr.stream != null && harr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.harrylive = "true";
            }
            else
            {
                LiveCheck.harrylive = "false";
            }
            //Hazard live check
            string hazu = @"https://api.twitch.tv/kraken/streams/hazard?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var hazj = new WebClient().DownloadString(hazu);

            Rootobject hazr = JsonConvert.DeserializeObject<Rootobject>(hazj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(hazr.stream);
            if (hazr.stream != null && hazr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.hazardlive = "true";
            }
            else
            {
                LiveCheck.hazardlive = "false";
            }
            //Hirona live check
            string hiru = @"https://api.twitch.tv/kraken/streams/hirona?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var hirj = new WebClient().DownloadString(hiru);

            Rootobject hirr = JsonConvert.DeserializeObject<Rootobject>(hirj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(hirr.stream);
            if (hirr.stream != null && hirr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.hironalive = "true";
            }
            else
            {
                LiveCheck.hironalive = "false";
            }
            //IamSp00n live check
            string iamu = @"https://api.twitch.tv/kraken/streams/iamsp00n?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var iamj = new WebClient().DownloadString(iamu);

            Rootobject iamr = JsonConvert.DeserializeObject<Rootobject>(iamj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(iamr.stream);
            if (iamr.stream != null && iamr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.iamlive = "true";
            }
            else
            {
                LiveCheck.iamlive = "false";
            }
            //ImmortalLive live check
            string immu = @"https://api.twitch.tv/kraken/streams/immortallive?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var immj = new WebClient().DownloadString(immu);

            Rootobject immr = JsonConvert.DeserializeObject<Rootobject>(immj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(immr.stream);
            if (immr.stream != null && immr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.immlive = "true";
            }
            else
            {
                LiveCheck.immlive = "false";
            }
            //ironmonkeytv live check
            string irou = @"https://api.twitch.tv/kraken/streams/ironmonkeytv?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var iroj = new WebClient().DownloadString(irou);

            Rootobject iror = JsonConvert.DeserializeObject<Rootobject>(iroj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(iror.stream);
            if (iror.stream != null && iror.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.ironlive = "true";
            }
            else
            {
                LiveCheck.ironlive = "false";
            }
            //itzButch live check
            string itzu = @"https://api.twitch.tv/kraken/streams/itzButch?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var itzj = new WebClient().DownloadString(itzu);

            Rootobject itzr = JsonConvert.DeserializeObject<Rootobject>(itzj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(itzr.stream);
            if (itzr.stream != null && itzr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.itzlive = "true";
            }
            else
            {
                LiveCheck.itzlive = "false";
            }
            //J_Reed live check
            string jreu = @"https://api.twitch.tv/kraken/streams/J_reed?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var jrej = new WebClient().DownloadString(jreu);

            Rootobject jrer = JsonConvert.DeserializeObject<Rootobject>(jrej);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(jrer.stream);
            if (jrer.stream != null && jrer.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.jreedlive = "true";
            }
            else
            {
                LiveCheck.jreedlive = "false";
            }
            //JAboodyShow live check
            string jabu = @"https://api.twitch.tv/kraken/streams/jaboodyshow?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var jabj = new WebClient().DownloadString(jabu);

            Rootobject jabr = JsonConvert.DeserializeObject<Rootobject>(jabj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(jabr.stream);
            if (jabr.stream != null && jabr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.jablive = "true";
            }
            else
            {
                LiveCheck.jablive = "false";
            }
            //jake_terek live check
            string jaku = @"https://api.twitch.tv/kraken/streams/jake_terek?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var jakj = new WebClient().DownloadString(jaku);

            Rootobject jakr = JsonConvert.DeserializeObject<Rootobject>(jakj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(jakr.stream);
            if (jakr.stream != null && jakr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.jakelive = "true";
            }
            else
            {
                LiveCheck.jakelive = "false";
            }
            //JmxTwiztid live check
            string jmxu = @"https://api.twitch.tv/kraken/streams/jmxtwiztid?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var jmxj = new WebClient().DownloadString(jmxu);

            Rootobject jmxr = JsonConvert.DeserializeObject<Rootobject>(jmxj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(jmxr.stream);
            if (jmxr.stream != null && jmxr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.jmxlive = "true";
            }
            else
            {
                LiveCheck.jmxlive = "false";
            }
            //John782 live check
            string johu = @"https://api.twitch.tv/kraken/streams/john782?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var johj = new WebClient().DownloadString(johu);

            Rootobject johr = JsonConvert.DeserializeObject<Rootobject>(johj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(johr.stream);
            if (johr.stream != null && johr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.johnlive = "true";
            }
            else
            {
                LiveCheck.johnlive = "false";
            }
            //Jolly__Jess live check
            string jolu = @"https://api.twitch.tv/kraken/streams/Jolly__Jess?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var jolj = new WebClient().DownloadString(jolu);

            Rootobject jolr = JsonConvert.DeserializeObject<Rootobject>(jolj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(jolr.stream);
            if (jolr.stream != null && jolr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.jollylive = "true";
            }
            else
            {
                LiveCheck.jollylive = "false";
            }
            //JTtroy live check
            string jttu = @"https://api.twitch.tv/kraken/streams/Jttroy?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var jttj = new WebClient().DownloadString(jttu);

            Rootobject jttr = JsonConvert.DeserializeObject<Rootobject>(jttj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(jttr.stream);
            if (jttr.stream != null && jttr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.jttlive = "true";
            }
            else
            {
                LiveCheck.jttlive = "false";
            }
            //kaceytron live check
            string kacu = @"https://api.twitch.tv/kraken/streams/kaceytron?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var kacj = new WebClient().DownloadString(kacu);

            Rootobject kacr = JsonConvert.DeserializeObject<Rootobject>(kacj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(kacr.stream);
            if (kacr.stream != null && kacr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.kaceylive = "true";
            }
            else
            {
                LiveCheck.kaceylive = "false";
            }
            //KaptainKPress live check
            string kapu = @"https://api.twitch.tv/kraken/streams/kaptainkpress?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var kapj = new WebClient().DownloadString(kapu);

            Rootobject kapr = JsonConvert.DeserializeObject<Rootobject>(kapj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(kapr.stream);
            if (kapr.stream != null && kapr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.kaptainlive = "true";
            }
            else
            {
                LiveCheck.kaptainlive = "false";
            }
            //KatieRouu live check
            string katu = @"https://api.twitch.tv/kraken/streams/jaboodyshow?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var katj = new WebClient().DownloadString(katu);

            Rootobject katr = JsonConvert.DeserializeObject<Rootobject>(katj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(katr.stream);
            if (katr.stream != null && katr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.katielive = "true";
            }
            else
            {
                LiveCheck.katielive = "false";
            }
            //Kithicor27 live check
            string kitu = @"https://api.twitch.tv/kraken/streams/kithicor27?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var kitj = new WebClient().DownloadString(kitu);

            Rootobject kitr = JsonConvert.DeserializeObject<Rootobject>(kitj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(kitr.stream);
            if (kitr.stream != null && kitr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.kithlive = "true";
            }
            else
            {
                LiveCheck.kithlive = "false";
            }
            //LarryX7 live check
            string laru = @"https://api.twitch.tv/kraken/streams/larryx7?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var larj = new WebClient().DownloadString(laru);

            Rootobject larr = JsonConvert.DeserializeObject<Rootobject>(larj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(larr.stream);
            if (larr.stream != null && larr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.larrylive = "true";
            }
            else
            {
                LiveCheck.larrylive = "false";
            }
            //lawdog1096 live check
            string lawu = @"https://api.twitch.tv/kraken/streams/lawdog1096?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var lawj = new WebClient().DownloadString(lawu);

            Rootobject lawr = JsonConvert.DeserializeObject<Rootobject>(lawj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(lawr.stream);
            if (lawr.stream != null && lawr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.lawdoglive = "true";
            }
            else
            {
                LiveCheck.lawdoglive = "false";
            }
            //LiftYourGame live check
            string lifu = @"https://api.twitch.tv/kraken/streams/lifeyourgame?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var lifj = new WebClient().DownloadString(lifu);

            Rootobject lifr = JsonConvert.DeserializeObject<Rootobject>(lifj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(lifr.stream);
            if (lifr.stream != null && lifr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.liftlive = "true";
            }
            else
            {
                LiveCheck.liftlive = "false";
            }
            //loveANG3L live check
            string lovu = @"https://api.twitch.tv/kraken/streams/loveang3l?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var lovj = new WebClient().DownloadString(lovu);

            Rootobject lovr = JsonConvert.DeserializeObject<Rootobject>(lovj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(lovr.stream);
            if (lovr.stream != null && lovr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.lovelive = "true";
            }
            else
            {
                LiveCheck.lovelive = "false";
            }
            //mart1n_g live check
            string maru = @"https://api.twitch.tv/kraken/streams/mart1n_g?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var marj = new WebClient().DownloadString(maru);

            Rootobject marr = JsonConvert.DeserializeObject<Rootobject>(marj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(marr.stream);
            if (marr.stream != null && marr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.martlive = "true";
            }
            else
            {
                LiveCheck.martlive = "false";
            }
            //MiltonTPike1 live check
            string milu = @"https://api.twitch.tv/kraken/streams/MiltonTPike1?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var milj = new WebClient().DownloadString(milu);

            Rootobject milr = JsonConvert.DeserializeObject<Rootobject>(milj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(milr.stream);
            if (milr.stream != null && milr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.miltonlive = "true";
            }
            else
            {
                LiveCheck.miltonlive = "false";
            }
            //MintsTV live check
            string minu = @"https://api.twitch.tv/kraken/streams/mintstv?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var minj = new WebClient().DownloadString(minu);

            Rootobject minr = JsonConvert.DeserializeObject<Rootobject>(minj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(minr.stream);
            if (minr.stream != null && minr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.mintslive = "true";
            }
            else
            {
                LiveCheck.mintslive = "false";
            }
            //MrMoonsHouse live check
            string mrmu = @"https://api.twitch.tv/kraken/streams/mrmoonshouse?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var mrmj = new WebClient().DownloadString(mrmu);

            Rootobject mrmr = JsonConvert.DeserializeObject<Rootobject>(mrmj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(mrmr.stream);
            if (mrmr.stream != null && mrmr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.mrmoonslive = "true";
            }
            else
            {
                LiveCheck.mrmoonslive = "false";
            }
            //MsDeathRabbit live check
            string msdu = @"https://api.twitch.tv/kraken/streams/msdeathrabbit?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var msdj = new WebClient().DownloadString(msdu);

            Rootobject msdr = JsonConvert.DeserializeObject<Rootobject>(msdj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(msdr.stream);
            if (msdr.stream != null && msdr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.msdeathlive = "true";
            }
            else
            {
                LiveCheck.msdeathlive = "false";
            }
            //OG_BluePill live check
            string ogu = @"https://api.twitch.tv/kraken/streams/og_bluepill?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var ogj = new WebClient().DownloadString(ogu);

            Rootobject ogr = JsonConvert.DeserializeObject<Rootobject>(ogj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(ogr.stream);
            if (ogr.stream != null && ogr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.ogbluepilllive = "true";
            }
            else
            {
                LiveCheck.ogbluepilllive = "false";
            }
            //PENTAhearth live check
            string penu = @"https://api.twitch.tv/kraken/streams/pentahearth?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var penj = new WebClient().DownloadString(penu);

            Rootobject penr = JsonConvert.DeserializeObject<Rootobject>(penj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(penr.stream);
            if (penr.stream != null && penr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.pentalive = "true";
            }
            else
            {
                LiveCheck.pentalive = "false";
            }
            //Pinky live check
            string pinu = @"https://api.twitch.tv/kraken/streams/Pinky?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var pinj = new WebClient().DownloadString(pinu);

            Rootobject pinr = JsonConvert.DeserializeObject<Rootobject>(pinj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(pinr.stream);
            if (pinr.stream != null && pinr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.pinkylive = "true";
            }
            else
            {
                LiveCheck.pinkylive = "false";
            }
            //PmsProxy live check
            string pmsu = @"https://api.twitch.tv/kraken/streams/pmsproxy?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var pmsj = new WebClient().DownloadString(pmsu);

            Rootobject pmsr = JsonConvert.DeserializeObject<Rootobject>(pmsj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(pmsr.stream);
            if (pmsr.stream != null && pmsr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.pmslive = "true";
            }
            else
            {
                LiveCheck.pmslive = "false";
            }
            //PorkMarshmallow live check
            string poru = @"https://api.twitch.tv/kraken/streams/porkmarshmallow?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var porj = new WebClient().DownloadString(poru);

            Rootobject porr = JsonConvert.DeserializeObject<Rootobject>(porj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(porr.stream);
            if (porr.stream != null && porr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.porklive = "true";
            }
            else
            {
                LiveCheck.porklive = "false";
            }
            //PrimusPalus live check
            string priu = @"https://api.twitch.tv/kraken/streams/primuspalus?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var prij = new WebClient().DownloadString(priu);

            Rootobject prir = JsonConvert.DeserializeObject<Rootobject>(prij);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(prir.stream);
            if (prir.stream != null && prir.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.primuslive = "true";
            }
            else
            {
                LiveCheck.primuslive = "false";
            }
            //Purrluna live check
            string puru = @"https://api.twitch.tv/kraken/streams/purrluna?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var purj = new WebClient().DownloadString(puru);

            Rootobject purr = JsonConvert.DeserializeObject<Rootobject>(purj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(purr.stream);
            if (purr.stream != null && purr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.purrlive = "true";
            }
            else
            {
                LiveCheck.purrlive = "false";
            }
            //Pydrex live check
            string pydu = @"https://api.twitch.tv/kraken/streams/Pydrex?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var pydj = new WebClient().DownloadString(pydu);

            Rootobject pydr = JsonConvert.DeserializeObject<Rootobject>(pydj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(pydr.stream);
            if (pydr.stream != null && pydr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.pydrexlive = "true";
            }
            else
            {
                LiveCheck.pydrexlive = "false";
            }
            //RajjPatel Live check
            string raju = @"https://api.twitch.tv/kraken/streams/RajjPatel?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var rajj = new WebClient().DownloadString(raju);

            Rootobject rajr = JsonConvert.DeserializeObject<Rootobject>(rajj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(rajr.stream);
            if (rajr.stream != null && rajr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.rajjlive = "true";
            }
            else
            {
                LiveCheck.rajjlive = "false";
            }
            //Rastafied Live check
            string rastafu = @"https://api.twitch.tv/kraken/streams/rastafied?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var rastafj = new WebClient().DownloadString(rastafu);

            Rootobject rastafr = JsonConvert.DeserializeObject<Rootobject>(rastafj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(rastafr.stream);
            if (rastafr.stream != null && rastafr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.rastafiedlive = "true";
            }
            else
            {
                LiveCheck.rastafiedlive = "false";
            }
            //RastaRafikii Live check
            string rru = @"https://api.twitch.tv/kraken/streams/Rasterafikii?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var rrj = new WebClient().DownloadString(rru);

            Rootobject rrr = JsonConvert.DeserializeObject<Rootobject>(rrj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(rrr.stream);
            if (rrr.stream != null && rrr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.rastarlive = "true";
            }
            else
            {
                LiveCheck.rastarlive = "false";
            }
            //Samzhit Live check
            string samu = @"https://api.twitch.tv/kraken/streams/samzhit?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var samj = new WebClient().DownloadString(samu);

            Rootobject samr = JsonConvert.DeserializeObject<Rootobject>(samj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(rajr.stream);
            if (samr.stream != null && samr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.samlive = "true";
            }
            else
            {
                LiveCheck.samlive = "false";
            }
            //Sarapocalypse Live check
            string saru = @"https://api.twitch.tv/kraken/streams/sarapocalypse?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var sarj = new WebClient().DownloadString(saru);

            Rootobject sarr = JsonConvert.DeserializeObject<Rootobject>(sarj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(sarr.stream);
            if (sarr.stream != null && sarr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.saralive = "true";
            }
            else
            {
                LiveCheck.saralive = "false";
            }
            //SayeedBlack Live check
            string sayu = @"https://api.twitch.tv/kraken/streams/sayeedblack?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var sayj = new WebClient().DownloadString(sayu);

            Rootobject sayr = JsonConvert.DeserializeObject<Rootobject>(sayj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(sayr.stream);
            if (sayr.stream != null && sayr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.sayeedlive = "true";
            }
            else
            {
                LiveCheck.sayeedlive = "false";
            }
            //SeanKingV Live check
            string seau = @"https://api.twitch.tv/kraken/streams/seankingv?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var seaj = new WebClient().DownloadString(seau);

            Rootobject sear = JsonConvert.DeserializeObject<Rootobject>(seaj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(sear.stream);
            if (sear.stream != null && sear.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.seanalive = "true";
            }
            else
            {
                LiveCheck.seanalive = "false";
            }
            //Selvek Live check
            string selu = @"https://api.twitch.tv/kraken/streams/selvek?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var selj = new WebClient().DownloadString(selu);

            Rootobject selr = JsonConvert.DeserializeObject<Rootobject>(selj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(selr.stream);
            if (selr.stream != null && selr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.selvek = "true";
            }
            else
            {
                LiveCheck.selvek = "false";
            }
            //ShaZ Live check
            string shau = @"https://api.twitch.tv/kraken/streams/ShaZ?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var shaj = new WebClient().DownloadString(shau);

            Rootobject shar = JsonConvert.DeserializeObject<Rootobject>(shaj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(shar.stream);
            if (shar.stream != null && shar.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.shazlive = "true";
            }
            else
            {
                LiveCheck.shazlive = "false";
            }
            //SheriffEli Live check
            string sheu = @"https://api.twitch.tv/kraken/streams/sheriffeli?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var shej = new WebClient().DownloadString(sheu);

            Rootobject sher = JsonConvert.DeserializeObject<Rootobject>(shej);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(sher.stream);
            if (sher.stream != null && sher.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.sherifflive = "true";
            }
            else
            {
                LiveCheck.sherifflive = "false";
            }
            //SHP_TV Live check
            string shpu = @"https://api.twitch.tv/kraken/streams/shp_tv?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var shpj = new WebClient().DownloadString(shpu);

            Rootobject shpr = JsonConvert.DeserializeObject<Rootobject>(shpj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(shpr.stream);
            if (shpr.stream != null && shpr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.shptvlive = "true";
            }
            else
            {
                LiveCheck.shptvlive = "false";
            }
            //SilentSentry Live check
            string silu = @"https://api.twitch.tv/kraken/streams/silentsentry?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var silj = new WebClient().DownloadString(silu);

            Rootobject silr = JsonConvert.DeserializeObject<Rootobject>(silj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(silr.stream);
            if (silr.stream != null && silr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.silentlive = "true";
            }
            else
            {
                LiveCheck.silentlive = "false";
            }
            //SimplyJulian Live check
            string simu = @"https://api.twitch.tv/kraken/streams/SimplyJulian?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var simj = new WebClient().DownloadString(simu);

            Rootobject simr = JsonConvert.DeserializeObject<Rootobject>(simj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(simr.stream);
            if (simr.stream != null && simr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.simplylive = "true";
            }
            else
            {
                LiveCheck.simplylive = "false";
            }
            //SirCoffeestain Live check
            string siru = @"https://api.twitch.tv/kraken/streams/sircoffeestain?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var sirj = new WebClient().DownloadString(siru);

            Rootobject sirr = JsonConvert.DeserializeObject<Rootobject>(sirj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(sirr.stream);
            if (sirr.stream != null && sirr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.sircoffeelive = "true";
            }
            else
            {
                LiveCheck.sircoffeelive = "false";
            }
            //SirPinkleston00 Live check
            string sirpu = @"https://api.twitch.tv/kraken/streams/sirpinkleton00?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var sirpj = new WebClient().DownloadString(sirpu);

            Rootobject sirpr = JsonConvert.DeserializeObject<Rootobject>(sirpj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(sirpr.stream);
            if (sirpr.stream != null && sirpr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.sirpinklive = "true";
            }
            else
            {
                LiveCheck.sirpinklive = "false";
            }
            //SkipGently Live check
            string skiu = @"https://api.twitch.tv/kraken/streams/skipgently?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var skij = new WebClient().DownloadString(skiu);

            Rootobject skir = JsonConvert.DeserializeObject<Rootobject>(skij);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(skir.stream);
            if (skir.stream != null && skir.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.skiplive = "true";
            }
            else
            {
                LiveCheck.skiplive = "false";
            }
            //Some_Texas_Dude Live check
            string somu = @"https://api.twitch.tv/kraken/streams/some_texas_dude?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var somj = new WebClient().DownloadString(somu);

            Rootobject somr = JsonConvert.DeserializeObject<Rootobject>(somj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(somr.stream);
            if (somr.stream != null && somr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.sometexaslive = "true";
            }
            else
            {
                LiveCheck.sometexaslive = "false";
            }
            //Ssaab Live check
            string ssau = @"https://api.twitch.tv/kraken/streams/ssaab?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var ssaj = new WebClient().DownloadString(ssau);

            Rootobject ssar = JsonConvert.DeserializeObject<Rootobject>(ssaj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(ssar.stream);
            if (ssar.stream != null && ssar.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.ssaablive = "true";
            }
            else
            {
                LiveCheck.ssaablive = "false";
            }
            //TastyTV Live check
            string tasu = @"https://api.twitch.tv/kraken/streams/tastytv?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var tasj = new WebClient().DownloadString(tasu);

            Rootobject tasr = JsonConvert.DeserializeObject<Rootobject>(tasj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(tasr.stream);
            if (tasr.stream != null && tasr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.tastylive = "true";
            }
            else
            {
                LiveCheck.tastylive = "false";
            }
            //Thadrius Live check
            string thau = @"https://api.twitch.tv/kraken/streams/thadrius?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var thaj = new WebClient().DownloadString(thau);

            Rootobject thar = JsonConvert.DeserializeObject<Rootobject>(thaj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(thar.stream);
            if (thar.stream != null && thar.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.thadlive = "true";
            }
            else
            {
                LiveCheck.thadlive = "false";
            }
            //TheBuddha3 Live check
            string theu = @"https://api.twitch.tv/kraken/streams/thebuddha3?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var thej = new WebClient().DownloadString(theu);

            Rootobject ther = JsonConvert.DeserializeObject<Rootobject>(thej);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(ther.stream);
            if (ther.stream != null && ther.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.thebuddhalive = "true";
            }
            else
            {
                LiveCheck.thebuddhalive = "false";
            }
            //thelawmangaming Live check
            string thelu = @"https://api.twitch.tv/kraken/streams/thelawmangaming?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var thelj = new WebClient().DownloadString(thelu);

            Rootobject thelr = JsonConvert.DeserializeObject<Rootobject>(thelj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(thelr.stream);
            if (thelr.stream != null && thelr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.thelawlive = "true";
            }
            else
            {
                LiveCheck.thelawlive = "false";
            }
            //TigerWrite Live check
            string tigu = @"https://api.twitch.tv/kraken/streams/tigerwriter?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var tigj = new WebClient().DownloadString(tigu);

            Rootobject tigr = JsonConvert.DeserializeObject<Rootobject>(tigj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(tigr.stream);
            if (tigr.stream != null && tigr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.tigerwriterlive = "true";
            }
            else
            {
                LiveCheck.tigerwriterlive = "false";
            }
            //Timmac Live check
            string timu = @"https://api.twitch.tv/kraken/streams/Timmac?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var timj = new WebClient().DownloadString(timu);

            Rootobject timr = JsonConvert.DeserializeObject<Rootobject>(timj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(timr.stream);
            if (timr.stream != null && timr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.timmaclive = "true";
            }
            else
            {
                LiveCheck.timmaclive = "false";
            }
            //TVSBOH Live check
            string tvsu = @"https://api.twitch.tv/kraken/streams/tvsboh?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var tvsj = new WebClient().DownloadString(tvsu);

            Rootobject tvsr = JsonConvert.DeserializeObject<Rootobject>(tvsj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(tvsr.stream);
            if (tvsr.stream != null && tvsr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.tvsbohlive = "true";
            }
            else
            {
                LiveCheck.tvsbohlive = "false";
            }
            //UndeadBaron Live check
            string undu = @"https://api.twitch.tv/kraken/streams/undeadbaron?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var undj = new WebClient().DownloadString(undu);

            Rootobject undr = JsonConvert.DeserializeObject<Rootobject>(undj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(undr.stream);
            if (undr.stream != null && undr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.undeadbro = "true";
            }
            else
            {
                LiveCheck.undeadbro = "false";
            }
            //ValkyrieSpirit Live check
            string valu = @"https://api.twitch.tv/kraken/streams/valkyriespirit?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var valj = new WebClient().DownloadString(valu);

            Rootobject valr = JsonConvert.DeserializeObject<Rootobject>(valj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(valr.stream);
            if (valr.stream != null && valr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.valkyrielive = "true";
            }
            else
            {
                LiveCheck.valkyrielive = "false";
            }
            //Will_ko Live check
            string wilu = @"https://api.twitch.tv/kraken/streams/will_ko?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var wilj = new WebClient().DownloadString(wilu);

            Rootobject wilr = JsonConvert.DeserializeObject<Rootobject>(wilj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(wilr.stream);
            if (wilr.stream != null && wilr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.willkolive = "true";
            }
            else
            {
                LiveCheck.willkolive = "false";
            }
            //willitkimchi Live check
            string willu = @"https://api.twitch.tv/kraken/streams/willitkimchi?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var willj = new WebClient().DownloadString(willu);

            Rootobject willr = JsonConvert.DeserializeObject<Rootobject>(willj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(willr.stream);
            if (willr.stream != null && willr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.kimchilive = "true";
            }
            else
            {
                LiveCheck.kimchilive = "false";
            }
            //Wish Live check
            string wisu = @"https://api.twitch.tv/kraken/streams/wish?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var wisj = new WebClient().DownloadString(wisu);

            Rootobject wisr = JsonConvert.DeserializeObject<Rootobject>(wisj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(wisr.stream);
            if (wisr.stream != null && wisr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.wishlive = "true";
            }
            else
            {
                LiveCheck.wishlive = "false";
            }
            //X_xZimx_X Live check
            string zimu = @"https://api.twitch.tv/kraken/streams/x_xzimx_x?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var zimj = new WebClient().DownloadString(zimu);

            Rootobject zimr = JsonConvert.DeserializeObject<Rootobject>(zimj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(zimr.stream);
            if (zimr.stream != null && zimr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.zimlive = "true";
            }
            else
            {
                LiveCheck.zimlive = "false";
            }
            //Xiceman Live check
            string xicu = @"https://api.twitch.tv/kraken/streams/xiceman?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var xicj = new WebClient().DownloadString(xicu);

            Rootobject xicr = JsonConvert.DeserializeObject<Rootobject>(xicj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(xicr.stream);
            if (xicr.stream != null && xicr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.xicemanlive = "true";
            }
            else
            {
                LiveCheck.xicemanlive = "false";
            }
            //XProph3cyx Live check
            string xpru = @"https://api.twitch.tv/kraken/streams/xproph3cyx?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var xprj = new WebClient().DownloadString(xpru);

            Rootobject xprr = JsonConvert.DeserializeObject<Rootobject>(xprj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(xprr.stream);
            if (xprr.stream != null && xprr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.prophlive = "true";
            }
            else
            {
                LiveCheck.prophlive = "false";
            }
            //Zaquelle Live check
            string zaqu = @"https://api.twitch.tv/kraken/streams/Zaquelle?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var zaqj = new WebClient().DownloadString(zaqu);

            Rootobject zaqr = JsonConvert.DeserializeObject<Rootobject>(zaqj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(zaqr.stream);
            if (zaqr.stream != null && zaqr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.zaquellelive = "true";
            }
            else
            {
                LiveCheck.zaquellelive = "false";
            }
            //TheRealSpectral Live check
            string theru = @"https://api.twitch.tv/kraken/streams/therealspectral?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var therj = new WebClient().DownloadString(theru);

            Rootobject therr = JsonConvert.DeserializeObject<Rootobject>(zaqj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(zaqr.stream);
            if (therr.stream != null && therr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.thereallive = "true";
            }
            else
            {
                LiveCheck.thereallive = "false";
            }
            //SheepDog59 Live check
            string sheeu = @"https://api.twitch.tv/kraken/streams/sheepdog59?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var sheej = new WebClient().DownloadString(sheeu);

            Rootobject sheer = JsonConvert.DeserializeObject<Rootobject>(sheej);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(zaqr.stream);
            if (sheer.stream != null && sheer.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.sheepdoglive = "true";
            }
            else
            {
                LiveCheck.sheepdoglive = "false";
            }
            //SAffypie101 Live check
            string saffyu = @"https://api.twitch.tv/kraken/streams/saffypie101?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var saffyj = new WebClient().DownloadString(saffyu);

            Rootobject saffyr = JsonConvert.DeserializeObject<Rootobject>(saffyj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(zaqr.stream);
            if (saffyr.stream != null && saffyr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.saffylive = "true";
            }
            else
            {
                LiveCheck.saffylive = "false";
            }
            //mythematic Live check
            string mythu = @"https://api.twitch.tv/kraken/streams/mythematic?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var mythj = new WebClient().DownloadString(mythu);

            Rootobject mythr = JsonConvert.DeserializeObject<Rootobject>(mythj);
            refreshBackgroundWorker.ReportProgress(bar++);
            //Console.WriteLine(zaqr.stream);
            if (mythr.stream != null && mythr.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.mythematiclive = "true";
            }
            else
            {
                LiveCheck.mythematiclive = "false";
            }

            //Start of the button updates

            //1GUnit1 live check
            Console.WriteLine("1GUnit1 live? " + LiveCheck._1GUnit1Live);
            string _1gus = LiveCheck._1GUnit1Live;
            if (_1gus == str2)
            {
                _1GUnit1.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                _1GUnit1.BackColor = Color.IndianRed;
            }
            //AbdulHD Live check
            Console.WriteLine("AbdulHD live? " + LiveCheck.AbdulHDLive);
            string abds = LiveCheck.AbdulHDLive;
            if (abds == str2)
            {
                AbdulHD.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                AbdulHD.BackColor = Color.IndianRed;
            }
            //AgentNorth live check
            Console.WriteLine("AgentNorth live? " + LiveCheck.AgentNorthLive);
            string agentnorths = LiveCheck.AgentNorthLive;
            if (agentnorths == str2)
            {
                AgentNorth.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                AgentNorth.BackColor = Color.IndianRed;
            }
            //alexusnightingale live check
            //Console.WriteLine(alexusnightingaler.stream);
            string alexs = LiveCheck.alexuslive;
            if (alexs == str2)
            {
                alexusnightingale.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                alexusnightingale.BackColor = Color.IndianRed;
            }
            //AndyMilonakis live check
            //Console.WriteLine(andyr.stream);
            string andys = LiveCheck.AndyLive;
            if (andys == str2)
            {
                AndyMilonakis.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                AndyMilonakis.BackColor = Color.IndianRed;
            }
            //anthonyz_ live check+
            //Console.WriteLine(antr.stream);
            string ants = LiveCheck.antlive;
            if (ants == str2)
            {
                anthonyz_.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                anthonyz_.BackColor = Color.IndianRed;
            }
            //BFLY003 live check
            //Console.WriteLine(bflyr.stream);
            string bflys = LiveCheck.bflylive;
            if (bflys == str2)
            {
                BFLY003.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                BFLY003.BackColor = Color.IndianRed;
            }
            //boscoreli live check
            //Console.WriteLine(boscorelir.stream);
            string boscos = LiveCheck.boscolive;
            if (boscos == str2)
            {
                boscoreli_gaming.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                boscoreli_gaming.BackColor = Color.IndianRed;
            }
            //BPZ live check
            //Console.WriteLine(bpzr.stream);
            string bpzs = LiveCheck.bpzlive;
            if (bpzs == str2)
            {
                BPZ.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                BPZ.BackColor = Color.IndianRed;
            }
            //BuckkNaked live check
            //Console.WriteLine(buckr.stream);
            string buckks = LiveCheck.bucklive;
            if (buckks == str2)
            {
                BuckkNaked.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                BuckkNaked.BackColor = Color.IndianRed;
            }
            //BurkeBlack live check
            //Console.WriteLine(burker.stream);
            string burkes = LiveCheck.burkelive;
            if (burkes == str2)
            {
                BurkeBlack.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                BurkeBlack.BackColor = Color.IndianRed;
            }
            //Ch1ckenb0ne live check
            //Console.WriteLine(chickr.stream);
            string chicks = LiveCheck.chicklive;
            if (chicks == str2)
            {
                Ch1ckenb0ne.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Ch1ckenb0ne.BackColor = Color.IndianRed;
            }
            //ChiefDas live check
            //Console.WriteLine(chiefr.stream);
            string chiefs = LiveCheck.chieflive;
            if (chiefs == str2)
            {
                ChiefDas.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                ChiefDas.BackColor = Color.IndianRed;
            }
            //classypax live check
            //Console.WriteLine(classyr.stream);
            string classys = LiveCheck.classlive;
            if (classys == str2)
            {
                ClassyPax.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                ClassyPax.BackColor = Color.IndianRed;
            }
            //cletusbueford live check
            //Console.WriteLine(cletr.stream);
            string clets = LiveCheck.cletlive;
            if (clets == str2)
            {
                CletusBueford.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                CletusBueford.BackColor = Color.IndianRed;
            }
            //CoolidgeHD live check
            //Console.WriteLine(coolr.stream);
            string cools = LiveCheck.coollive;
            if (cools == str2)
            {
                CoolidgeHD.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                CoolidgeHD.BackColor = Color.IndianRed;
            }
            //dasMehdi live check
            //Console.WriteLine(dasr.stream);
            string dass = LiveCheck.daslive;
            if (dass == str2)
            {
                dasMehdi.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                dasMehdi.BackColor = Color.IndianRed;
            }
            //DisbeArex live check
            //Console.WriteLine(disr.stream);
            string diss = LiveCheck.dislive;
            if (diss == str2)
            {
                DisbeArex.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                DisbeArex.BackColor = Color.IndianRed;
            }
            //djkwix live check
            //Console.WriteLine(djkr.stream);
            string djks = LiveCheck.djklive;
            if (djks == str2)
            {
                djkwix.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                djkwix.BackColor = Color.IndianRed;
            }
            //DrunkBabyYoshi live check
            //Console.WriteLine(drunr.stream);
            string druns = LiveCheck.drunklive;
            if (druns == str2)
            {
                DrunkBabyYoshi.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                DrunkBabyYoshi.BackColor = Color.IndianRed;
            }
            //Esoluu live check
            //Console.WriteLine(esor.stream);
            string esos = LiveCheck.esolive;
            if (esos == str2)
            {
                Esoluu.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Esoluu.BackColor = Color.IndianRed;
            }
            //finkone live check
            //Console.WriteLine(finr.stream);
            string fins = LiveCheck.finlive;
            if (fins == str2)
            {
                Finkone.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Finkone.BackColor = Color.IndianRed;
            }
            //Fistofthewalrus live check
            //Console.WriteLine(fisr.stream);
            string fiss = LiveCheck.fistlive;
            if (fiss == str2)
            {
                FistofTheWalrus.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                FistofTheWalrus.BackColor = Color.IndianRed;
            }
            //Five0anthO live check
            //Console.WriteLine(fiver.stream);
            string fives = LiveCheck.fivelive;
            if (fives == str2)
            {
                Five0AnthO.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Five0AnthO.BackColor = Color.IndianRed;
            }
            //GeeFamous92 live check
            //Console.WriteLine(geer.stream);
            string gees = LiveCheck.geelive;
            if (gees == str2)
            {
                GeeFamous92.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                GeeFamous92.BackColor = Color.IndianRed;
            }
            //GhilleGuyTV live check
            //Console.WriteLine(ghir.stream);
            string ghis = LiveCheck.ghillelive;
            if (ghis == str2)
            {
                GhilleGuyTV.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                GhilleGuyTV.BackColor = Color.IndianRed;
            }
            //GiantFaffle live check
            //Console.WriteLine(giar.stream);
            string gias = LiveCheck.giantlive;
            if (gias == str2)
            {
                GiantFaffle.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                GiantFaffle.BackColor = Color.IndianRed;
            }
            //GloryD live check
            //Console.WriteLine(glor.stream);
            string glos = LiveCheck.glorylive;
            if (glos == str2)
            {
                GloryD.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                GloryD.BackColor = Color.IndianRed;
            }
            //Harryow live check
            //Console.WriteLine(harr.stream);
            string hars = LiveCheck.harrylive;
            if (hars == str2)
            {
                Harryow.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Harryow.BackColor = Color.IndianRed;
            }
            //Hazard live check
            //Console.WriteLine(hazr.stream);
            string hazs = LiveCheck.hazardlive;
            if (hazs == str2)
            {
                Hazard.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Hazard.BackColor = Color.IndianRed;
            }
            //Hirona live check
            //Console.WriteLine(hirr.stream);
            string hirs = LiveCheck.hironalive;
            if (hirs == str2)
            {
                Hirona.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Hirona.BackColor = Color.IndianRed;
            }
            //IamSp00n live check
            //Console.WriteLine(iamr.stream);
            string iams = LiveCheck.iamlive;
            if (iams == str2)
            {
                IAmSp00n.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                IAmSp00n.BackColor = Color.IndianRed;
            }
            //ImmortalLive live check
            //Console.WriteLine(immr.stream);
            string imms = LiveCheck.immlive;
            if (imms == str2)
            {
                ImmortalLive.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                ImmortalLive.BackColor = Color.IndianRed;
            }
            //ironmonkeytv live check
            //Console.WriteLine(iror.stream);
            string irons = LiveCheck.ironlive;
            if (irons == str2)
            {
                ironmonkeytv.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                ironmonkeytv.BackColor = Color.IndianRed;
            }
            //itzButch live check
            //Console.WriteLine(itzr.stream);
            string itzs = LiveCheck.itzlive;
            if (itzs == str2)
            {
                itzButch.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                itzButch.BackColor = Color.IndianRed;
            }
            //J_Reed live check
            //Console.WriteLine(jrer.stream);
            string jres = LiveCheck.jreedlive;
            if (jres == str2)
            {
                J_Reed.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                J_Reed.BackColor = Color.IndianRed;
            }
            //JAboodyShow live check
            //Console.WriteLine(jabr.stream);
            string jabs = LiveCheck.jablive;
            if (jabs == str2)
            {
                JaboodyShow.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                JaboodyShow.BackColor = Color.IndianRed;
            }
            //jake_terek live check
            //Console.WriteLine(jakr.stream);
            string jaks = LiveCheck.jakelive;
            if (jaks == str2)
            {
                jake_terek.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                jake_terek.BackColor = Color.IndianRed;
            }
            //JmxTwiztid live check
            //Console.WriteLine(jmxr.stream);
            string jmxs = LiveCheck.jmxlive;
            if (jmxs == str2)
            {
                JmxTwiztid.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                JmxTwiztid.BackColor = Color.IndianRed;
            }
            //John782 live check
            //Console.WriteLine(johr.stream);
            string johs = LiveCheck.johnlive;
            if (johs == str2)
            {
                John782.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                John782.BackColor = Color.IndianRed;
            }
            //Jolly__Jess live check
            //Console.WriteLine(jolr.stream);
            string jols = LiveCheck.jollylive;
            if (jols == str2)
            {
                Jolly__Jess.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Jolly__Jess.BackColor = Color.IndianRed;
            }
            //JTtroy live check
            //Console.WriteLine(jttr.stream);
            string jtts = LiveCheck.jttlive;
            if (jtts == str2)
            {
                JTtroy.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                JTtroy.BackColor = Color.IndianRed;
            }
            //kaceytron live check
            //Console.WriteLine(kacr.stream);
            string kaces = LiveCheck.kaceylive;
            if (kaces == str2)
            {
                kaceytron.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                kaceytron.BackColor = Color.IndianRed;
            }
            //KaptainKPress live check
            //Console.WriteLine(kapr.stream);
            string kaps = LiveCheck.kaptainlive;
            if (kaps == str2)
            {
                KaptainKpress.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                KaptainKpress.BackColor = Color.IndianRed;
            }
            //KatieRouu live check
            //Console.WriteLine(katr.stream);
            string kats = LiveCheck.katielive;
            if (kats == str2)
            {
                KatieRouu.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                KatieRouu.BackColor = Color.IndianRed;
            }
            //Kithicor27 live check
            //Console.WriteLine(kitr.stream);
            string kiths = LiveCheck.kithlive;
            if (kiths == str2)
            {
                Kithicor27.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Kithicor27.BackColor = Color.IndianRed;
            }
            //LarryX7 live check
            //Console.WriteLine(larr.stream);
            string lars = LiveCheck.larrylive;
            if (lars == str2)
            {
                LarryX7.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                LarryX7.BackColor = Color.IndianRed;
            }
            //lawdog1096 live check
            //Console.WriteLine(lawr.stream);
            string laws = LiveCheck.lawdoglive;
            if (laws == str2)
            {
                lawdog1096.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                lawdog1096.BackColor = Color.IndianRed;
            }
            //LiftYourGame live check
            //Console.WriteLine(lifr.stream);
            string lifts = LiveCheck.liftlive;
            if (lifts == str2)
            {
                LiftYourGame.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                LiftYourGame.BackColor = Color.IndianRed;
            }
            //loveANG3L live check
            //Console.WriteLine(lovr.stream);
            string lovs = LiveCheck.lovelive;
            if (lovs == str2)
            {
                loveANF3L.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                loveANF3L.BackColor = Color.IndianRed;
            }
            //mart1n_g live check
            //Console.WriteLine(marr.stream);
            string mars = LiveCheck.martlive;
            if (mars == str2)
            {
                mart1n_g.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                mart1n_g.BackColor = Color.IndianRed;
            }
            //MiltonTPike1 live check
            //Console.WriteLine(milr.stream);
            string mils = LiveCheck.miltonlive;
            if (mils == str2)
            {
                MiltonTPike1.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                MiltonTPike1.BackColor = Color.IndianRed;
            }
            //MintsTV live check
            //Console.WriteLine(minr.stream);
            string mins = LiveCheck.mintslive;
            if (mins == str2)
            {
                MintsTV.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                MintsTV.BackColor = Color.IndianRed;
            }
            //MrMoonsHouse live check
            //Console.WriteLine(mrmr.stream);
            string mrms = LiveCheck.mrmoonslive;
            if (mrms == str2)
            {
                MrMoonsHouse.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                MrMoonsHouse.BackColor = Color.IndianRed;
            }
            //MsDeathRabbit live check
            //Console.WriteLine(msdr.stream);
            string msds = LiveCheck.msdeathlive;
            if (msds == str2)
            {
                MsDeathRabbit.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                MsDeathRabbit.BackColor = Color.IndianRed;
            }
            //OG_BluePill live check
            //Console.WriteLine(ogr.stream);
            string ogs = LiveCheck.ogbluepilllive;
            if (ogs == str2)
            {
                Og_BluePill.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Og_BluePill.BackColor = Color.IndianRed;
            }
            //PENTAhearth live check
            //Console.WriteLine(penr.stream);
            string pens = LiveCheck.pentalive;
            if (pens == str2)
            {
                PENTAhearth.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                PENTAhearth.BackColor = Color.IndianRed;
            }
            //Pinky live check
            //Console.WriteLine(pinr.stream);
            string pins = LiveCheck.pinkylive;
            if (pins == str2)
            {
                Pinky.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Pinky.BackColor = Color.IndianRed;
            }
            //PmsProxy live check
            //Console.WriteLine(pmsr.stream);
            string pmss = LiveCheck.pmslive;
            if (pmss == str2)
            {
                PmsProxy.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                PmsProxy.BackColor = Color.IndianRed;
            }
            //PorkMarshmallow live check
            //Console.WriteLine(porr.stream);
            string pors = LiveCheck.porklive;
            if (pors == str2)
            {
                PorkMarshmallow.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                PorkMarshmallow.BackColor = Color.IndianRed;
            }
            //PrimusPalus live check
            //Console.WriteLine(prir.stream);
            string pris = LiveCheck.primuslive;
            if (pris == str2)
            {
                PrimusPalus.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                PrimusPalus.BackColor = Color.IndianRed;
            }
            //Purrluna live check
            //Console.WriteLine(purr.stream);
            string purs = LiveCheck.purrlive;
            if (purs == str2)
            {
                Purrluna.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Purrluna.BackColor = Color.IndianRed;
            }
            //Pydrex live check
            //Console.WriteLine(pydr.stream);
            string pyds = LiveCheck.pydrexlive;
            if (pyds == str2)
            {
                Pydrex.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Pydrex.BackColor = Color.IndianRed;
            }
            //RajjPatel Live check
            //Console.WriteLine(rajr.stream);
            string rajs = LiveCheck.rajjlive;
            if (rajs == str2)
            {
                RajjPatel.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                RajjPatel.BackColor = Color.IndianRed;
            }
            //Rastafied Live check
            //Console.WriteLine(rastafr.stream);
            string rastas = LiveCheck.rastafiedlive;
            if (rastas == str2)
            {
                Rastafied.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Rastafied.BackColor = Color.IndianRed;
            }
            //RastaRafikii Live check
            //Console.WriteLine(rrr.stream);
            string rasrs = LiveCheck.rastarlive;
            if (rasrs == str2)
            {
                RastaRafikii.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                RastaRafikii.BackColor = Color.IndianRed;
            }
            //Samzhit Live check
            //Console.WriteLine(rajr.stream);
            string sams = LiveCheck.samlive;
            if (sams == str2)
            {
                SAMZHIT.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                SAMZHIT.BackColor = Color.IndianRed;
            }
            //Sarapocalypse Live check
            //Console.WriteLine(sarr.stream);
            string saras = LiveCheck.saralive;
            if (saras == str2)
            {
                Sarapocalypse.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Sarapocalypse.BackColor = Color.IndianRed;
            }
            //SayeedBlack Live check
            //Console.WriteLine(sayr.stream);
            string says = LiveCheck.sayeedlive;
            if (says == str2)
            {
                SayeedBlack.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                SayeedBlack.BackColor = Color.IndianRed;
            }
            //SeanKingV Live check
            //Console.WriteLine(sear.stream);
            string seas = LiveCheck.seanalive;
            if (seas == str2)
            {
                SeanKingV.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                SeanKingV.BackColor = Color.IndianRed;
            }
            //Selvek Live check
            //Console.WriteLine(selr.stream);
            string sels = LiveCheck.selvek;
            if (sels == str2)
            {
                Selvek.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Selvek.BackColor = Color.IndianRed;
            }
            //ShaZ Live check
            //Console.WriteLine(shar.stream);
            string shas = LiveCheck.shazlive;
            if (shas == str2)
            {
                ShaZ.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                ShaZ.BackColor = Color.IndianRed;
            }
            //SheriffEli Live check
            //Console.WriteLine(sher.stream);
            string shers = LiveCheck.sherifflive;
            if (shers == str2)
            {
                SheriffEli.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                SheriffEli.BackColor = Color.IndianRed;
            }
            //SHP_TV Live check
            //Console.WriteLine(shpr.stream);
            string shps = LiveCheck.shptvlive;
            if (shps == str2)
            {
                SHPTV.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                SHPTV.BackColor = Color.IndianRed;
            }
            //SilentSentry Live check
            //Console.WriteLine(silr.stream);
            string sils = LiveCheck.silentlive;
            if (sils == str2)
            {
                SilentSentry.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                SilentSentry.BackColor = Color.IndianRed;
            }
            //SimplyJulian Live check
            //Console.WriteLine(simr.stream);
            string sims = LiveCheck.simplylive;
            if (sims == str2)
            {
                SimplyJulian.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                SimplyJulian.BackColor = Color.IndianRed;
            }
            //SirCoffeestain Live check
            //Console.WriteLine(sirr.stream);
            string sirs = LiveCheck.sircoffeelive;
            if (sirs == str2)
            {
                SirCoffeestain.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                SirCoffeestain.BackColor = Color.IndianRed;
            }
            //SirPinkleston00 Live check
            //Console.WriteLine(sirpr.stream);
            string sirps = LiveCheck.sirpinklive;
            if (sirps == str2)
            {
                SirPinkleton00.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                SirPinkleton00.BackColor = Color.IndianRed;
            }
            //SkipGently Live check
            //Console.WriteLine(skir.stream);
            string skis = LiveCheck.skiplive;
            if (skis == str2)
            {
                SkipGently.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                SkipGently.BackColor = Color.IndianRed;
            }
            //Some_Texas_Dude Live check
            //Console.WriteLine(somr.stream);
            string soms = LiveCheck.sometexaslive;
            if (soms == str2)
            {
                SomeTexas_Dude.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                SomeTexas_Dude.BackColor = Color.IndianRed;
            }
            //Ssaab Live check
            //Console.WriteLine(ssar.stream);
            string ssas = LiveCheck.ssaablive;
            if (ssas == str2)
            {
                Ssaab.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Ssaab.BackColor = Color.IndianRed;
            }
            //TastyTV Live check
            //Console.WriteLine(tasr.stream);
            string tass = LiveCheck.tastylive;
            if (tass == str2)
            {
                TastyTV.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                TastyTV.BackColor = Color.IndianRed;
            }
            //Thadrius Live check
            //Console.WriteLine(thar.stream);
            string thas = LiveCheck.thadlive;
            if (thas == str2)
            {
                Thadrius.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Thadrius.BackColor = Color.IndianRed;
            }
            //TheBuddha3 Live check
            //Console.WriteLine(ther.stream);
            string thes = LiveCheck.thebuddhalive;
            if (thes == str2)
            {
                TheBuddha3.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                TheBuddha3.BackColor = Color.IndianRed;
            }
            //thelawmangaming Live check
            //Console.WriteLine(thelr.stream);
            string thels = LiveCheck.thelawlive;
            if (thels == str2)
            {
                thelawmangaming.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                thelawmangaming.BackColor = Color.IndianRed;
            }
            //TigerWrite Live check
            //Console.WriteLine(tigr.stream);
            string tigs = LiveCheck.tigerwriterlive;
            if (tigs == str2)
            {
                TigerWriter.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                TigerWriter.BackColor = Color.IndianRed;
            }
            //Timmac Live check
            //Console.WriteLine(timr.stream);
            string tims = LiveCheck.timmaclive;
            if (tims == str2)
            {
                Timmac.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Timmac.BackColor = Color.IndianRed;
            }
            //TVSBOH Live check
            //Console.WriteLine(tvsr.stream);
            string tvss = LiveCheck.tvsbohlive;
            if (tvss == str2)
            {
                TVSBOH.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                TVSBOH.BackColor = Color.IndianRed;
            }
            //UndeadBaron Live check
            //Console.WriteLine(undr.stream);
            string unds = LiveCheck.undeadbro;
            if (unds == str2)
            {
                UndeadBaron.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                UndeadBaron.BackColor = Color.IndianRed;
            }
            //ValkyrieSpirit Live check
            //Console.WriteLine(valr.stream);
            string vals = LiveCheck.valkyrielive;
            if (vals == str2)
            {
                ValkyrieSpirit.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                ValkyrieSpirit.BackColor = Color.IndianRed;
            }
            //Will_ko Live check
            //Console.WriteLine(wilr.stream);
            string wills = LiveCheck.willkolive;
            if (wills == str2)
            {
                Will_ko.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Will_ko.BackColor = Color.IndianRed;
            }
            //willitkimchi Live check
            //Console.WriteLine(willr.stream);
            string kims = LiveCheck.kimchilive;
            if (kims == str2)
            {
                willitkimchi.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                willitkimchi.BackColor = Color.IndianRed;
            }
            //Wish Live check
            //Console.WriteLine(wisr.stream);
            string wishs = LiveCheck.wishlive;
            if (wishs == str2)
            {
                Wish.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Wish.BackColor = Color.IndianRed;
            }
            //X_xZimx_X Live check
            //Console.WriteLine(zimr.stream);
            string zims = LiveCheck.zimlive;
            if (zims == str2)
            {
                X_xZimx_X.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                X_xZimx_X.BackColor = Color.IndianRed;
            }
            //Xiceman Live check
            //Console.WriteLine(xicr.stream);
            string xices = LiveCheck.xicemanlive;
            if (xices == str2)
            {
                Xiceman.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Xiceman.BackColor = Color.IndianRed;
            }
            //XProph3cyx Live check
            //Console.WriteLine(xprr.stream);
            string xpros = LiveCheck.prophlive;
            if (xpros == str2)
            {
                XProph3cyx.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                XProph3cyx.BackColor = Color.IndianRed;
            }
            //Zaquelle Live check
            //Console.WriteLine(zaqr.stream);
            string zaqs = LiveCheck.zaquellelive;
            if (zaqs == str2)
            {
                Zaquelle.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Zaquelle.BackColor = Color.IndianRed;
            }
            //SheepDog59 Live check
            //Console.WriteLine(zaqr.stream);
            string shees = LiveCheck.sheepdoglive;
            if (shees == str2)
            {
                SheepDog59.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                SheepDog59.BackColor = Color.IndianRed;
            }
            //TheRealSpectral Live check
            //Console.WriteLine(zaqr.stream);
            string thers = LiveCheck.thereallive;
            if (thers == str2)
            {
                TheRealSpectral.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                TheRealSpectral.BackColor = Color.IndianRed;
            }
            //Mythematic Live check
            //Console.WriteLine(zaqr.stream);
            string myths = LiveCheck.mythematiclive;
            if (myths == str2)
            {
                Mythematic.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                Mythematic.BackColor = Color.IndianRed;
            }
            //Saffypie101 Live check
            //Console.WriteLine(zaqr.stream);
            string saffys = LiveCheck.saffylive;
            if (saffys == str2)
            {
                SaffyPie101.BackColor = Color.LightGreen;
                ++i;
            }
            else
            {
                SaffyPie101.BackColor = Color.IndianRed;
            }

            Form1.streamercount = i.ToString();
        }

        public void refreshBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            bunifuCircleProgressbar1.Value = e.ProgressPercentage;
            bunifuCircleProgressbar1.Update();
        }

        public async void refreshBackgroundWorker_Complete(object sender, RunWorkerCompletedEventArgs e)
        {
            StreamerCount.Text = "Streamers Online: " + streamercount;
            refreshButton.BackColor = Color.LightGreen;
            refreshButton.Text = "Refreshed";
            refreshButton.Enabled = false;
            await Task.Delay(8000);
            refreshButton.BackColor = Color.White;
            refreshButton.Text = "Refresh";
            refreshButton.Enabled = true;
        }

        private void vlcbutton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.videolan.org/vlc/index.html");
        }

        private void Mythematic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/mythematic best");
        }

        private void SaffyPie101_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD", "/C data\\streamlink.exe http://twitch.tv/saffypie101 best");
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
