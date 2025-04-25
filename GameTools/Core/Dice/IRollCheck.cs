namespace Core.Dice
{
    /// <summary>
    /// Processes the success or failure of a dice roll
    /// </summary>
    public interface IRollCheck
    {
        /// <summary>
        /// Returns a bool indicating if the roll passes the check
        /// </summary>
        /// <param name="rollValue">The value of the dice throw</param>
        /// <param name="winningRollValue">The number needed to win the throw</param>
        /// <param name="modifierValue">Modifier to be combined with the throw</param>
        bool DoesRollPass(int rollValue, int winningRollValue, int modifierValue);
    }
}
