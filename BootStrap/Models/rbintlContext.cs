using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BootStrap.Models
{
    public partial class rbintlContext : DbContext
    {
        public rbintlContext()
        {
        }

        public rbintlContext(DbContextOptions<rbintlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Option> Option { get; set; }
        public virtual DbSet<Optiongroup> Optiongroup { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Orderdetail> Orderdetail { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Productcategory> Productcategory { get; set; }
        public virtual DbSet<Productoption> Productoption { get; set; }
        public virtual DbSet<User> User { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-GPV7SE1\\SQLEXPRESS;Database=rbintl;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Option>(entity =>
            {
                entity.ToTable("option");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.OptionName)
                    .HasColumnName("option_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Optiongroup>(entity =>
            {
                entity.ToTable("optiongroup");

                entity.Property(e => e.OptionGroupId).HasColumnName("option_group_id");

                entity.Property(e => e.OptionGroupName)
                    .HasColumnName("option_group-name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.OrderAmount).HasColumnName("order_amount");

                entity.Property(e => e.OrderCountry)
                    .HasColumnName("order_country")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.OrderEmail)
                    .HasColumnName("order_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderFax)
                    .HasColumnName("order_fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderPhone)
                    .HasColumnName("order_phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderQty)
                    .HasColumnName("order_qty")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderShipAddress)
                    .HasColumnName("order_ship_address")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OrderShipAddress2)
                    .HasColumnName("order_ship_address2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderShipName)
                    .HasColumnName("order_ship_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderShipped).HasColumnName("order_shipped");

                entity.Property(e => e.OrderShipping).HasColumnName("order_shipping");

                entity.Property(e => e.OrderState)
                    .HasColumnName("order_state")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTax).HasColumnName("order_tax");

                entity.Property(e => e.OrderTrackingNumber)
                    .HasColumnName("order_tracking_number")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OrderUserId).HasColumnName("order_user_id");

                entity.Property(e => e.OrderZip)
                    .HasColumnName("order_zip")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Orderdetail>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("orderdetail");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.DetailName)
                    .HasColumnName("detail_name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("detail_order_id");

                entity.Property(e => e.DetailPrice).HasColumnName("detail_price");

                entity.Property(e => e.DetailProductId).HasColumnName("detail_product_id");

                entity.Property(e => e.DetailQty).HasColumnName("detail_qty");

                entity.Property(e => e.DetailSku)
                    .HasColumnName("detail_sku")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductCartDiscount)
                    .HasColumnName("product_cart_discount")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCategoryId).HasColumnName("product_category_id");

                entity.Property(e => e.ProductImage)
                    .HasColumnName("Product_image")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductLive)
                    .HasColumnName("product_live")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductLocation)
                    .HasColumnName("product_location")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProductLongDiscription)
                    .HasColumnName("product_long_discription")
                    .HasColumnType("text");

                entity.Property(e => e.ProductName)
                    .HasColumnName("product_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice).HasColumnName("product_price");

                entity.Property(e => e.ProductShortDiscription)
                    .HasColumnName("product_short_discription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductSku)
                    .HasColumnName("product_sku")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductStock).HasColumnName("product_stock");

                entity.Property(e => e.ProductThumb)
                    .HasColumnName("product_thumb")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductUnlimited)
                    .HasColumnName("product_unlimited")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductUpdateDate)
                    .HasColumnName("product_update_date")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ProductWeight).HasColumnName("product_weight");
            });

            modelBuilder.Entity<Productcategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("productcategory");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Productoption>(entity =>
            {
                entity.ToTable("productoption");

                entity.Property(e => e.ProductOptionId).HasColumnName("product_option_id");

                entity.Property(e => e.OptionGroupId).HasColumnName("option_group_id");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.OptionPriceIncrement)
                    .HasColumnName("option_price_increment")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserAddress)
                    .HasColumnName("user_address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserAddress2)
                    .HasColumnName("user_address2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCity)
                    .HasColumnName("user_city")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.UserCountry)
                    .HasColumnName("user_country")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .HasColumnName("user_email")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmailVerified).HasColumnName("user_email_verified");

                entity.Property(e => e.UserFax)
                    .HasColumnName("user_fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserFirstName)
                    .HasColumnName("user_first_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserIp)
                    .HasColumnName("user_ip")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserLastName)
                    .HasColumnName("user_last_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasColumnName("user_password")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhone)
                    .HasColumnName("user_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserRegisterationDate)
                    .HasColumnName("user_registeration_date")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserState)
                    .HasColumnName("user_state")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserVerificationCode)
                    .HasColumnName("user_verification_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserZip)
                    .HasColumnName("user_zip")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserRole)
                   .HasColumnName("user_role");
                   
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
