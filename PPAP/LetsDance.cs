namespace PPAP
{
    using Entity;
    using ToDo;
    public class LetsDance
    {
        /// <summary>
        /// PPAP's workflow
        /// </summary>
        /// <param name="air">get any in air XD</param>
        /// <param name="left">left hand</param>
        /// <param name="right">right hand</param>
        public void MakePPAP(IContainer air,IHand left,IHand right)
        {
            // right hand get Pen
            var rightPen = right.Take(air.Get<IPen>);

            // left hand get Apple
            var leftApple = left.Take(air.Get<IApple>);

            // n~~~~ ApplePen
            (left , right) = air.BinaryDo<IHand<IApple>,IHand<IPen>, IPoke,(IEmptyHand, IHand<IApplePen>)>(leftApple,rightPen);

            // right hand drop ApplePen to air
            IApplePen applepen;
            (applepen, left)= left.Drop<IApplePen>();
            air.Set(applepen);

            // left hand get Pen
            var leftPen = right.Take(air.Get<IPen>);

            // right hand get Pineapple
            var rightPineapple = left.Take(air.Get<IPineapple>);

            // n~~~~~~~ PineapplePen
            (right, left) = air.BinaryDo<IHand<IPen>, IHand<IPineapple>, IPoke, (IHand<IPineapplePen>, IEmptyHand) >(leftPen, rightPineapple);

            // right hand get ApplePen from air
            var rightApplePen = left.Take(air.Get<IApplePen>);

            // left hand show IPineapplePen
            var leftPineapplePen = right as IHand<IPineapplePen>;

            // n~~~~~~~ PenPineappleApplePen ~~~~ PenPineappleApplePen ~~~~
            air.BinaryDo<IHand<IPineapplePen>, IHand<IApplePen>, IPoke, (IHand<IPenPineappleApplePen>, IHand<IPenPineappleApplePen>)>(leftPineapplePen,rightApplePen )
                .Dance(ppap => air.Set(ppap));
        }
    }
}
