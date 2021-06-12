using Microsoft.EntityFrameworkCore.Migrations;

namespace Cat_Adoption.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "adopter",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adopter", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "location",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "owner",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owner", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vaccination = table.Column<bool>(type: "bit", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    AdopterId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cat", x => x.id);
                    table.ForeignKey(
                        name: "FK_cat_adopter_AdopterId",
                        column: x => x.AdopterId,
                        principalTable: "adopter",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cat_location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "location",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cat_owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "owner",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "adopter",
                columns: new[] { "id", "age", "email", "gender", "image", "name", "occupation", "phone" },
                values: new object[,]
                {
                    { 1, 42, "koko@gmail.com", "male", "https://images.unsplash.com/photo-1521119989659-a83eee488004?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=728&q=80", "Ken", null, " 85454995042 " },
                    { 2, 30, "momo@gmail.com", "female", "https://images.unsplash.com/photo-1514448553123-ddc6ee76fd52?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=668&q=80", "Natasha", null, " 46736437743 " }
                });

            migrationBuilder.InsertData(
                table: "location",
                columns: new[] { "id", "address", "name", "phone" },
                values: new object[,]
                {
                    { 1, "505 broadway st", "Vetsreet", "303849244" },
                    { 2, "404 broadway st", "Pawpatrol", "758348939" },
                    { 3, "303 broadway st", "smartPet", " 7548484844 " },
                    { 4, "202 broadway st", "walmart", " 657474384 " },
                    { 5, "102 broadway st", "Pet", " 7548484844 " },
                    { 6, "30 broadway st", "kittycat", " 8545499504 " },
                    { 7, "30 broadway st2", "kittycat2", " 85454995042 " }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "id", "age", "email", "gender", "image", "name", "phone", "reason" },
                values: new object[,]
                {
                    { 1, 24, "roro@gmail.com", "female", "https://images.unsplash.com/photo-1508002366005-75a695ee2d17?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=634&q=80", "Rose", " 85454995042 ", "relocating" },
                    { 2, 54, "jojo@gmail.com", "male", "https://images.unsplash.com/photo-1472099645785-5658abf4ff4e?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80", "Jack", " 46736437743 ", "relocating" }
                });

            migrationBuilder.InsertData(
                table: "cat",
                columns: new[] { "id", "AdopterId", "LocationId", "OwnerId", "age", "breed", "description", "gender", "image", "name", "vaccination" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, "young", "Domestic Shorthair", "Hi! My name is Kat and I’m an extremely friendly curious and social 1 year old. ( Shy at first of course...;)...)....I’m told I have exotic unique markings with silky coat you can’t even dream of ...;) My ideal home has very affectionate humans who don’t mind my daily exploring. I’m super flirty and love cuddling in with my foster mom in her bed and my siblings as well. If you’re looking for a cat with a dog personality then I will be your gal. ♥️", "female", "https://pet-uploads.adoptapet.com/6/2/9/547432893.jpg", "Kat", true },
                    { 2, 1, 2, 1, "young", " Bengal", " They are named Beauregaurd and Antoine. They are the smartest cats I have ever interacted with and and know words and love one another deeply. They are loving yet independent and will play for hours on end with either myself or another. I have an enclosed outdoor space they love to hang out in.", "male", "https://pet-uploads.adoptapet.com/8/b/9/546264169.jpg", "Antoine and Beauregaurd", true },
                    { 3, 1, 3, 1, "young", "Domestic Shorthair", "Meet the ever-glamorous Elizabeth Taylor.she's 10 months old, like most celebrities, she’s reclusive and prefers a quiet environment. Elizabeth is also very shy and will require someone with patience. However, she is not shy when it’s time for cat treats! Elizabeth is a strict pescatarian, enjoying the finest fish and seafood. She also enjoys living her best life playing with her favorite toy balls. This exquisite girl has the most beautiful markings with a black whip-like tail and bangs. She is a glamorous girl and is looking for her up upscale forever home.", "female", "https://pet-uploads.adoptapet.com/8/8/f/442558865.jpg", "Elizabeth Taylor", true },
                    { 4, 1, 4, 2, "Adult", "Domestic Shorthair", "Nyx is a 3 years black domestic short hair cat. She is a very loving cat when she gets comfortable around you. Nyx loves playing with stuffed mice, but mainly loves lounging around the house. She is always by the door when I come home and will come say goodbye when I have to leave. She will be a bit shy at first until she gets comfortable with her surroundings. She originally was rescued from a very sad situation where she was not taken care of properly. She will require a home that is quiet and low key, and a person that will be patient with her and allow her to get used to new surroundings. Nyx has so much love to give- will you give her that chance?", "female", "https://pet-uploads.adoptapet.com/2/9/5/516563701.jpg", "Nyx", true },
                    { 5, 1, 5, 2, "young", "Domestic Shorthair", "Hello there! I’m Pepper, nice to meet ya!I'm 10 months old I’m a wee sweet sleepy boy looking for my tender and loving FUREVER home! One of my nicknames is Dr. Pepper! I have a doctorate in adorable from Major Cuties University. Not to brag but I graduated at the top of my class! The black smudge on my nose and spotted coat are how I got my name. My smudge and my cute little overbite are my most precious features; but I have too many to count them all. I’m quite a handsome kitten! I’m really excited to live with other kitties and maybe even a doggy! My foster home is full of furbabies- cats of all ages and even a dog! I’m well adjusted, and brave around new people!", "male", "https://pet-uploads.adoptapet.com/e/5/a/536736979.jpg", "Pepper", true },
                    { 6, 1, 6, 2, "Adult", "Domestic Shorthair", "Gracie Mae is a 5 years sweet and confident girl--very adventurous and brave! She's bonded to her sister, Hope, and the two ladies will be 4 years old in May 2020. Gracie Mae loves to explore and play. She also loves to cuddle A LOT. She is a talkative young lady and really enjoys affection. She may be shy with new people, but once she settles in, she's a lovebug.", "female", "https://pet-uploads.adoptapet.com/7/9/6/477702221.jpg", "Mae", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_cat_AdopterId",
                table: "cat",
                column: "AdopterId");

            migrationBuilder.CreateIndex(
                name: "IX_cat_LocationId",
                table: "cat",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cat_OwnerId",
                table: "cat",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cat");

            migrationBuilder.DropTable(
                name: "adopter");

            migrationBuilder.DropTable(
                name: "location");

            migrationBuilder.DropTable(
                name: "owner");
        }
    }
}
