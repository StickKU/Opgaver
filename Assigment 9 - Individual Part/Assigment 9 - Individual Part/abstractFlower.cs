namespace Assigment_9___Individual_Part
{
    public class abstractFlower: Abstract
    {
        public abstractFlower(IDraw _draw) : base(_draw)
        {
            //Empty Constructor   
        }

        public override string Draw()
        {
            return base.Draw() +  "And I can throw fireballs!";
        }
    }
}