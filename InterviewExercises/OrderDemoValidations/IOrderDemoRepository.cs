namespace InterviewExercises.OrderDemoValidations
{
    public interface IOrderDemoRepository
    {
        Task CreateAsync(OrderDemoModel model);
    }
}
