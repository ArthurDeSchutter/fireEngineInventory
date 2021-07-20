namespace fireengineinventoryv2
{
    internal class fireEngineItem
    {
        public fireEngineItem(string item, string place)
        {
            this.item = item;
            this.place = place;
        }

        public string item { get; set; }
        public string place { get; set; }
    }
}