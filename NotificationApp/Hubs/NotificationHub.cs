namespace NotificationApp.Hubs
{
    using Microsoft.AspNet.SignalR;

    /// <summary>
    /// Hub de notificaciones de la aplicación.
    /// </summary>
    public class NotificationHub : Hub
    {
        /// <summary>
        /// Acción de notificación de una tarea completa.
        /// </summary>
        /// <param name="taskId">Identificador de la tarea.</param>
        /// <param name="taskResult">Resultado de la tarea.</param>
        public void Notificate(int taskId, bool taskResult)
        {
            Clients.All.markDone(taskId, taskResult);
        }
    }
}