using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InvoiceAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customers",
                newName: "Name");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Invoices",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "IdentityCard", "Name" },
                values: new object[,]
                {
                    { 1, "IC001", "Customer 1" },
                    { 2, "IC002", "Customer 2" },
                    { 3, "IC003", "Customer 3" },
                    { 4, "IC004", "Customer 4" },
                    { 5, "IC005", "Customer 5" },
                    { 6, "IC006", "Customer 6" },
                    { 7, "IC007", "Customer 7" },
                    { 8, "IC008", "Customer 8" },
                    { 9, "IC009", "Customer 9" },
                    { 10, "IC0010", "Customer 10" },
                    { 11, "IC0011", "Customer 11" },
                    { 12, "IC0012", "Customer 12" },
                    { 13, "IC0013", "Customer 13" },
                    { 14, "IC0014", "Customer 14" },
                    { 15, "IC0015", "Customer 15" },
                    { 16, "IC0016", "Customer 16" },
                    { 17, "IC0017", "Customer 17" },
                    { 18, "IC0018", "Customer 18" },
                    { 19, "IC0019", "Customer 19" },
                    { 20, "IC0020", "Customer 20" },
                    { 21, "IC0021", "Customer 21" },
                    { 22, "IC0022", "Customer 22" },
                    { 23, "IC0023", "Customer 23" },
                    { 24, "IC0024", "Customer 24" },
                    { 25, "IC0025", "Customer 25" },
                    { 26, "IC0026", "Customer 26" },
                    { 27, "IC0027", "Customer 27" },
                    { 28, "IC0028", "Customer 28" },
                    { 29, "IC0029", "Customer 29" },
                    { 30, "IC0030", "Customer 30" },
                    { 31, "IC0031", "Customer 31" },
                    { 32, "IC0032", "Customer 32" },
                    { 33, "IC0033", "Customer 33" },
                    { 34, "IC0034", "Customer 34" },
                    { 35, "IC0035", "Customer 35" },
                    { 36, "IC0036", "Customer 36" },
                    { 37, "IC0037", "Customer 37" },
                    { 38, "IC0038", "Customer 38" },
                    { 39, "IC0039", "Customer 39" },
                    { 40, "IC0040", "Customer 40" },
                    { 41, "IC0041", "Customer 41" },
                    { 42, "IC0042", "Customer 42" },
                    { 43, "IC0043", "Customer 43" },
                    { 44, "IC0044", "Customer 44" },
                    { 45, "IC0045", "Customer 45" },
                    { 46, "IC0046", "Customer 46" },
                    { 47, "IC0047", "Customer 47" },
                    { 48, "IC0048", "Customer 48" },
                    { 49, "IC0049", "Customer 49" },
                    { 50, "IC0050", "Customer 50" },
                    { 51, "IC0051", "Customer 51" },
                    { 52, "IC0052", "Customer 52" },
                    { 53, "IC0053", "Customer 53" },
                    { 54, "IC0054", "Customer 54" },
                    { 55, "IC0055", "Customer 55" },
                    { 56, "IC0056", "Customer 56" },
                    { 57, "IC0057", "Customer 57" },
                    { 58, "IC0058", "Customer 58" },
                    { 59, "IC0059", "Customer 59" },
                    { 60, "IC0060", "Customer 60" },
                    { 61, "IC0061", "Customer 61" },
                    { 62, "IC0062", "Customer 62" },
                    { 63, "IC0063", "Customer 63" },
                    { 64, "IC0064", "Customer 64" },
                    { 65, "IC0065", "Customer 65" },
                    { 66, "IC0066", "Customer 66" },
                    { 67, "IC0067", "Customer 67" },
                    { 68, "IC0068", "Customer 68" },
                    { 69, "IC0069", "Customer 69" },
                    { 70, "IC0070", "Customer 70" },
                    { 71, "IC0071", "Customer 71" },
                    { 72, "IC0072", "Customer 72" },
                    { 73, "IC0073", "Customer 73" },
                    { 74, "IC0074", "Customer 74" },
                    { 75, "IC0075", "Customer 75" },
                    { 76, "IC0076", "Customer 76" },
                    { 77, "IC0077", "Customer 77" },
                    { 78, "IC0078", "Customer 78" },
                    { 79, "IC0079", "Customer 79" },
                    { 80, "IC0080", "Customer 80" },
                    { 81, "IC0081", "Customer 81" },
                    { 82, "IC0082", "Customer 82" },
                    { 83, "IC0083", "Customer 83" },
                    { 84, "IC0084", "Customer 84" },
                    { 85, "IC0085", "Customer 85" },
                    { 86, "IC0086", "Customer 86" },
                    { 87, "IC0087", "Customer 87" },
                    { 88, "IC0088", "Customer 88" },
                    { 89, "IC0089", "Customer 89" },
                    { 90, "IC0090", "Customer 90" },
                    { 91, "IC0091", "Customer 91" },
                    { 92, "IC0092", "Customer 92" },
                    { 93, "IC0093", "Customer 93" },
                    { 94, "IC0094", "Customer 94" },
                    { 95, "IC0095", "Customer 95" },
                    { 96, "IC0096", "Customer 96" },
                    { 97, "IC0097", "Customer 97" },
                    { 98, "IC0098", "Customer 98" },
                    { 99, "IC0099", "Customer 99" },
                    { 100, "IC00100", "Customer 100" }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "Amount", "CustomerId", "Date", "Status" },
                values: new object[,]
                {
                    { 1, 101m, 1, new DateTime(2023, 7, 9, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2727), "Unpaid" },
                    { 2, 102m, 2, new DateTime(2023, 7, 8, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2775), "Paid" },
                    { 3, 103m, 3, new DateTime(2023, 7, 7, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2778), "Unpaid" },
                    { 4, 104m, 4, new DateTime(2023, 7, 6, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2780), "Paid" },
                    { 5, 105m, 5, new DateTime(2023, 7, 5, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2785), "Unpaid" },
                    { 6, 106m, 6, new DateTime(2023, 7, 4, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2788), "Paid" },
                    { 7, 107m, 7, new DateTime(2023, 7, 3, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2791), "Unpaid" },
                    { 8, 108m, 8, new DateTime(2023, 7, 2, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2794), "Paid" },
                    { 9, 109m, 9, new DateTime(2023, 7, 1, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2797), "Unpaid" },
                    { 10, 110m, 10, new DateTime(2023, 6, 30, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2801), "Paid" },
                    { 11, 111m, 11, new DateTime(2023, 6, 29, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2804), "Unpaid" },
                    { 12, 112m, 12, new DateTime(2023, 6, 28, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2807), "Paid" },
                    { 13, 113m, 13, new DateTime(2023, 6, 27, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2810), "Unpaid" },
                    { 14, 114m, 14, new DateTime(2023, 6, 26, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2812), "Paid" },
                    { 15, 115m, 15, new DateTime(2023, 6, 25, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2815), "Unpaid" },
                    { 16, 116m, 16, new DateTime(2023, 6, 24, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2818), "Paid" },
                    { 17, 117m, 17, new DateTime(2023, 6, 23, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2821), "Unpaid" },
                    { 18, 118m, 18, new DateTime(2023, 6, 22, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2825), "Paid" },
                    { 19, 119m, 19, new DateTime(2023, 6, 21, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2828), "Unpaid" },
                    { 20, 120m, 20, new DateTime(2023, 6, 20, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2830), "Paid" },
                    { 21, 121m, 21, new DateTime(2023, 6, 19, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2833), "Unpaid" },
                    { 22, 122m, 22, new DateTime(2023, 6, 18, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2835), "Paid" },
                    { 23, 123m, 23, new DateTime(2023, 6, 17, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2838), "Unpaid" },
                    { 24, 124m, 24, new DateTime(2023, 6, 16, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2841), "Paid" },
                    { 25, 125m, 25, new DateTime(2023, 6, 15, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2843), "Unpaid" },
                    { 26, 126m, 26, new DateTime(2023, 6, 14, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2846), "Paid" },
                    { 27, 127m, 27, new DateTime(2023, 6, 13, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2849), "Unpaid" },
                    { 28, 128m, 28, new DateTime(2023, 6, 12, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2852), "Paid" },
                    { 29, 129m, 29, new DateTime(2023, 6, 11, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2905), "Unpaid" },
                    { 30, 130m, 30, new DateTime(2023, 6, 10, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2908), "Paid" },
                    { 31, 131m, 31, new DateTime(2023, 6, 9, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2911), "Unpaid" },
                    { 32, 132m, 32, new DateTime(2023, 6, 8, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2914), "Paid" },
                    { 33, 133m, 33, new DateTime(2023, 6, 7, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2917), "Unpaid" },
                    { 34, 134m, 34, new DateTime(2023, 6, 6, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2921), "Paid" },
                    { 35, 135m, 35, new DateTime(2023, 6, 5, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2924), "Unpaid" },
                    { 36, 136m, 36, new DateTime(2023, 6, 4, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2927), "Paid" },
                    { 37, 137m, 37, new DateTime(2023, 6, 3, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2929), "Unpaid" },
                    { 38, 138m, 38, new DateTime(2023, 6, 2, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2932), "Paid" },
                    { 39, 139m, 39, new DateTime(2023, 6, 1, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2935), "Unpaid" },
                    { 40, 140m, 40, new DateTime(2023, 5, 31, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2937), "Paid" },
                    { 41, 141m, 41, new DateTime(2023, 5, 30, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2940), "Unpaid" },
                    { 42, 142m, 42, new DateTime(2023, 5, 29, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2943), "Paid" },
                    { 43, 143m, 43, new DateTime(2023, 5, 28, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2946), "Unpaid" },
                    { 44, 144m, 44, new DateTime(2023, 5, 27, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2948), "Paid" },
                    { 45, 145m, 45, new DateTime(2023, 5, 26, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2951), "Unpaid" },
                    { 46, 146m, 46, new DateTime(2023, 5, 25, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2954), "Paid" },
                    { 47, 147m, 47, new DateTime(2023, 5, 24, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2956), "Unpaid" },
                    { 48, 148m, 48, new DateTime(2023, 5, 23, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2959), "Paid" },
                    { 49, 149m, 49, new DateTime(2023, 5, 22, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2962), "Unpaid" },
                    { 50, 150m, 50, new DateTime(2023, 5, 21, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2964), "Paid" },
                    { 51, 151m, 51, new DateTime(2023, 5, 20, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2967), "Unpaid" },
                    { 52, 152m, 52, new DateTime(2023, 5, 19, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2970), "Paid" },
                    { 53, 153m, 53, new DateTime(2023, 5, 18, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2973), "Unpaid" },
                    { 54, 154m, 54, new DateTime(2023, 5, 17, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2975), "Paid" },
                    { 55, 155m, 55, new DateTime(2023, 5, 16, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2978), "Unpaid" },
                    { 56, 156m, 56, new DateTime(2023, 5, 15, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2981), "Paid" },
                    { 57, 157m, 57, new DateTime(2023, 5, 14, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2983), "Unpaid" },
                    { 58, 158m, 58, new DateTime(2023, 5, 13, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2986), "Paid" },
                    { 59, 159m, 59, new DateTime(2023, 5, 12, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2989), "Unpaid" },
                    { 60, 160m, 60, new DateTime(2023, 5, 11, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2991), "Paid" },
                    { 61, 161m, 61, new DateTime(2023, 5, 10, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2994), "Unpaid" },
                    { 62, 162m, 62, new DateTime(2023, 5, 9, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2997), "Paid" },
                    { 63, 163m, 63, new DateTime(2023, 5, 8, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(2999), "Unpaid" },
                    { 64, 164m, 64, new DateTime(2023, 5, 7, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3028), "Paid" },
                    { 65, 165m, 65, new DateTime(2023, 5, 6, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3032), "Unpaid" },
                    { 66, 166m, 66, new DateTime(2023, 5, 5, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3036), "Paid" },
                    { 67, 167m, 67, new DateTime(2023, 5, 4, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3038), "Unpaid" },
                    { 68, 168m, 68, new DateTime(2023, 5, 3, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3041), "Paid" },
                    { 69, 169m, 69, new DateTime(2023, 5, 2, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3044), "Unpaid" },
                    { 70, 170m, 70, new DateTime(2023, 5, 1, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3046), "Paid" },
                    { 71, 171m, 71, new DateTime(2023, 4, 30, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3049), "Unpaid" },
                    { 72, 172m, 72, new DateTime(2023, 4, 29, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3052), "Paid" },
                    { 73, 173m, 73, new DateTime(2023, 4, 28, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3054), "Unpaid" },
                    { 74, 174m, 74, new DateTime(2023, 4, 27, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3057), "Paid" },
                    { 75, 175m, 75, new DateTime(2023, 4, 26, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3060), "Unpaid" },
                    { 76, 176m, 76, new DateTime(2023, 4, 25, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3063), "Paid" },
                    { 77, 177m, 77, new DateTime(2023, 4, 24, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3065), "Unpaid" },
                    { 78, 178m, 78, new DateTime(2023, 4, 23, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3068), "Paid" },
                    { 79, 179m, 79, new DateTime(2023, 4, 22, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3071), "Unpaid" },
                    { 80, 180m, 80, new DateTime(2023, 4, 21, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3073), "Paid" },
                    { 81, 181m, 81, new DateTime(2023, 4, 20, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3076), "Unpaid" },
                    { 82, 182m, 82, new DateTime(2023, 4, 19, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3078), "Paid" },
                    { 83, 183m, 83, new DateTime(2023, 4, 18, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3081), "Unpaid" },
                    { 84, 184m, 84, new DateTime(2023, 4, 17, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3084), "Paid" },
                    { 85, 185m, 85, new DateTime(2023, 4, 16, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3087), "Unpaid" },
                    { 86, 186m, 86, new DateTime(2023, 4, 15, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3089), "Paid" },
                    { 87, 187m, 87, new DateTime(2023, 4, 14, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3092), "Unpaid" },
                    { 88, 188m, 88, new DateTime(2023, 4, 13, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3095), "Paid" },
                    { 89, 189m, 89, new DateTime(2023, 4, 12, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3097), "Unpaid" },
                    { 90, 190m, 90, new DateTime(2023, 4, 11, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3100), "Paid" },
                    { 91, 191m, 91, new DateTime(2023, 4, 10, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3103), "Unpaid" },
                    { 92, 192m, 92, new DateTime(2023, 4, 9, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3105), "Paid" },
                    { 93, 193m, 93, new DateTime(2023, 4, 8, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3108), "Unpaid" },
                    { 94, 194m, 94, new DateTime(2023, 4, 7, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3111), "Paid" },
                    { 95, 195m, 95, new DateTime(2023, 4, 6, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3140), "Unpaid" },
                    { 96, 196m, 96, new DateTime(2023, 4, 5, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3142), "Paid" },
                    { 97, 197m, 97, new DateTime(2023, 4, 4, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3145), "Unpaid" },
                    { 98, 198m, 98, new DateTime(2023, 4, 3, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3148), "Paid" },
                    { 99, 199m, 99, new DateTime(2023, 4, 2, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3150), "Unpaid" },
                    { 100, 200m, 100, new DateTime(2023, 4, 1, 21, 1, 41, 203, DateTimeKind.Local).AddTicks(3154), "Paid" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 100);

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customers",
                newName: "LastName");

            migrationBuilder.AlterColumn<float>(
                name: "Amount",
                table: "Invoices",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
