using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DI
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjM3NjUxOUAzMjMxMmUzMDJlMzBtMXE1YThVWDlsQ3lrNHU1V3JiQWJ1amhINzNVTnVDZkRqbnVyT2xyMFZ3PQ==;Mgo+DSMBaFt+QHJqVk1mQ1BDaV1CX2BZdllzRmlaeU4BCV5EYF5SRHBeQl1rTH1QcENhW3k=;Mgo+DSMBMAY9C3t2VFhiQlJPcEBDWnxLflF1VWtTel16d1NWESFaRnZdQV1lSH5TfkBgWnlYc3JT;Mgo+DSMBPh8sVXJ1S0R+X1pCaV5FQmFJfFBmTWlcfFRzckU3HVdTRHRcQltiSX5bc0ZgX3lbcXI=;MjM3NjUyM0AzMjMxMmUzMDJlMzBWbG53ZUdyMkZLVVlzTDN0NlZHb2VzT2gyY0pvUEdwMGFJbFpKV1FtYURVPQ==;NRAiBiAaIQQuGjN/V0d+Xk9HfVldXGRWfFN0RnNRdVtzflZAcC0sT3RfQF5jT39Tdk1mWnxYdnxdQA==;ORg4AjUWIQA/Gnt2VFhiQlJPcEBDWnxLflF1VWtTel16d1NWESFaRnZdQV1lSH5TfkBgWnlZcHdT;MjM3NjUyNkAzMjMxMmUzMDJlMzBkRmY2eTZpZG05NWNGZzZock1zY1NjKy91QU5KRE5WWWVqMWVvbXZsV0lNPQ==;MjM3NjUyN0AzMjMxMmUzMDJlMzBLUjVvdWoyS2s3NTdUQUxrcHVncWdPcENzaWxKbktaU3VMYzVUek9IQjk4PQ==;MjM3NjUyOEAzMjMxMmUzMDJlMzBLKzlYTFZXcGRQVU1YYmZDRG92T3BLTzRwQUp1M1hFSlFZcWRPb05WQmtRPQ==;MjM3NjUyOUAzMjMxMmUzMDJlMzBTNk9zSzU0Vk9peXIzbFhxN1B6L1gzK1FEM2tLbmV0RktmY1NsemE1UWU0PQ==;MjM3NjUzMEAzMjMxMmUzMDJlMzBtMXE1YThVWDlsQ3lrNHU1V3JiQWJ1amhINzNVTnVDZkRqbnVyT2xyMFZ3PQ==");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
