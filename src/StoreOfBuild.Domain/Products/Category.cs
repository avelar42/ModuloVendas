namespace StoreOfBuild.Domain.Products
{
    public class Category : Entity
    {
        public string Name {get; set;}

        public Category(string name)
        {
           ValidateNameAndSetName(name);
        }

        private void ValidateNameAndSetName(string name)
        {
             DomainException.When(string.IsNullOrEmpty(name), "Nome é obrigatorio");
            
            
            Name = name;
        }

        public void Update(string name)
        {
           ValidateNameAndSetName(name); 
        }
    }
}