namespace Assigment_9___Individual_Part
{
    public class Abstract : IDraw
    {
        private readonly IDraw _draw;

        protected Abstract(IDraw drawing)
        {

            _draw = drawing;

        }

        public virtual string Draw()
        {
            return _draw.Draw();
        }
    }
}