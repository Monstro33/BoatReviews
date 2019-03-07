﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BoatReviews.Migrations
{
    public partial class ChangedSeedDataBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageLocation",
                value: "Img/SeaRayBig.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageLocation",
                value: "Img/SeaRay1.jpg");
        }
    }
}