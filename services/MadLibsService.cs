
namespace PantojaM_AllForOne.servies;

public class MadLibsService : IMadLibsService
{
    public string MadLib(string adj1, string noun1, string room1, string color, string size, string sound, string texture, string adj2, string noun2, string adj3, string emotion, string room2, string adj4)
    {
        return
     $"On an {adj1} afternoon, I found a mysterious {noun1} in my {room1}. it was {color} and {size}, and it emitted a strange {sound}. With curiosity, I cautiously picked it up and it felt {texture}. Suddenly, it began to {adj2}, and i was tradported to an {noun2} would filled with. Iembarked on an {adj3} adventure, and i couldnt help but feel {emotion} throughout. After what felt like hours, i woke up back in my {room2} wondering if it had all been an {adj4} dream";
    
    }
}
