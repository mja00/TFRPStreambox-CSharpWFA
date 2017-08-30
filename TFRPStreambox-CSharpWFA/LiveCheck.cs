using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TFRPStreambox_CSharpWFA
{
    public partial class LiveCheck
    {

        public static string AgentNorthLive;
        public static string _1GUnit1Live;
        public static string AbdulHDLive;
        public static string AndyLive;
        public static string alexuslive;
        public static string antlive;
        public static string bflylive;
        public static string boscolive;
        public static string bpzlive;
        public static string bucklive;
        public static string burkelive;
        public static string chicklive;
        public static string chieflive;
        public static string classlive;
        public static string cletlive;
        public static string coollive;
        public static string daslive;
        public static string dislive;
        public static string djklive;
        public static string drunklive;
        public static string esolive;
        public static string finlive;
        public static string fistlive;
        public static string fivelive;
        public static string geelive;
        public static string ghillelive;
        public static string giantlive;
        public static string glorylive;
        public static string harrylive;
        public static string hazardlive;
        public static string hironalive;
        public static string iamlive;
        public static string immlive;
        public static string ironlive;
        public static string itzlive;
        public static string jreedlive;
        public static string jablive;
        public static string jakelive;
        public static string jmxlive;
        public static string johnlive;
        public static string jollylive;
        public static string jttlive;
        public static string kaceylive;
        public static string kaptainlive;
        public static string katielive;
        public static string kithlive;
        public static string larrylive;
        public static string lawdoglive;
        public static string liftlive;
        public static string lovelive;
        public static string martlive;
        public static string miltonlive;
        public static string mintslive;
        public static string mrmoonslive;
        public static string msdeathlive;
        public static string ogbluepilllive;
        public static string pentalive;
        public static string pinkylive;
        public static string pmslive;
        public static string porklive;
        public static string primuslive;
        public static string purrlive;
        public static string pydrexlive;
        public static string rajjlive;
        public static string rastafiedlive;
        public static string rastarlive;
        public static string samlive;
        public static string saralive;
        public static string sayeedlive;
        public static string selvek;
        public static string seanalive;
        public static string shazlive;
        public static string sherifflive;
        public static string shptvlive;
        public static string silentlive;
        public static string simplylive;
        public static string sircoffeelive;
        public static string sirpinklive;
        public static string skiplive;
        public static string sometexaslive;
        public static string ssaablive;
        public static string tastylive;
        public static string thadlive;
        public static string thebuddhalive;
        public static string thelawlive;
        public static string tigerwriterlive;
        public static string timmaclive;
        public static string tvsbohlive;
        public static string undeadbro;
        public static string valkyrielive;
        public static string willkolive;
        public static string kimchilive;
        public static string wishlive;
        public static string zimlive;
        public static string xicemanlive;
        public static string prophlive;
        public static string zaquellelive;
        public static string sheepdoglive;
        public static string thereallive;
        public static string mythematiclive;
        public static string saffylive;

        public static void refreshMethod()
        {

            int bar = 0;

            //1GUnit1 live check
            string _1guu = @"https://api.twitch.tv/kraken/streams/1gunit1?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var _1guj = new WebClient().DownloadString(_1guu);

            Rootobject _1gur = JsonConvert.DeserializeObject<Rootobject>(_1guj);
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
            string sheeu = @"https://api.twitch.tv/kraken/streams/Zaquelle?client_id=xskte44y2wfqin464ayecyc09nikcj";

            var sheej = new WebClient().DownloadString(sheeu);

            Rootobject sheer = JsonConvert.DeserializeObject<Rootobject>(sheej);
            //Console.WriteLine(zaqr.stream);
            if (sheer.stream != null && sheer.stream.game == "Grand Theft Auto V")
            {
                LiveCheck.sheepdoglive = "true";
            }
            else
            {
                LiveCheck.sheepdoglive = "false";
            }
        }
    }
}
