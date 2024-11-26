namespace InterviewExercises.OrderDemoValidations
{
    public class OrderDemoService
    {
        private readonly IOrderDemoRepository _repository;
        public OrderDemoService(IOrderDemoRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> CreateAsync(OrderDemoModel model)
        {
            //Perform validations - Subtotal must be a positive value
            if (model.Subtotal <= 0)
            {
                throw new ArgumentException("Subtotal must be a positive value!");
            }

            await _repository.CreateAsync(model);

            return true;
        }
    }
}
