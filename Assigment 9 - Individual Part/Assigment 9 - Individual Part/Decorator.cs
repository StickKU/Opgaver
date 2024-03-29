namespace Assigment_9___Individual_Part
{
    public abstract class Decorator : IDraw
    {

        private readonly IDraw _draw;

        protected Decorator(IDraw drawing)
        {

            _draw = drawing;

        }

        public virtual string Draw()
        {
            return _draw.Draw();
        }
    }
}