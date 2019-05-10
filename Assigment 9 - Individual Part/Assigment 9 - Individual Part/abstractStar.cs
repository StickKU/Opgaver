namespace Assigment_9___Individual_Part
{
    public class abstractStar: Abstract
    {
        public abstractStar(IDraw _draw) : base(_draw)
        {
            //Empty Constructor   
        }

        public override string Draw()
        {
            return base.Draw() +  "Wow! I’m invincible!";
        }
    }
}