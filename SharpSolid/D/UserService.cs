namespace SharpSolid.D;

public class UserService
{
    // The wrong way
    // private UserRepository _userRepository = new DBUserRepository();
    // private Logger _logger = new SimpleLogger();

    // The correct way
    private readonly UserRepository _userRepository;
    private readonly Logger _logger;
    
    public UserService(UserRepository userRepository, Logger logger)
    {
        _userRepository = userRepository;
        _logger = logger;
    }

    public void SaveUser(string user)
    {
        _userRepository.SaveUser(user);
        _logger.LogInformation("User has been saved.");
    }
}