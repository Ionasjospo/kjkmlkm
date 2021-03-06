namespace Ucu.Poo.Defense
{
    public class Residue
    {
        public string Name { get; set; }

        public ResidueType Type { get; set; }

    
        public bool IsOrganic()
        {
            if(this.Type.IsOrganic)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Residue(string name, ResidueType type)
        {
            this.Name = name;
            this.Type = type;
        }
    }
}