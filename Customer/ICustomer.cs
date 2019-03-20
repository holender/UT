using System.Collections.Generic;

namespace WorkShop.Customer
{
    public interface ICustomer
    {
        string FirstName { get; set; }

        IPhoneNumber PhoneNumber { get; set; }
        IList<IOrder> Orders { get; set; }

        int GetAge();
    }
	public interface IPhoneNumber
	{
		string Mobile { get; set; }
	}
	public interface IOrder
	{
		int Id { get; set; }
		decimal Price { get; set; }
	}

	public interface ICustomerValidator
	{
		bool Validate(ICustomer customer);
	}
}