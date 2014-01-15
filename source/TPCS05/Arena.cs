namespace TPCS05
{
    public class Arena
    {
        public Arena(Pony _left, Pony _right)
        {
            _left = Left;
            _right = Right;
        }

        public Pony Left;
        public Pony Right;

        public void ChangeAttacker()
        {
            Left = Right;
            Right = Left;
        }

        public void AttackWith(int n)
        {
            Left.GetAttack(n);
            Right.GetAttack(n);
        }

        public bool IsFinished()
        {
            if (Left.Pv == 0 || Right.Pv == 0)
            {
                return true;
            }
            else return false;
        }


    }
}