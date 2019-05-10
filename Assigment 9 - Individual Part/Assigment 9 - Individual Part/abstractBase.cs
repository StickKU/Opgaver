namespace Assigment_9___Individual_Part
{
    public class abstractBase : Abstract
    {
        public abstractBase(IDraw _draw) : base(_draw)
        {
         //Empty Constructor   
        }

        public override string Draw()
        {
            return base.Draw() + "It's me, SUrio!";
        }
    }
}