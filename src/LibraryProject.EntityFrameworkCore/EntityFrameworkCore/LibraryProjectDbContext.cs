using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LibraryProject.Authorization.Roles;
using LibraryProject.Authorization.Users;
using LibraryProject.MultiTenancy;
using LibraryProject.Domain.Persons;
using LibraryProject.Domain.Books;
using LibraryProject.Domain.BookRequests;
using LibraryProject.Domain.MyLibraries;
using LibraryProject.Domain.SettingPreferences;
using LibraryProject.Domain.Events;
using LibraryProject.Domain.EventRegistrations;
using LibraryProject.Domain.LibraryRooms;
using LibraryProject.Domain.RoomSlots;
using LibraryProject.Domain.PenaltyFee;
using LibraryProject.Domain.RoomBookings;
using LibraryProject.Domain.BookAccounts;
<<<<<<< Updated upstream
=======
using LibraryProject.Domain.Member;
using LibraryProject.Domain.Admin;
using LibraryProject.Domain.Files;
using Abp.Domain.Repositories;
using System;
>>>>>>> Stashed changes


namespace LibraryProject.EntityFrameworkCore
{
    public class LibraryProjectDbContext : AbpZeroDbContext<Tenant, Role, User, LibraryProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Person> Persons { get; set; }
        //public DbSet<Role> Roles {  get; set; } // 
        public DbSet<Book> Books { get; set; }
        public DbSet<BookRequest> BookRequests { get; set; }
        public DbSet<MyLibrary> MyLibraries { get; set; }

        public DbSet<SettingPreference> SettingPreferences{ get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventRegistration> EventRegistrations { get; set; }
        public DbSet<LibraryRoom> LibraryRoom { get; set; }
        public DbSet<RoomSlot> RoomSlot { get; set; }
        public DbSet<PenaltyFee> PenaltyFee { get; set; }
        public DbSet<RoomBooking> RoomBooking { get; set; }
        public DbSet<BookAccount> BookAccount { get; set; }
<<<<<<< Updated upstream
=======
        public DbSet<DataFile> StoredFiles { get; set; }
        public DbSet<Person> Persons { get; set; }

>>>>>>> Stashed changes
        public LibraryProjectDbContext(DbContextOptions<LibraryProjectDbContext> options)
            : base(options)
        {
        }
    }
}
