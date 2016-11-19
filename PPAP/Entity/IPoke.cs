namespace PPAP.Entity
{
    /// <summary>
    /// it's n~~~~~~~
    /// </summary>
    public interface IPoke
    {
        (TLeftHand,TRightHand) Poke<TLeftHand, TRightHand>(TLeftHand left, TRightHand right)
            where TLeftHand : IHand<IPokeStuff>
            where TRightHand : IHand<IStuff>;
    }
}
