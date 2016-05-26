using System.Collections.Generic;
using System.Web.Http;
using FeedViewer.DataContract;

namespace FeedViewer.Api.Controllers
{
    public class FeedController : ApiController
    {
        public IEnumerable<FeedItem> Get()
        {
            return new FeedItem[]
            {
                new FeedItem { Id = 556309, UserName = "Gorgeousthirteen ", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/nBR1gPqNOkaTLMOIniiI5w/entries/nBR1gPqNOkaTLMOIniiI5w.standard.jpg", Caption = @"lip trio", PostPictureUri = "https://envicase.blob.core.windows.net/images/K7wIT8yXX0u0YhTJU0oZyg/entries/K7wIT8yXX0u0YhTJU0oZyg.standard-v1.jpg" },
                new FeedItem { Id = 556284, UserName = "Gorgeousthirteen ", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/nBR1gPqNOkaTLMOIniiI5w/entries/nBR1gPqNOkaTLMOIniiI5w.standard.jpg", Caption = @"got the little trial size", PostPictureUri = "https://envicase.blob.core.windows.net/images/lhbg_5T1CEiFv53a3GzF5g/entries/lhbg_5T1CEiFv53a3GzF5g.standard-v1.jpg" },
                new FeedItem { Id = 556257, UserName = "torey.noora", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/uIeu2dwa00Sa4f8uivTkqw/entries/uIeu2dwa00Sa4f8uivTkqw.standard.jpg", Caption = @"#simplesunday", PostPictureUri = "https://envicase.blob.core.windows.net/images/ncWlZ4uHukaCDlLiON8gUQ/entries/ncWlZ4uHukaCDlLiON8gUQ.standard-v1.jpg" },
                new FeedItem { Id = 556217, UserName = "marianna.deli", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/qHSgSrj1okaSNlNmlFYA4g/entries/qHSgSrj1okaSNlNmlFYA4g.standard.jpg", Caption = @"Casual ootd", PostPictureUri = "https://envicase.blob.core.windows.net/images/fuLa6Nt4Ok2bFJeDn7v7pA/entries/fuLa6Nt4Ok2bFJeDn7v7pA.standard-v1.jpg" },
                new FeedItem { Id = 556214, UserName = "Stella Sallaku", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/N61uE8rbi0W0U6jZ5rchgQ/entries/N61uE8rbi0W0U6jZ5rchgQ.standard.jpg", Caption = @"👡 #mules", PostPictureUri = "https://envicase.blob.core.windows.net/images/c22VsP2e2k6o-tJVI1k5Gg/entries/c22VsP2e2k6o-tJVI1k5Gg.standard-v1.jpg" },
                new FeedItem { Id = 556213, UserName = "walids", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/OdyzbTOaAUiWKVRNgz21rQ/entries/OdyzbTOaAUiWKVRNgz21rQ.standard.jpg", Caption = @"The best things come in small packages. | Anonymous
.
Thank you @qlippie for this Q1 Mini HD Camera. Qlippie Q1 is a wearable camera with 1080p full HD video 8MP camera. Read more at qlippie.com
.
#qlippie
.
#danielwellington #dwpickoftheday #wearetrouva #gmyle #musotrees #krispykreme #cupsinframe #whiteaddict #whywhiteworks", PostPictureUri = "https://envicase.blob.core.windows.net/images/Nw85tXPQqUeTZ-Pl_Y95-A/entries/Nw85tXPQqUeTZ-Pl_Y95-A.standard-v1.jpg" },
                new FeedItem { Id = 556208, UserName = "queenofnonsenseblog", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/cqzgTz3nmkWUrOO0xy8LFQ/entries/cqzgTz3nmkWUrOO0xy8LFQ.standard.jpg", Caption = @"So excited to try these; just in time for summer! With @yourtea everytime is tea time! Love how it smells.. Gonna be having one of these now and I will let you know how it works asap with a full review! 😌🍵💙 #yourtea #antiC #glutenfree", PostPictureUri = "https://envicase.blob.core.windows.net/images/Qln4InI3Rk6HJi5EX9eFQw/entries/Qln4InI3Rk6HJi5EX9eFQw.standard-v1.jpg" },
                new FeedItem { Id = 556206, UserName = "queenofnonsenseblog", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/cqzgTz3nmkWUrOO0xy8LFQ/entries/cqzgTz3nmkWUrOO0xy8LFQ.standard.jpg", Caption = @"Having my #chocolatebar for breakfast! 😍 I still can't get over how pretty the #semisweetchocolatebar from #toofaced is 💗🍫 #muchlove #tfsemisweetchocolatebar", PostPictureUri = "https://envicase.blob.core.windows.net/images/qgp58evOYUSGxaaVG_SzSw/entries/qgp58evOYUSGxaaVG_SzSw.standard-v1.jpg" },
                new FeedItem { Id = 556205, UserName = "zorione", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/n2bScEH4w0SFqhNSduZukA/entries/n2bScEH4w0SFqhNSduZukA.standard.jpg", Caption = @"Hair loss treatment", PostPictureUri = "https://envicase.blob.core.windows.net/images/gIehwFbyeEGZaJDlX7Q6OA/entries/gIehwFbyeEGZaJDlX7Q6OA.standard-v1.jpg" },
                new FeedItem { Id = 556203, UserName = "Alexaasilver", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/Qdid0FpU8kKWN0UIKlwwCw/entries/Qdid0FpU8kKWN0UIKlwwCw.standard.jpg", Caption = @"leather backpack", PostPictureUri = "https://envicase.blob.core.windows.net/images/6NMJQmJgREOCtbaD5Pj5KQ/entries/6NMJQmJgREOCtbaD5Pj5KQ.standard-v1.jpg" },
                new FeedItem { Id = 556199, UserName = "queenofnonsenseblog", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/cqzgTz3nmkWUrOO0xy8LFQ/entries/cqzgTz3nmkWUrOO0xy8LFQ.standard.jpg", Caption = @"For a music festival I'd pack my @sephoraitalia travel essentials: • #invisibobble per legare i capelli • #POREfessional per non pensare ai ritocchi del make up anche se sudiamo
• #RougeInfusion per dar colore ed idratare le labbra
• #OutrageousVolume Mascara per ciglia che non passano inosservate!

Pronte per i prossimi #Coachella con @sephoraitalia.. e voi, cosa portate? Scatta una foto con l'hashtag #SephoraBeautyToGo e partiamo insieme! 🎶🎤📷", PostPictureUri = "https://envicase.blob.core.windows.net/images/kPzFCX1zykWQ0etifVcwZw/entries/kPzFCX1zykWQ0etifVcwZw.standard-v1.jpg" },
                new FeedItem { Id = 556166, UserName = "Emma Louise May", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/hHOmUYTd6Eioy03YOtg6KQ/entries/hHOmUYTd6Eioy03YOtg6KQ.standard.jpg", Caption = @"ogon design bags ", PostPictureUri = "https://envicase.blob.core.windows.net/images/kO161H0LZUmT8FZtkpFthA/entries/kO161H0LZUmT8FZtkpFthA.standard-v1.jpg" },
                new FeedItem { Id = 556163, UserName = "jasonitos", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/SIVdnMUju0e29b1JqdhSLQ/entries/SIVdnMUju0e29b1JqdhSLQ.standard.jpg", Caption = @"I got that move when I walk /

#electric #vsco #london #vscocam #allblackeverything #fashionblogger", PostPictureUri = "https://envicase.blob.core.windows.net/images/W7n4vWgjpUmw0fJIW0_r-A/entries/W7n4vWgjpUmw0fJIW0_r-A.standard-v1.jpg" },
                new FeedItem { Id = 556160, UserName = "queenofnonsenseblog", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/cqzgTz3nmkWUrOO0xy8LFQ/entries/cqzgTz3nmkWUrOO0xy8LFQ.standard.jpg", Caption = @"Black Marble", PostPictureUri = "https://envicase.blob.core.windows.net/images/TyUE7OAvmke_h0lzt6WoLg/entries/TyUE7OAvmke_h0lzt6WoLg.standard-v1.jpg" },
                new FeedItem { Id = 556139, UserName = "toniadiclemente", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/Hf7jAGvmB0afb7UW4YPmFw/entries/Hf7jAGvmB0afb7UW4YPmFw.standard.jpg", Caption = @"", PostPictureUri = "https://envicase.blob.core.windows.net/images/poNxxYurqEywyiRkvGzX1g/entries/poNxxYurqEywyiRkvGzX1g.standard-v1.jpg" },
                new FeedItem { Id = 556109, UserName = "blaeckli", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/Xt2QpBO1-0yF4CpGS7cYBA/entries/Xt2QpBO1-0yF4CpGS7cYBA.standard.jpg", Caption = @"@blaeckli is starting a giveaway.
Just click on the link in his biographie!🙏🏼 #YEEZY #GIVEAWAY #CREPPROTECT #BOOM", PostPictureUri = "https://envicase.blob.core.windows.net/images/BPEOpnQvEkWpyP26XoSIAA/entries/BPEOpnQvEkWpyP26XoSIAA.standard-v1.jpg" },
                new FeedItem { Id = 556104, UserName = "zorione", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/n2bScEH4w0SFqhNSduZukA/entries/n2bScEH4w0SFqhNSduZukA.standard.jpg", Caption = @"Handbag", PostPictureUri = "https://envicase.blob.core.windows.net/images/rqzZr2YGpkuwkSkqrN4wJQ/entries/rqzZr2YGpkuwkSkqrN4wJQ.standard-v1.jpg" },
                new FeedItem { Id = 556027, UserName = "blaeckli", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/Xt2QpBO1-0yF4CpGS7cYBA/entries/Xt2QpBO1-0yF4CpGS7cYBA.standard.jpg", Caption = @"Comment your size bellow and tag your friends! #yeezydrugs #yeezyboost350", PostPictureUri = "https://envicase.blob.core.windows.net/images/tJ6LESl2uEWODAQMcbp3fA/entries/tJ6LESl2uEWODAQMcbp3fA.standard-v1.jpg" },
                new FeedItem { Id = 556017, UserName = "naysbeautycorner", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/eBMvMGc37kakY6pNZMBASw/entries/eBMvMGc37kakY6pNZMBASw.standard.jpg", Caption = @"Don't know if I'm more in love with the packaging or the actual product 😍😍", PostPictureUri = "https://envicase.blob.core.windows.net/images/nSoHK7zs40yZryy_gDWAgw/entries/nSoHK7zs40yZryy_gDWAgw.standard-v1.jpg" },
                new FeedItem { Id = 556009, UserName = "CathyJQueen", ProfilePictureUri = "https://envicase.blob.core.windows.net/images/NwwnwfF8V0-x_gjIT-q9Cg/entries/NwwnwfF8V0-x_gjIT-q9Cg.standard.jpg", Caption = @"", PostPictureUri = "https://envicase.blob.core.windows.net/images/oiw2kCCbTk67REWuJqsHDg/entries/oiw2kCCbTk67REWuJqsHDg.standard-v1.jpg" }
            };
        }
    }
}
