namespace Assigment_9___Individual_Part
{
    public class abstractTall : Abstract
    {
        public abstractTall(IDraw _draw) : base(_draw)
        {
            //Empty Constructor   
        }

        public override string Draw()
        {
            return base.Draw() +  "I’m tall!";
        }
    }
}