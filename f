[1mdiff --git a/.vs/ProjectEvaluation/s4h.metadata.v7.bin b/.vs/ProjectEvaluation/s4h.metadata.v7.bin[m
[1mindex 0d0004f..3284b48 100644[m
Binary files a/.vs/ProjectEvaluation/s4h.metadata.v7.bin and b/.vs/ProjectEvaluation/s4h.metadata.v7.bin differ
[1mdiff --git a/.vs/ProjectEvaluation/s4h.projects.v7.bin b/.vs/ProjectEvaluation/s4h.projects.v7.bin[m
[1mindex 95473d5..fbe3707 100644[m
Binary files a/.vs/ProjectEvaluation/s4h.projects.v7.bin and b/.vs/ProjectEvaluation/s4h.projects.v7.bin differ
[1mdiff --git a/.vs/s4h/DesignTimeBuild/.dtbcache.v2 b/.vs/s4h/DesignTimeBuild/.dtbcache.v2[m
[1mindex 95a65ff..0e9454f 100644[m
Binary files a/.vs/s4h/DesignTimeBuild/.dtbcache.v2 and b/.vs/s4h/DesignTimeBuild/.dtbcache.v2 differ
[1mdiff --git a/.vs/s4h/FileContentIndex/46295638-136a-41ba-a434-8710ef11cd25.vsidx b/.vs/s4h/FileContentIndex/46295638-136a-41ba-a434-8710ef11cd25.vsidx[m
[1mdeleted file mode 100644[m
[1mindex 07e489f..0000000[m
Binary files a/.vs/s4h/FileContentIndex/46295638-136a-41ba-a434-8710ef11cd25.vsidx and /dev/null differ
[1mdiff --git a/.vs/s4h/FileContentIndex/4aba5d1b-c63a-4007-b359-f52ebe287859.vsidx b/.vs/s4h/FileContentIndex/4aba5d1b-c63a-4007-b359-f52ebe287859.vsidx[m
[1mdeleted file mode 100644[m
[1mindex 1b5ac31..0000000[m
Binary files a/.vs/s4h/FileContentIndex/4aba5d1b-c63a-4007-b359-f52ebe287859.vsidx and /dev/null differ
[1mdiff --git a/.vs/s4h/FileContentIndex/bd13b26e-82a3-4e49-bb29-89670abbe8ba.vsidx b/.vs/s4h/FileContentIndex/bd13b26e-82a3-4e49-bb29-89670abbe8ba.vsidx[m
[1mdeleted file mode 100644[m
[1mindex f1a01af..0000000[m
Binary files a/.vs/s4h/FileContentIndex/bd13b26e-82a3-4e49-bb29-89670abbe8ba.vsidx and /dev/null differ
[1mdiff --git a/.vs/s4h/FileContentIndex/d5dc8801-8395-4999-b142-4a9fb9731ffb.vsidx b/.vs/s4h/FileContentIndex/d5dc8801-8395-4999-b142-4a9fb9731ffb.vsidx[m
[1mdeleted file mode 100644[m
[1mindex 843a06c..0000000[m
Binary files a/.vs/s4h/FileContentIndex/d5dc8801-8395-4999-b142-4a9fb9731ffb.vsidx and /dev/null differ
[1mdiff --git a/.vs/s4h/v17/.futdcache.v2 b/.vs/s4h/v17/.futdcache.v2[m
[1mindex 8190ab6..8857e17 100644[m
Binary files a/.vs/s4h/v17/.futdcache.v2 and b/.vs/s4h/v17/.futdcache.v2 differ
[1mdiff --git a/.vs/s4h/v17/.suo b/.vs/s4h/v17/.suo[m
[1mindex 5c36051..acd956e 100644[m
Binary files a/.vs/s4h/v17/.suo and b/.vs/s4h/v17/.suo differ
[1mdiff --git a/Controllers/HomeController.cs b/Controllers/HomeController.cs[m
[1mindex 5e50c8d..94ae888 100644[m
[1m--- a/Controllers/HomeController.cs[m
[1m+++ b/Controllers/HomeController.cs[m
[36m@@ -28,6 +28,17 @@[m [mnamespace s4h.Controllers[m
             return View();[m
         }[m
 [m
[32m+[m[32m        [HttpGet][m[41m[m
[32m+[m[32m        public object GetStandards(DataSourceLoadOptions loadOptions)[m[41m[m
[32m+[m[32m        {[m[41m[m
[32m+[m[32m            return DataSourceLoader.Load(hotelDbContext.RosRoomStandards, loadOptions);[m[41m[m
[32m+[m[32m        }[m[41m[m
[32m+[m[41m[m
[32m+[m[32m        [HttpGet][m[41m[m
[32m+[m[32m        public object GetLocs(DataSourceLoadOptions loadOptions)[m[41m[m
[32m+[m[32m        {[m[41m[m
[32m+[m[32m            return DataSourceLoader.Load(hotelDbContext.LocLocals, loadOptions);[m[41m[m
[32m+[m[32m        }[m[41m[m
 [m
         [HttpGet][m
         public object GetRooms(DataSourceLoadOptions loadOptions)[m
[1mdiff --git a/Data/TreeViewData.cs b/Data/TreeViewData.cs[m
[1mindex 2e85ec5..ee3e0a2 100644[m
[1m--- a/Data/TreeViewData.cs[m
[1m+++ b/Data/TreeViewData.cs[m
[36m@@ -12,8 +12,14 @@[m [mnamespace DevExtreme.NETCore.Demos.Models.SampleData[m
                 ID = "1",[m
                 Text = "Pokoje",[m
                 Expanded = false,[m
[31m-                Image = "../../images/ProductsLarge/1.png",[m
[32m+[m[32m                Image = "filter",[m[41m[m
             },[m
[32m+[m[32m            // new Menu {[m[41m[m
[32m+[m[32m            //    ID = "2",[m[41m[m
[32m+[m[32m            //    Text = "Inne",[m[41m[m
[32m+[m[32m            //    Expanded = false,[m[41m[m
[32m+[m[32m            //    Image = "group",[m[41m[m
[32m+[m[32m            //},[m[41m[m
         };[m
     }[m
 }[m
\ No newline at end of file[m
[1mdiff --git a/Models/S4hHotelonlineContext.cs b/Models/S4hHotelonlineContext.cs[m
[1mindex 82ee57e..b63ff56 100644[m
[1m--- a/Models/S4hHotelonlineContext.cs[m
[1m+++ b/Models/S4hHotelonlineContext.cs[m
[36m@@ -16,6 +16,9 @@[m [mpublic partial class S4hHotelonlineContext : DbContext[m
     }[m
 [m
     public virtual DbSet<RomRoom> RomRooms { get; set; }[m
[32m+[m[32m    public virtual DbSet<RosRoomStandards> RosRoomStandards { get; set; }[m[41m[m
[32m+[m[32m    public virtual DbSet<LocLocals> LocLocals { get; set; }[m[41m[m
[32m+[m[41m[m
 [m
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)[m
 [m
[36m@@ -45,6 +48,16 @@[m [mpublic partial class S4hHotelonlineContext : DbContext[m
             entity.Property(e => e.Shortcut).HasMaxLength(20);[m
         });[m
 [m
[32m+[m[32m        modelBuilder.Entity<LocLocals>(entity =>[m[41m[m
[32m+[m[32m        {[m[41m[m
[32m+[m[32m            entity.ToTable("LOC_Locals");[m[41m[m
[32m+[m[32m        });[m[41m[m
[32m+[m[41m[m
[32m+[m[32m        modelBuilder.Entity<RosRoomStandards>(entity =>[m[41m[m
[32m+[m[32m        {[m[41m[m
[32m+[m[32m            entity.ToTable("ROS_RoomsStandards");[m[41m[m
[32m+[m[32m        });[m[41m[m
[32m+[m[41m[m
         OnModelCreatingPartial(modelBuilder);[m
     }[m
 [m
[1mdiff --git a/Views/Home/Index.cshtml b/Views/Home/Index.cshtml[m
[1mindex 5def518..bc035e8 100644[m
[1m--- a/Views/Home/Index.cshtml[m
[1m+++ b/Views/Home/Index.cshtml[m
[36m@@ -1,6 +1,4 @@[m
[31m-﻿@model s4h.Models.RomRoom[m
[31m-[m
[31m-@{[m
[32m+[m[32m﻿@{[m[41m[m
     ViewData["Title"] = "S4H";[m
     Layout = "_DevExtremeLayout";[m
 }[m
[36m@@ -14,33 +12,90 @@[m
         .KeyExpr("ID")[m
         .DisplayExpr("Text")[m
         .ExpandedExpr("Expanded")[m
[31m-        .Width(300)[m
         )[m
 </div>[m
 [m
[32m+[m[41m[m
 <div class="right-content">[m
[31m-    @(Html.DevExtreme().DataGrid()[m
[31m-        .ID("gridContainer")[m
[31m-        .ShowBorders(true)[m
[31m-        .DataSource(d => d.Mvc().LoadAction("GetRooms"))[m
[31m-        .DataSourceOptions(o => o.Paginate(true).PageSize(20))[m
[31m-        .RemoteOperations(true)[m
[31m-        .KeyExpr("ID")[m
[31m-        .Columns(c =>[m
[31m-        {[m
[31m-            c.Add().DataField("Id");[m
[31m-            c.Add().DataField("Rosid");[m
[31m-            c.Add().DataField("Phone");[m
[31m-            c.Add().DataField("OrderOnScheduler");[m
[31m-            c.Add().DataField("Name");[m
[31m-        })[m
[32m+[m[32m    @([m[41m[m
[32m+[m[32m        Html.DevExtreme().DataGrid<s4h.Models.RomRoom>()[m[41m[m
[32m+[m[32m                .ID("gridContainer")[m[41m[m
[32m+[m[32m                .ShowBorders(true)[m[41m[m
[32m+[m[32m                .DataSource(d => d.Mvc().LoadAction("GetRooms"))[m[41m[m
[32m+[m[32m                .DataSourceOptions(o => o.Paginate(true).PageSize(20))[m[41m[m
[32m+[m[32m                .RemoteOperations(true)[m[41m[m
[32m+[m[41m[m
[32m+[m[32m                .Editing(e => e.Mode(GridEditMode.Popup)[m[41m[m
[32m+[m[32m                    .AllowUpdating(true)[m[41m[m
[32m+[m[32m                    .AllowAdding(true)[m[41m[m
[32m+[m[32m                    .AllowDeleting(true)[m[41m[m
[32m+[m[32m                    .Popup(p => p[m[41m[m
[32m+[m[32m                        .Title("Informacje")[m[41m[m
[32m+[m[32m                        .ShowTitle(true)[m[41m[m
[32m+[m[32m                        .Width(700)[m[41m[m
[32m+[m[32m                        .Height(525)[m[41m[m
[32m+[m[32m                )[m[41m[m
[32m+[m[32m                .Form(f => f.Items(items =>[m[41m[m
[32m+[m[32m                    {[m[41m[m
[32m+[m[32m                        items.AddGroup()[m[41m[m
[32m+[m[32m                .ColCount(2)[m[41m[m
[32m+[m[32m                .ColSpan(2)[m[41m[m
[32m+[m[32m                .Items(groupItems =>[m[41m[m
[32m+[m[32m                {[m[41m[m
[32m+[m[32m                    groupItems.AddSimpleFor(m => m.Id).Editor(e => e.TextBox().Disabled(true));[m[41m[m
[32m+[m[41m                [m
[32m+[m[32m                    groupItems.AddSimpleFor(m => m.Rosid)[m[41m[m
[32m+[m[32m                        .Editor(e => e.SelectBox()[m[41m[m
[32m+[m[32m                        .DisplayExpr("Name")[m[41m[m
[32m+[m[32m                        .Label("Wybierz Standard")[m[41m[m
[32m+[m[32m                        .LabelMode(EditorLabelMode.Floating)[m[41m[m
[32m+[m[32m                        .DataSource(d => d.Mvc().LoadAction("GetStandards").Key("ID"))[m[41m[m
[32m+[m[32m                        .Value(1));[m[41m[m
[32m+[m[41m[m
[32m+[m[32m                    groupItems.AddSimpleFor(m => m.Locid)[m[41m[m
[32m+[m[32m                        .Editor(e => e.SelectBox()[m[41m[m
[32m+[m[32m                        .DisplayExpr("Name")[m[41m[m
[32m+[m[32m                        .Label("Wybierz lokalizacje")[m[41m[m
[32m+[m[32m                        .LabelMode(EditorLabelMode.Floating)[m[41m[m
[32m+[m[32m                        .DataSource(d => d.Mvc().LoadAction("GetLocs").Key("ID"))[m[41m[m
[32m+[m[32m                        .Value(1));[m[41m[m
[32m+[m[41m[m
[32m+[m[41m[m
[32m+[m[32m                        groupItems.AddSimpleFor(m => m.Phone).Editor(e => e.TextBox().Disabled(true));[m[41m[m
[32m+[m[32m                        groupItems.AddSimpleFor(m => m.LockNumber).Editor(e => e.TextBox().Disabled(true));[m[41m[m
[32m+[m[32m                        groupItems.AddSimpleFor(m => m.FloorNumber).Editor(e => e.TextBox().Disabled(true));[m[41m[m
[32m+[m[32m                        groupItems.AddSimpleFor(m => m.HaveBathroom).Editor(e => e.TextBox().Disabled(true));[m[41m[m
[32m+[m[32m                        groupItems.AddSimpleFor(m => m.ForPeopleWithDisabilities).Editor(e => e.TextBox().Disabled(true));[m[41m[m
[32m+[m[41m[m
[32m+[m[32m                        groupItems.AddSimpleFor(m => m.OrderOnScheduler).Editor(e => e.TextBox().Disabled(true));[m[41m[m
[32m+[m[32m                        groupItems.AddSimpleFor(m => m.Color).Editor(e => e.TextBox().Disabled(true));[m[41m[m
[32m+[m[32m                        groupItems.AddSimpleFor(m => m.IsLocked).Editor(e => e.TextBox().Disabled(true));[m[41m[m
[32m+[m[32m                        groupItems.AddSimpleFor(m => m.RowVersion).Editor(e => e.TextBox().Disabled(true));[m[41m[m
[32m+[m[32m                        groupItems.AddSimpleFor(m => m.Number).Editor(e => e.TextBox().Disabled(true));[m[41m[m
[32m+[m[32m                        groupItems.AddSimpleFor(m => m.Name).Editor(e => e.TextBox().Disabled(true));[m[41m[m
[32m+[m[32m                        groupItems.AddSimpleFor(m => m.Shortcut).Editor(e => e.TextBox().Disabled(true));[m[41m[m
[32m+[m[32m                        groupItems.AddSimpleFor(m => m.Description).Editor(e => e.TextBox().Disabled(true));[m[41m[m
[32m+[m[41m                     [m
[32m+[m[32m                        groupItems.AddSimpleFor(m => m.DetailDescription).Editor(e => e.TextBox().Disabled(true)); });[m[41m[m
[32m+[m[32m                }))[m[41m[m
[32m+[m[41m[m
[32m+[m[32m            )[m[41m[m
[32m+[m[32m            .Columns(columns =>[m[41m[m
[32m+[m[32m            {[m[41m[m
[32m+[m[32m                columns.AddFor(m => m.Id);[m[41m[m
[32m+[m[32m                columns.AddFor(m => m.Rosid);[m[41m[m
[32m+[m[32m                columns.AddFor(m => m.Name);[m[41m[m
[32m+[m[32m                columns.AddFor(m => m.Description);[m[41m[m
[32m+[m[32m                columns.AddFor(m => m.LockNumber).Visible(false);[m[41m[m
[32m+[m[32m            })[m[41m[m
         )[m
 </div>[m
 [m
[32m+[m[41m[m
 <script>[m
     function mapData(item) {[m
         if (item.Image) {[m
[31m-            item.icon = item.Image;[m
[32m+[m[32m            item.icon = item.Image[m[41m         [m
         }[m
         return item;[m
     }[m
[1mdiff --git a/bin/Debug/net8.0/s4h.dll b/bin/Debug/net8.0/s4h.dll[m
[1mindex 91e9a3d..8b2ca61 100644[m
Binary files a/bin/Debug/net8.0/s4h.dll and b/bin/Debug/net8.0/s4h.dll differ
[1mdiff --git a/bin/Debug/net8.0/s4h.exe b/bin/Debug/net8.0/s4h.exe[m
[1mindex ba075f8..f4fa4ee 100644[m
Binary files a/bin/Debug/net8.0/s4h.exe and b/bin/Debug/net8.0/s4h.exe differ
[1mdiff --git a/bin/Debug/net8.0/s4h.pdb b/bin/Debug/net8.0/s4h.pdb[m
[1mindex e753b78..800e7d0 100644[m
Binary files a/bin/Debug/net8.0/s4h.pdb and b/bin/Debug/net8.0/s4h.pdb differ
[1mdiff --git a/obj/Debug/net8.0/apphost.exe b/obj/Debug/net8.0/apphost.exe[m
[1mindex ba075f8..f4fa4ee 100644[m
Binary files a/obj/Debug/net8.0/apphost.exe and b/obj/Debug/net8.0/apphost.exe differ
[1mdiff --git a/obj/Debug/net8.0/ref/s4h.dll b/obj/Debug/net8.0/ref/s4h.dll[m
[1mindex 3c830cc..aa79287 100644[m
Binary files a/obj/Debug/net8.0/ref/s4h.dll and b/obj/Debug/net8.0/ref/s4h.dll differ
[1mdiff --git a/obj/Debug/net8.0/refint/s4h.dll b/obj/Debug/net8.0/refint/s4h.dll[m
[1mindex 3c830cc..aa79287 100644[m
Binary files a/obj/Debug/net8.0/refint/s4h.dll and b/obj/Debug/net8.0/refint/s4h.dll differ
[1mdiff --git a/obj/Debug/net8.0/s4h.AssemblyInfo.cs b/obj/Debug/net8.0/s4h.AssemblyInfo.cs[m
[1mindex 8a12ded..7538b35 100644[m
[1m--- a/obj/Debug/net8.0/s4h.AssemblyInfo.cs[m
[1m+++ b/obj/Debug/net8.0/s4h.AssemblyInfo.cs[m
[36m@@ -14,7 +14,7 @@[m [musing System.Reflection;[m
 [assembly: System.Reflection.AssemblyCompanyAttribute("s4h")][m
 [assembly: System.Reflection.AssemblyConfigurationAttribute("Debug")][m
 [assembly: System.Reflection.AssemblyFileVersionAttribute("1.0.0.0")][m
[31m-[assembly: System.Reflection.AssemblyInformationalVersionAttribute("1.0.0+501fae75d46eb645dfc7b57d01d61b8962a0b6d2")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyInformationalVersionAttribute("1.0.0+eef6d8a6366c68bd53244f4e6e1242282579ecf6")][m[41m[m
 [assembly: System.Reflection.AssemblyProductAttribute("s4h")][m
 [assembly: System.Reflection.AssemblyTitleAttribute("s4h")][m
 [assembly: System.Reflection.AssemblyVersionAttribute("1.0.0.0")][m
[1mdiff --git a/obj/Debug/net8.0/s4h.AssemblyInfoInputs.cache b/obj/Debug/net8.0/s4h.AssemblyInfoInputs.cache[m
[1mindex aebfc75..93202c2 100644[m
[1m--- a/obj/Debug/net8.0/s4h.AssemblyInfoInputs.cache[m
[1m+++ b/obj/Debug/net8.0/s4h.AssemblyInfoInputs.cache[m
[36m@@ -1 +1 @@[m
[31m-703f6ddb89a7440b2c6d52c69f3161d734749b16ca9d4ae26e498f1d24fa7473[m
[32m+[m[32me22f87da68b93845042a10abf8790ba59744874c1b246076971cbcc3fc140bf8[m[41m[m
[1mdiff --git a/obj/Debug/net8.0/s4h.csproj.CoreCompileInputs.cache b/obj/Debug/net8.0/s4h.csproj.CoreCompileInputs.cache[m
[1mindex b35548a..83420fa 100644[m
[1m--- a/obj/Debug/net8.0/s4h.csproj.CoreCompileInputs.cache[m
[1m+++ b/obj/Debug/net8.0/s4h.csproj.CoreCompileInputs.cache[m
[36m@@ -1 +1 @@[m
[31m-93205cebdab6259431cdfa732347bbde54ab6efd5ce5eb4d6f1b2398b54f3625[m
[32m+[m[32m59d017d03b667fcca4bab06f834e892c3c054ab3696e0e12a4a85f36ce8d2b77[m[41m[m
[1mdiff --git a/obj/Debug/net8.0/s4h.dll b/obj/Debug/net8.0/s4h.dll[m
[1mindex 91e9a3d..8b2ca61 100644[m
Binary files a/obj/Debug/net8.0/s4h.dll and b/obj/Debug/net8.0/s4h.dll differ
[1mdiff --git a/obj/Debug/net8.0/s4h.pdb b/obj/Debug/net8.0/s4h.pdb[m
[1mindex e753b78..800e7d0 100644[m
Binary files a/obj/Debug/net8.0/s4h.pdb and b/obj/Debug/net8.0/s4h.pdb differ
[1mdiff --git a/obj/Debug/net8.0/s4h.sourcelink.json b/obj/Debug/net8.0/s4h.sourcelink.json[m
[1mindex ed60076..2d9c75f 100644[m
[1m--- a/obj/Debug/net8.0/s4h.sourcelink.json[m
[1m+++ b/obj/Debug/net8.0/s4h.sourcelink.json[m
[36m@@ -1 +1 @@[m
[31m-{"documents":{"C:\\Users\\ramze\\source\\repos\\s4h\\*":"https://raw.githubusercontent.com/ertryw/s4h/501fae75d46eb645dfc7b57d01d61b8962a0b6d2/*"}}[m
\ No newline at end of file[m
[32m+[m[32m{"documents":{"C:\\Users\\ramze\\source\\repos\\s4h\\*":"https://raw.githubusercontent.com/ertryw/s4h/eef6d8a6366c68bd53244f4e6e1242282579ecf6/*"}}[m
\ No newline at end of file[m
