using Ardalis.SmartEnum;

namespace USP.Domain.Enums;

public abstract class Category(string name, int value) : SmartEnum<Category>(name, value)
{
    public abstract string NameOfCategory { get; }
    public abstract string DescriptionOfCategory { get; }

    public abstract string CheckSubcategories();

    public static Category Automobili = new AutomobiliCategory();
    public static Category Muzika = new MuzikaCategory();
    
    private class AutomobiliCategory() : Category(nameof(Automobili), 0)
    {
        public override string NameOfCategory => "Automobili";
        public override string DescriptionOfCategory => "Automobili kao prevozna sredstva";

        public override string CheckSubcategories()
        {
            throw new NotImplementedException();
        }
    }
    
    private class MuzikaCategory() : Category(nameof(Muzika), 1)
    {
        public override string NameOfCategory => "Muzika";
        public override string DescriptionOfCategory => "Neki opis za muzika kategoriju";
        
        public override string CheckSubcategories()
        {
            throw new NotImplementedException();
        }
    }
}