namespace DarkHouse.Inventory
{
    /// <summary>
    /// HouseHoldItem Class
    /// </summary>
    /// <remarks>Define a house hold item</remarks>
    public class HouseHoldItem : IItem
    {
               /// <summary>
        /// Item name
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the item name</remarks>
        public string Name { get; set; }

        /// <summary>
        /// Item tag
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the item tag</remarks>
        public string Tag { get; set; }

        /// <summary>
        /// Item description
        /// </summary>
        /// <returns><see cref="string"/></returns>
        /// <remarks>Get or set the item tag</remarks>
        public string Description { get; set; }
    }
}