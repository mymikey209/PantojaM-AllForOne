

namespace PantojaM_AllForOne.service;

    public class Magic8BallService : IMagic8BallService
    {
        public List<string> AnswserList = new();

        public Magic8BallService()
        {
            AnswserList.Add("Yes");
            AnswserList.Add("No");
            AnswserList.Add("Ask Again Later");
        }
        public string Answer(string GiveAnswer)
        {
            return "test";

        }
    }
