using CheckSpecialtiesUsingTheUnifiedStateExam.Components;
using CheckSpecialtiesUsingTheUnifiedStateExam.Components.Data;

namespace CheckSpecialtiesUsingTheUnifiedStateExam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents();

            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddScoped<AdmissionService>();

            builder.Services.AddHttpClient();
            builder.Services.AddScoped<YandexGptService>();

            builder.Configuration.AddUserSecrets<Program>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
