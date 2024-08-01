namespace ComputerShop.Models
{
    public class Computer
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } =   string.Empty ;
        public float Price { get; set; }

        public Computer_Comp computer_Comp = new Computer_Comp();
    }
}
