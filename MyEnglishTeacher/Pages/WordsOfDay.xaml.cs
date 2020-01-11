using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyEnglishTeacher.Model;

namespace MyEnglishTeacher.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WordsOfDay : ContentPage
    {
        public WordsOfDay()
        {
            InitializeComponent();
            Word myWord2 = randomWord();



            for (int i = 0; i < 5; i++)
            {
                Word myWord = randomWord();
                Label elabel = new Label
                {
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    FontAttributes = FontAttributes.Bold,
                };
                Label tlabel = new Label
                {
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    FontAttributes = FontAttributes.Bold,
                };



                elabel.Text = myWord.english;
                tlabel.Text = myWord.turkish;
                myLayout2.Children.Add(elabel);

                myLayout.Children.Add(tlabel);
            };





        }

        private void getBtn_Clicked(object sender, EventArgs e)
        {
            GetMore();
        }
        public void GetMore()
        {
            Word myWord2 = randomWord();



            for (int i = 0; i < 5; i++)
            {
                Word myWord = randomWord();
                Label elabel = new Label
                {
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    FontAttributes = FontAttributes.Bold,
                };
                Label tlabel = new Label
                {
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    FontAttributes = FontAttributes.Bold,
                };



                elabel.Text = myWord.english;
                tlabel.Text = myWord.turkish;
                myLayout2.Children.Add(elabel);

                myLayout.Children.Add(tlabel);
            };
        }
        public static Word randomWord()
        {
            int size = words.Count;
            Random random = new Random();

            int r = random.Next(0, size);
            return words[r];
        }
        static List<Word> words = new List<Word>()
        {
            new Word{english="Horse", turkish="At"},
            new Word{english="Red", turkish="Kırmızı"},
            new Word{english="Pattern", turkish="Örüntü"},
            new Word{english="Logic", turkish="Mantık"},
            new Word{english="Yellow", turkish="Sarı"},
            new Word{english="Green", turkish="Yeşil"},
            new Word{english="Blue", turkish="Mavi"},
            new Word{english="Accept", turkish="Kabul etmek"},
            new Word{english="Achieve", turkish="Başarmak"},
            new Word{english="Act", turkish="Davranmak"},
            new Word{english="Add", turkish="Eklemek"},
            new Word{english="Admit", turkish="Kabul etmek"},
            new Word{english="Affect", turkish="Etkilemek"},
            new Word{english="Afford", turkish="Satın almaya parası yetmek"},
            new Word{english="Agree", turkish="Katılmak"},
            new Word{english="Aim", turkish="Amaçlamak"},
            new Word{english="Allow", turkish="İzin vermek"},
            new Word{english="Answwer", turkish="Cevap vermek"},
            new Word{english="Appear", turkish="Görünmek"},
            new Word{english="Apply", turkish="Uygulamak"},
            new Word{english="Argue", turkish="Tartışmak"},
            new Word{english="Arrange", turkish="Düzenlemek"},
            new Word{english="Arrive", turkish="Uluşmak"},
            new Word{english="Ask", turkish="Sormak"},
            new Word{english="Attack", turkish="Saldırmak"},
            new Word{english="Avoid", turkish="Kaçınmak"},
            new Word{english="Be", turkish="Olmak"},
            new Word{english="Beat", turkish="Vurmak"},
            new Word{english="Become", turkish="Dönüşmek"},
            new Word{english="Begin", turkish="Başlamak"},
            new Word{english="Believe", turkish="İnanmak"},
            new Word{english="Bend", turkish="Eğilmek"},
            new Word{english="Bet", turkish="İddiaya girmek"},
            new Word{english="Bid", turkish="Teklif vermek"},
            new Word{english="Bite", turkish="Isırmak"},
            new Word{english="Bleed", turkish="Kanamak"},
            new Word{english="Blow", turkish="Üflemek"},
            new Word{english="Break", turkish="Kırılmak"},
            new Word{english="Breed", turkish="Çoğaltmak"},
            new Word{english="Bring", turkish="Getirmek"},
            new Word{english="Build", turkish="İnşa etmek"},
            new Word{english="Burn", turkish="Yanmak"},
            new Word{english="Buy", turkish="Satın almak"},
            new Word{english="Call", turkish="Aramak"},
            new Word{english="Catch", turkish="Yakalamak"},
            new Word{english="Choose", turkish="Seçmek"},
            new Word{english="Come", turkish="Gelmek"},
            new Word{english="Cost", turkish="Mal olmak"},
            new Word{english="Creep", turkish="Ürkütmek"},
            new Word{english="Cut", turkish="Kesmek"},
            new Word{english="Damage", turkish="Zarar vermek"},
            new Word{english="Dance", turkish="Dans etmek"},
            new Word{english="Deal", turkish="Anlaşmak"},
            new Word{english="Decide", turkish="Karar vermek"},
            new Word{english="Deliver", turkish="Teslim etmek"},
            new Word{english="Demand", turkish="Talep etmek"},
            new Word{english="Deny", turkish="İnkar etmek"},
            new Word{english="Depend", turkish="Bağlı olmak"},
            new Word{english="Describe", turkish="Tanımlamak"},
            new Word{english="Design", turkish="Tasarlamak"},
            new Word{english="Destroy", turkish="Yok etmek"},
            new Word{english="Develop", turkish="Geliştirmek"},
            new Word{english="Die", turkish="Ölmek"},
            new Word{english="Dig", turkish="Kazmak"},
            new Word{english="Do", turkish="Yapmak"},
            new Word{english="Draw", turkish="Çizmek"},
            new Word{english="Dream", turkish="Hayal kurmak"},
            new Word{english="Drink", turkish="İçmek"},
            new Word{english="Drive", turkish="Sürmek"},
            new Word{english="Eat", turkish="Yemek"},
            new Word{english="End", turkish="Sona ermek"},
            new Word{english="Enjoy", turkish=".zevk almak"},
            new Word{english="Examine", turkish="İncelemek"},
            new Word{english="Exist", turkish="Var olmak"},
            new Word{english="Expect", turkish="Beklemek"},
            new Word{english="Experience", turkish="Deneyim kazanmak"},
            new Word{english="Explain", turkish="Açıklamak"},
            new Word{english="Express", turkish="İfade etmek"},
            new Word{english="Fall", turkish="Düşmek"},
            new Word{english="Feed", turkish="Beslemek"},
            new Word{english="Feel", turkish="Hissetmek"},
            new Word{english="Fight", turkish="Dövüşmek"},
            new Word{english="Find", turkish="Bulmak"},
            new Word{english="Fly", turkish="Uçmak"},
            new Word{english="Fold", turkish="Katlamak"},
            new Word{english="Follow", turkish="Takip etmek"},
            new Word{english="Force", turkish="Zorlamak"},
            new Word{english="Forbid", turkish="Yasaklamak"},
            new Word{english="Forget", turkish="Unutmak"},
            new Word{english="Forgive", turkish="Affetmek"},
            new Word{english="Freeze", turkish="Dondurmak"},
            new Word{english="Get", turkish="Almak"},
            new Word{english="Give", turkish="Vermek"},
            new Word{english="Go", turkish="Gitmek"},
            new Word{english="Grow", turkish="Büyümek"},
            new Word{english="Hang", turkish="Asmak"},
            new Word{english="Have", turkish="Sahip olmak"},
            new Word{english="Hear", turkish="Duymak"},
            new Word{english="Help", turkish="Yardım etmek"},
            new Word{english="Hide", turkish="Saklanmak"},
            new Word{english="Hit", turkish="Vurmak"},
            new Word{english="Hold", turkish="Tutmak"},
            new Word{english="Hurt", turkish="Acımak"},
            new Word{english="Keep", turkish="Tutmak"},
            new Word{english="Know", turkish="Bilmek"},
            new Word{english="Lay", turkish="Uzanmak"},
            new Word{english="Lead", turkish="Yönetmek"},
            new Word{english="Lean", turkish="Dayanmak"},
            new Word{english="Leave", turkish="Terk etmek"},
            new Word{english="Lend", turkish="Borç vermek"},
            new Word{english="Let", turkish="İzin vermek"},
            new Word{english="Lie", turkish="Yalan söylemek"},
            new Word{english="Like", turkish="Beğenmek"},
            new Word{english="Live", turkish="Yaşamak"},
            new Word{english="Look", turkish="Bakmak"},
            new Word{english="Lose", turkish="Kaybetmek"},
            new Word{english="Make", turkish="Yapmak"},
            new Word{english="Manage", turkish="İdare etmek"},
            new Word{english="Mark", turkish="İşaretlemek"},
            new Word{english="Matter", turkish="Önem taşımak"},
            new Word{english="May", turkish="Mümkün kılmak"},
            new Word{english="Mean", turkish="Kastetmek"},
            new Word{english="Meet", turkish="Buluşmak"},
            new Word{english="Mention", turkish="Bahsetmek"},
            new Word{english="Mind", turkish="önemsemek"},
            new Word{english="Miss", turkish="Kaçırmak"},
            new Word{english="Move", turkish="Hareket etmek"},
            new Word{english="Need", turkish="İhtiyaç duymak"},
            new Word{english="Notice", turkish="Fark etmek"},
            new Word{english="Obtain", turkish="Edinmek"},
            new Word{english="Occur", turkish="Vuku bulmak"},
            new Word{english="Offer", turkish="Teklif etmek"},
            new Word{english="Open", turkish="Açmak"},
            new Word{english="Order", turkish="Emir vermek"},
            new Word{english="Own", turkish="Sahip olmak"},
            new Word{english="Pass", turkish="Pas geçmek"},
            new Word{english="Pay", turkish="Ödemek"},
            new Word{english="Perform", turkish="Sahnelemek"},
            new Word{english="Pick", turkish="Seçmek"},
            new Word{english="Place", turkish="Yerleştirmek"},
            new Word{english="Plan", turkish="Plan yapmak"},
            new Word{english="Play", turkish="Oynamak"},
            new Word{english="Put", turkish="Koymak"},
            new Word{english="Quit", turkish="Bırakmak"},
            new Word{english="Reach", turkish="Ulaşmak"},
            new Word{english="Read", turkish="Okumak"},
            new Word{english="Realize", turkish="Farkına varmak"},
            new Word{english="Receive", turkish="Teslim etmek"},
            new Word{english="Recognize", turkish="Tanımak"},
            new Word{english="Record", turkish="Kaydetmek"},
            new Word{english="Reduce", turkish="Düşürmek"},
            new Word{english="Reflect", turkish="Yansıtmak"},
            new Word{english="Refuse", turkish="Reddetmek"},
            new Word{english="Regard", turkish="Saymak"},
            new Word{english="Release", turkish="Serbest bırakmak"},
            new Word{english="Remain", turkish="Arta kalmak"},
            new Word{english="Remember", turkish="Hatırlamak"},
            new Word{english="Remove", turkish="Kaldırmak"},
            new Word{english="Repeat", turkish="Tekrarlamak"},
            new Word{english="Replace", turkish="Yer değiştirmek"},
            new Word{english="Reply", turkish="Cevap vermek"},
            new Word{english="Report", turkish="Bildirmek"},
            new Word{english="Represent", turkish="Temsil etmek"},
            new Word{english="Require", turkish="Gerekmek"},
            new Word{english="Rest", turkish="Dinlenmek"},
            new Word{english="Return", turkish="Geri dönmek"},
            new Word{english="Reveal", turkish="Ortaya çıkarmak"},
            new Word{english="Ring", turkish="Çınlamak"},
            new Word{english="Rise", turkish="Yükselmek"},
            new Word{english="Roll", turkish="Yuvarlamak"},
            new Word{english="Run", turkish="Koşmak"},
            new Word{english="Say", turkish="Söylemek"},
            new Word{english="See", turkish="Görmek"},
            new Word{english="Seem", turkish="Görünmek"},
            new Word{english="Sell", turkish="Satmak"},
            new Word{english="Send", turkish="Göndermek"},
            new Word{english="Set", turkish="Ayarlamak"},
            new Word{english="Settle", turkish="Yerleşmek"},
            new Word{english="Shake", turkish="Sallamak"},
            new Word{english="Shine", turkish="Parlamak"},
            new Word{english="Shoe", turkish="Nallamak"},
            new Word{english="Shoot", turkish="Vurmak"},
            new Word{english="Show", turkish="Göstermek"},
            new Word{english="Shrink", turkish="Küçülmek"},
            new Word{english="Shut", turkish="Kapatmak"},
            new Word{english="Sing", turkish="Şarkı söylemek"},
            new Word{english="Sink", turkish="Batmak"},
            new Word{english="Sit", turkish="Oturmak"},
            new Word{english="Ski", turkish="Kayak yapmak"},
            new Word{english="Slap", turkish="Tokatlamak"},
            new Word{english="Slay", turkish="Katletmek"},
            new Word{english="Slice", turkish="Doğramak"},
            new Word{english="Slide", turkish="Kaymak"},
            new Word{english="Sleep", turkish="Uyumak"},
            new Word{english="Speak", turkish="Konuşmak"},
            new Word{english="Spend", turkish="Harcamak"},
            new Word{english="Spill", turkish="Tükürmek"},
            new Word{english="Spread", turkish="Yaymak"},
            new Word{english="Stand", turkish="Ayakta durmak"},
            new Word{english="Start", turkish="Başlamak"},
            new Word{english="Steal", turkish="Çalmak"},
            new Word{english="Stick", turkish="Yapışmak"},
            new Word{english="Sting", turkish="Batmak"},
            new Word{english="Stink", turkish="Kokuşmak"},
            new Word{english="Swear", turkish="Yemin etmek"},
            new Word{english="Sweep", turkish="Süpürmek"},
            new Word{english="Swim", turkish="Yüzmek"},
            new Word{english="Swing", turkish="Sallanmak"},
            new Word{english="Take", turkish="Almak"},
            new Word{english="Talk", turkish="Konuşmak"},
            new Word{english="Teach", turkish="Öğretmek"},
            new Word{english="Tear", turkish="Yırtmak"},
            new Word{english="Tell", turkish="Anlatmak"},
            new Word{english="Think", turkish="Düşünmek"},
            new Word{english="Throw", turkish="Fırlatmak"},
            new Word{english="Touch", turkish="Dokunmak"},
            new Word{english="Train", turkish="Eğitmek"},
            new Word{english="Travel", turkish="Seyahat etmek"},
            new Word{english="Treat", turkish="Tedavi etmek"},
            new Word{english="Try", turkish="Denemek"},
            new Word{english="Turn", turkish="Dönmek"},
            new Word{english="Understand", turkish="Anlamak"},
            new Word{english="Use", turkish="Kullanmak"},
            new Word{english="Visit", turkish="Ziyaret etmek"},
            new Word{english="Vote", turkish="Oy vermek"},
            new Word{english="Wait", turkish="Beklemek"},
            new Word{english="Walk", turkish="Yürümek"},
            new Word{english="Wake", turkish="Uyanmak"},
            new Word{english="Want", turkish="İstemek"},
            new Word{english="Warn", turkish="Uyarmak"},
            new Word{english="Wear", turkish="Giymek"},
            new Word{english="Win", turkish="Kazanmak"},
            new Word{english="Wish", turkish="Dilemek"},
            new Word{english="Work", turkish="Çalışmak"},
            new Word{english="Worry", turkish="Endişelenmek"},
            new Word{english="Write", turkish="Yazmak"},



        };
    }
}