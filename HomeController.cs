using System;

public class HomeController : Controller
{

	private readonly IUserRepository repository

	public HomeController(IUserRepository repository)
	{
		_repository = repository
	}


	[HttpGet]
	public IAsyncResult Index()
    {
		return Veiw(IUserRepository.GetAll());
    }
}
