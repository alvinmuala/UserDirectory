using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserDirectory.Data.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "varchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "varchar(max)", nullable: true),
                    Address = table.Column<string>(type: "varchar(max)", nullable: true),
                    City = table.Column<string>(type: "varchar(max)", nullable: true),
                    Country = table.Column<string>(type: "varchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "varchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Address", "City", "Country", "EmailAddress", "FirstName", "LastName", "ZipCode" },
                values: new object[,]
                {
                    { 1, "76 Sherman Road", "Hastings", "Aruba", "emma.dunham@vtgrafix.gov", "Emma", "Dunham", "06830" },
                    { 2, "18 Hartswood Road", "Stanford", "Algeria", "ivan.risley@nitrosystems.co", "Ivan", "Risley", "04346" },
                    { 3, "56 Canal Street", "London", "Iceland", "rikki.paquette@anaplex.xyz", "Rikki", "Paquette", "16935" },
                    { 4, "55 Wooster Road", "Adelaide", "Eritrea", "roman.bourne@baramax.co", "Roman", "Bourne", "46446" },
                    { 5, "31 Bramble Lane", "Auckland", "Netherlands", "lyn.chapman@loopsys.xyz", "Lyn", "Chapman", "45893" },
                    { 6, "42 Walford Way", "Beaverton", "France", "rosie.finn@sealine.co", "Rosie", "Finn", "10697" },
                    { 7, "38 Colwood Place", "Wilmington", "Guatemala", "cedric.webster@solexis.co", "Cedric", "Webster", "01521" },
                    { 8, "50 Hunt Street", "Cardiff", "Tanzania, United Republic of", "rosanne.starck@dalserve.org", "Rosanne", "Starck", "65339" },
                    { 9, "22 Clarendon Street", "Portsmouth", "Guernsey", "emma.young@terralabs.info", "Emma", "Young", "02285" },
                    { 10, "85 Golden Lane", "Medford", "Nigeria", "stan.milling@corerobotics.gov", "Stan", "Milling", "29916" },
                    { 11, "50 Mount Street", "Woodville", "Puerto Rico", "jenette.oldman@hivemind.biz", "Jenette", "Oldman", "47870" },
                    { 12, "30 Buckley Street", "Tacoma", "Latvia", "max.hyder@polycore.gov", "Max", "Hyder", "73729" },
                    { 13, "26 Mercer Street", "Hobart", "Hong Kong", "juliana.kelsey@grafixmedia.xyz", "Juliana", "Kelsey", "98550" },
                    { 14, "64 Bramble Lane", "Adelaide", "Malta", "adam.hollis@triosys.co", "Adam", "Hollis", "50998" },
                    { 15, "52 Orchard Road", "Boston", "Norfolk Island", "alexis.brandt@terralabs.gov", "Alexis", "Brandt", "56707" },
                    { 16, "42 Glenn Drive", "Toledo", "Nicaragua", "travis.cappel@ulogica.gov", "Travis", "Cappel", "54985" },
                    { 17, "89 Rivington Street", "Lancaster", "Congo", "layla.flinn@seelogic.club", "Layla", "Flinn", "40390" },
                    { 18, "87 Coleman Avenue", "Durham", "Guyana", "raylene.sager@infratouch.net", "Raylene", "Sager", "85733" },
                    { 19, "73 Robinson Street", "Wilmington", "Zambia", "chloe.turner@playtech.mobi", "Chloe", "Turner", "82963" },
                    { 20, "45 Windsor Avenue", "Sheffield", "Zimbabwe", "roman.porras@mediadime.xyz", "Roman", "Porras", "05706" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
