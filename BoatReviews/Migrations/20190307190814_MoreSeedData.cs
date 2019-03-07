using Microsoft.EntityFrameworkCore.Migrations;

namespace BoatReviews.Migrations
{
    public partial class MoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Boats",
                columns: new[] { "Id", "CategoryId", "ImageLocation", "Name", "ReviewContent" },
                values: new object[,]
                {
                    { 4, 2, "Img/American14.jpg", "American14", "The American 14.6 is designed for the beginning sailor or those who are seeking a large, stable sloop that offers hassle-free sailing. This sturdy, deep-cockpit daysailer features a 6-foot 2-inch beam, glass kick-up rudder, weighted glass centerboard, and a large built-in storage compartment under the deck. Simplicity is enhanced with color-coded main and jib lines, and features simple up and down colored lines for centerboard control. The American 14.6 is recognized as an extremely stable, large, dry, daysailer providing fun for all ages." },
                    { 5, 2, "Img/WindBlazer.jpg", "Wind Blazer", "The Wind Blazer is the perfect boat for the beginner or experienced skipper.  It is simple to rig, simple to sail, very durable, and full of performance.  It is also an ideal boat for training, rental, or resort use with features hard to find in other competitive boats of this size and price range.  The mainsail on the Wind Blazer is sleeved over a two piece mast, which makes transport easier.  The rudder system features a stainless steel rudder head and heavy duty stainless steel mounting bracket on the transom.  The hull is constructed of hand laid fiberglass utilizing a sandwich core of coremat. All the hardware is backed up with aluminum plates under the fiberglass instead of commonly used wood making all the hardware attachment points extremely strong. The high performance hull design features a high entry bow with a roll v, which is designed to lift the bow of the Wind Blazer through the waves and allow for greater performance from the planing hull." },
                    { 6, 2, "Img/Catamaran.jpg", "Aqua Cat", "One of the world's most popular one designs, catamarans bring you performance, simplicity, and weight carrying capabilities. Featuring wide, flat bottom hulls with turned up bows and a small keel skeg, the pontoon design is unequaled in weight carrying capacity and planing speed. The small keels have replaced the daggerboards used on the smaller Aqua Cat and allow for easy beaching thru the surf. Designed for ocean sailing or inland lakes this cat has it all. The Aqua Cat 14 is ideal for four large adults or where capabilities to support 1,000 lbs. are needed. Standard features include spring loaded kick up rudders, 105 sq. ft. Dacron two colored sail, a 360 quick release cleat and rudder lift systems. Available with white hulls with red side stripes and four sail combinations, the Aqua Cat offers a performance fun package not to be missed. Experience the Aqua Cat feeling." },
                    { 7, 3, "Img/Sculling.jpg", "Edon", "The most affordable recreational sculling boats in the USA, a rowing boat for all ages and all experience levels. A real rowing boat at an affordable price. We love Edon TS515 rowing boats with their fast streamlined but stable hull, they are light and easy to row and they come complete with removable pontoon stabilizers that keep the boat from flipping when learning or when rowing on cold water. Made of tough polyethylene that is damage resistant and unaffected by UV the Edon TS515 is the perfect rowing boat for exercise and fun, whether you are an experienced sculler or just starting out." },
                    { 8, 3, "Img/Minto9RowBoat.jpg", "Minto", "Rowboats, as opposed to canoes and kayaks, are propelled by oars that are held in place at a pivot point attached to the boat, the oarlocks (also called rowlocks). These pivot point do not change their position as the boat is rowed. This pivot point is a fulcrum if the oar is a lever. Rowers typically face the stern of the boat. Various clever mechanisms have been tried to allow the rower to face forward but none so far have been widely adopted." },
                    { 9, 3, "Img/PedalBoat.jpg", "Pelican", "A standard pedal boat is powered by people who are using the pedals, which turn a paddle wheel located under the watercraft. Pedal boats are a favorite choice for families mostly because of how simple they are to use and steer, and because they’re safe for the whole family. Both the pedals and the lever for steering are located in the front, so the adults are responsible for navigating around the water and powering the pedal boats, while kids enjoy in the back. If you’re out on the lake with your friends, you can switch between yourself so everyone gets a chance to try their hand at pedaling." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
