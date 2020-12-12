using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UserAnalyticsMaster.WebAPI.DataProvider
{
    public partial class dev_encrypted_generalcustomerappContext : DbContext
    {
        public dev_encrypted_generalcustomerappContext()
        {
        }

        public dev_encrypted_generalcustomerappContext(DbContextOptions<dev_encrypted_generalcustomerappContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ModelImplementSuitablityNew> ModelImplementSuitablityNew { get; set; }
        public virtual DbSet<MstAreaoffice> MstAreaoffice { get; set; }
        public virtual DbSet<MstAreaofficeLang> MstAreaofficeLang { get; set; }
        public virtual DbSet<MstBanneractionsubtype> MstBanneractionsubtype { get; set; }
        public virtual DbSet<MstBanneractiontype> MstBanneractiontype { get; set; }
        public virtual DbSet<MstBanneractiontypeLang> MstBanneractiontypeLang { get; set; }
        public virtual DbSet<MstBannercategory> MstBannercategory { get; set; }
        public virtual DbSet<MstBannercategoryLang> MstBannercategoryLang { get; set; }
        public virtual DbSet<MstBannertype> MstBannertype { get; set; }
        public virtual DbSet<MstBannertypeLang> MstBannertypeLang { get; set; }
        public virtual DbSet<MstChildmenu> MstChildmenu { get; set; }
        public virtual DbSet<MstCustprofile> MstCustprofile { get; set; }
        public virtual DbSet<MstCustprofileLang> MstCustprofileLang { get; set; }
        public virtual DbSet<MstDealerbranchhierarchy> MstDealerbranchhierarchy { get; set; }
        public virtual DbSet<MstDealerbranchhierarchyLang> MstDealerbranchhierarchyLang { get; set; }
        public virtual DbSet<MstDesignation> MstDesignation { get; set; }
        public virtual DbSet<MstDistrict> MstDistrict { get; set; }
        public virtual DbSet<MstDistrictLang> MstDistrictLang { get; set; }
        public virtual DbSet<MstDiyVideo> MstDiyVideo { get; set; }
        public virtual DbSet<MstDiyVideoCategory> MstDiyVideoCategory { get; set; }
        public virtual DbSet<MstDiyVideoCategoryLang> MstDiyVideoCategoryLang { get; set; }
        public virtual DbSet<MstDiyVideoLang> MstDiyVideoLang { get; set; }
        public virtual DbSet<MstDiyVideotypes> MstDiyVideotypes { get; set; }
        public virtual DbSet<MstEducation> MstEducation { get; set; }
        public virtual DbSet<MstEmployee> MstEmployee { get; set; }
        public virtual DbSet<MstEnqType> MstEnqType { get; set; }
        public virtual DbSet<MstEnqTypeLang> MstEnqTypeLang { get; set; }
        public virtual DbSet<MstIpdhCategory> MstIpdhCategory { get; set; }
        public virtual DbSet<MstIpdhCategoryLang> MstIpdhCategoryLang { get; set; }
        public virtual DbSet<MstIpdhModel> MstIpdhModel { get; set; }
        public virtual DbSet<MstIpdhModelBenefits> MstIpdhModelBenefits { get; set; }
        public virtual DbSet<MstIpdhModelBenefitsLang> MstIpdhModelBenefitsLang { get; set; }
        public virtual DbSet<MstIpdhModelFeatures> MstIpdhModelFeatures { get; set; }
        public virtual DbSet<MstIpdhModelFeaturesLang> MstIpdhModelFeaturesLang { get; set; }
        public virtual DbSet<MstIpdhModelLang> MstIpdhModelLang { get; set; }
        public virtual DbSet<MstIpdhModelSpecification> MstIpdhModelSpecification { get; set; }
        public virtual DbSet<MstIpdhModelSpecificationLang> MstIpdhModelSpecificationLang { get; set; }
        public virtual DbSet<MstIpdhModelgroup> MstIpdhModelgroup { get; set; }
        public virtual DbSet<MstIpdhModelgroupLang> MstIpdhModelgroupLang { get; set; }
        public virtual DbSet<MstLanguage> MstLanguage { get; set; }
        public virtual DbSet<MstMandiCropCategory> MstMandiCropCategory { get; set; }
        public virtual DbSet<MstMandiCropCategoryLang> MstMandiCropCategoryLang { get; set; }
        public virtual DbSet<MstMandiCropList> MstMandiCropList { get; set; }
        public virtual DbSet<MstMandiCropListLang> MstMandiCropListLang { get; set; }
        public virtual DbSet<MstMandiCropMapping> MstMandiCropMapping { get; set; }
        public virtual DbSet<MstMandiCropMappingLang> MstMandiCropMappingLang { get; set; }
        public virtual DbSet<MstMandiDistrictMapping> MstMandiDistrictMapping { get; set; }
        public virtual DbSet<MstMandiList> MstMandiList { get; set; }
        public virtual DbSet<MstMandiListLang> MstMandiListLang { get; set; }
        public virtual DbSet<MstMandiStateMapping> MstMandiStateMapping { get; set; }
        public virtual DbSet<MstMenu> MstMenu { get; set; }
        public virtual DbSet<MstMenutitle> MstMenutitle { get; set; }
        public virtual DbSet<MstState> MstState { get; set; }
        public virtual DbSet<MstStateLang> MstStateLang { get; set; }
        public virtual DbSet<MstSubmenu> MstSubmenu { get; set; }
        public virtual DbSet<MstTehsil> MstTehsil { get; set; }
        public virtual DbSet<MstTehsilLang> MstTehsilLang { get; set; }
        public virtual DbSet<MstTipofthedayCategory> MstTipofthedayCategory { get; set; }
        public virtual DbSet<MstTipofthedayCategoryLang> MstTipofthedayCategoryLang { get; set; }
        public virtual DbSet<MstTpdhBrand> MstTpdhBrand { get; set; }
        public virtual DbSet<MstTpdhBrandLang> MstTpdhBrandLang { get; set; }
        public virtual DbSet<MstTpdhDiyMapping> MstTpdhDiyMapping { get; set; }
        public virtual DbSet<MstTpdhFiletypes> MstTpdhFiletypes { get; set; }
        public virtual DbSet<MstTpdhHp> MstTpdhHp { get; set; }
        public virtual DbSet<MstTpdhHpLang> MstTpdhHpLang { get; set; }
        public virtual DbSet<MstTpdhManufacturer> MstTpdhManufacturer { get; set; }
        public virtual DbSet<MstTpdhManufacturerLang> MstTpdhManufacturerLang { get; set; }
        public virtual DbSet<MstTpdhModel> MstTpdhModel { get; set; }
        public virtual DbSet<MstTpdhModelBenefits> MstTpdhModelBenefits { get; set; }
        public virtual DbSet<MstTpdhModelBenefitsLang> MstTpdhModelBenefitsLang { get; set; }
        public virtual DbSet<MstTpdhModelDetails> MstTpdhModelDetails { get; set; }
        public virtual DbSet<MstTpdhModelFeatures> MstTpdhModelFeatures { get; set; }
        public virtual DbSet<MstTpdhModelFeaturesLang> MstTpdhModelFeaturesLang { get; set; }
        public virtual DbSet<MstTpdhModelLang> MstTpdhModelLang { get; set; }
        public virtual DbSet<MstTpdhModelSpecification> MstTpdhModelSpecification { get; set; }
        public virtual DbSet<MstTpdhModelSpecificationLang> MstTpdhModelSpecificationLang { get; set; }
        public virtual DbSet<MstTpdhModelgroup> MstTpdhModelgroup { get; set; }
        public virtual DbSet<MstTpdhModelgroupLang> MstTpdhModelgroupLang { get; set; }
        public virtual DbSet<MstTpdhSpecification> MstTpdhSpecification { get; set; }
        public virtual DbSet<MstTpdhSpecificationCategory> MstTpdhSpecificationCategory { get; set; }
        public virtual DbSet<MstTpdhSpecificationCategoryLang> MstTpdhSpecificationCategoryLang { get; set; }
        public virtual DbSet<MstTpdhSpecificationLang> MstTpdhSpecificationLang { get; set; }
        public virtual DbSet<MstTractorusage> MstTractorusage { get; set; }
        public virtual DbSet<MstUserAnalyticsMaster> MstUserAnalyticsMaster { get; set; }
        public virtual DbSet<MstUserAnalyticsSubMaster> MstUserAnalyticsSubMaster { get; set; }
        public virtual DbSet<MstUserrole> MstUserrole { get; set; }
        public virtual DbSet<MstVehiclType> MstVehiclType { get; set; }
        public virtual DbSet<MstVillage> MstVillage { get; set; }
        public virtual DbSet<MstVillageLang> MstVillageLang { get; set; }
        public virtual DbSet<MstVillagesalesmanrelation> MstVillagesalesmanrelation { get; set; }
        public virtual DbSet<PsCusttractorDtl> PsCusttractorDtl { get; set; }
        public virtual DbSet<PsCusttractorDtlLang> PsCusttractorDtlLang { get; set; }
        public virtual DbSet<SrFreeservicecoupon> SrFreeservicecoupon { get; set; }
        public virtual DbSet<SrJobcardHdr> SrJobcardHdr { get; set; }
        public virtual DbSet<SrMshreeEnrolcustHdr> SrMshreeEnrolcustHdr { get; set; }
        public virtual DbSet<SrMshreeRedemptionDtl> SrMshreeRedemptionDtl { get; set; }
        public virtual DbSet<TblAdminusers> TblAdminusers { get; set; }
        public virtual DbSet<TblBanners> TblBanners { get; set; }
        public virtual DbSet<TblBannersLang> TblBannersLang { get; set; }
        public virtual DbSet<TblBannersLocationMapping> TblBannersLocationMapping { get; set; }
        public virtual DbSet<TblBannersModelMapping> TblBannersModelMapping { get; set; }
        public virtual DbSet<TblCutomerCropMapping> TblCutomerCropMapping { get; set; }
        public virtual DbSet<TblCutomerMandiMapping> TblCutomerMandiMapping { get; set; }
        public virtual DbSet<TblDevicetoken> TblDevicetoken { get; set; }
        public virtual DbSet<TblDiyVideoModelmapping> TblDiyVideoModelmapping { get; set; }
        public virtual DbSet<TblEnquiry> TblEnquiry { get; set; }
        public virtual DbSet<TblEnquiryImageMapping> TblEnquiryImageMapping { get; set; }
        public virtual DbSet<TblNotificationTracker> TblNotificationTracker { get; set; }
        public virtual DbSet<TblOtptransactions> TblOtptransactions { get; set; }
        public virtual DbSet<TblTipoftheday> TblTipoftheday { get; set; }
        public virtual DbSet<TblTipofthedayLang> TblTipofthedayLang { get; set; }
        public virtual DbSet<TblTipofthedayLocationMapping> TblTipofthedayLocationMapping { get; set; }
        public virtual DbSet<TblTpdhModelImagesMapping> TblTpdhModelImagesMapping { get; set; }
        public virtual DbSet<TblTpdhModelSpecificationMapping> TblTpdhModelSpecificationMapping { get; set; }
        public virtual DbSet<TblTpdhModelSpecificationMappingLang> TblTpdhModelSpecificationMappingLang { get; set; }
        public virtual DbSet<TblTpdhSpecificationModelmappingLang> TblTpdhSpecificationModelmappingLang { get; set; }
        public virtual DbSet<TblUserAnalytics> TblUserAnalytics { get; set; }
        public virtual DbSet<TblVersionController> TblVersionController { get; set; }
        public virtual DbSet<Tdealermaster> Tdealermaster { get; set; }
        public virtual DbSet<TdealermasterLang> TdealermasterLang { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=192.168.1.101;port=3306;user=GenCusApp;password=HnS@2016;database=dev_encrypted_generalcustomerapp");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<ModelImplementSuitablityNew>(entity =>
            {
                entity.HasKey(e => e.SuitableId);

                entity.ToTable("model_implement_suitablity_new", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.IpdhModelcodeVc)
                    .HasName("IPDH_MODELCODE_VC");

                entity.HasIndex(e => e.TpdhModelcodeVc)
                    .HasName("TPDH_MODELCODE_VC");

                entity.Property(e => e.SuitableId)
                    .HasColumnName("SUITABLE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.IpdhModelcodeVc)
                    .HasColumnName("IPDH_MODELCODE_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.SectoridI)
                    .HasColumnName("SECTORID_I")
                    .HasColumnType("int(4)");

                entity.Property(e => e.TpdhModelcodeVc)
                    .HasColumnName("TPDH_MODELCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.IpdhModelcodeVcNavigation)
                    .WithMany(p => p.ModelImplementSuitablityNew)
                    .HasForeignKey(d => d.IpdhModelcodeVc)
                    .HasConstraintName("model_implement_suitablity_new_ibfk_2");

                entity.HasOne(d => d.TpdhModelcodeVcNavigation)
                    .WithMany(p => p.ModelImplementSuitablityNew)
                    .HasForeignKey(d => d.TpdhModelcodeVc)
                    .HasConstraintName("model_implement_suitablity_new_ibfk_1");
            });

            modelBuilder.Entity<MstAreaoffice>(entity =>
            {
                entity.HasKey(e => e.AocodeVc);

                entity.ToTable("mst_areaoffice", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.AocodeVc)
                    .HasColumnName("AOCode_VC")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AocityVc)
                    .HasColumnName("AOCity_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AodistrictVc)
                    .HasColumnName("AODistrict_VC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BusStateCodeI)
                    .HasColumnName("BusStateCode_I")
                    .HasColumnType("int(4)");

                entity.Property(e => e.CreatedByVc)
                    .HasColumnName("CreatedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDtD).HasColumnName("CreatedDt_D");

                entity.Property(e => e.FaxOffVc)
                    .HasColumnName("FaxOff_vc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByVc)
                    .HasColumnName("ModifiedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDtD).HasColumnName("ModifiedDt_D");

                entity.Property(e => e.PinCodeVc)
                    .HasColumnName("PinCode_vc")
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.StateCodeI)
                    .HasColumnName("StateCode_I")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.TelOffVc)
                    .HasColumnName("TelOff_vc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ZonecodeVc)
                    .HasColumnName("ZONECODE_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstAreaofficeLang>(entity =>
            {
                entity.ToTable("mst_areaoffice_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.AocodeVc)
                    .HasName("AOCode_VC");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Aoaddr1Vc)
                    .HasColumnName("AOAddr1_VC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Aoaddr2Vc)
                    .HasColumnName("AOAddr2_VC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Aoaddr3Vc)
                    .HasColumnName("AOAddr3_VC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Aoaddr4Vc)
                    .HasColumnName("AOAddr4_VC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AocodeVc)
                    .IsRequired()
                    .HasColumnName("AOCode_VC")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AonameVc)
                    .HasColumnName("AOName_VC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AostreetVc)
                    .HasColumnName("AOStreet_VC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.AocodeVcNavigation)
                    .WithMany(p => p.MstAreaofficeLang)
                    .HasForeignKey(d => d.AocodeVc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_areaoffice_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstAreaofficeLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_areaoffice_lang_ibfk_2");
            });

            modelBuilder.Entity<MstBanneractionsubtype>(entity =>
            {
                entity.ToTable("mst_banneractionsubtype", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ActionTypeId)
                    .HasName("ActionTypeID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActionSubTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActionTypeId)
                    .HasColumnName("ActionTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.HasOne(d => d.ActionType)
                    .WithMany(p => p.MstBanneractionsubtype)
                    .HasForeignKey(d => d.ActionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_banneractionsubtype_ibfk_1");
            });

            modelBuilder.Entity<MstBanneractiontype>(entity =>
            {
                entity.HasKey(e => e.ActionTypeId);

                entity.ToTable("mst_banneractiontype", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.ActionTypeId)
                    .HasColumnName("ActionTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");
            });

            modelBuilder.Entity<MstBanneractiontypeLang>(entity =>
            {
                entity.ToTable("mst_banneractiontype_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ActionTypeId)
                    .HasName("ActionTypeID");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActionTypeId)
                    .HasColumnName("ActionTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActionTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ActionType)
                    .WithMany(p => p.MstBanneractiontypeLang)
                    .HasForeignKey(d => d.ActionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_banneractiontype_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstBanneractiontypeLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_banneractiontype_lang_ibfk_2");
            });

            modelBuilder.Entity<MstBannercategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("mst_bannercategory", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");
            });

            modelBuilder.Entity<MstBannercategoryLang>(entity =>
            {
                entity.ToTable("mst_bannercategory_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("CategoryID");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MstBannercategoryLang)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_bannercategory_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstBannercategoryLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_bannercategory_lang_ibfk_2");
            });

            modelBuilder.Entity<MstBannertype>(entity =>
            {
                entity.HasKey(e => e.BannerTypeId);

                entity.ToTable("mst_bannertype", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.BannerTypeId)
                    .HasColumnName("BannerTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");
            });

            modelBuilder.Entity<MstBannertypeLang>(entity =>
            {
                entity.ToTable("mst_bannertype_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.BannerTypeId)
                    .HasName("BannerTypeID");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.BannerTypeId)
                    .HasColumnName("BannerTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BannerTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.BannerType)
                    .WithMany(p => p.MstBannertypeLang)
                    .HasForeignKey(d => d.BannerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_bannertype_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstBannertypeLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_bannertype_lang_ibfk_2");
            });

            modelBuilder.Entity<MstChildmenu>(entity =>
            {
                entity.ToTable("mst_childmenu", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ParentMenuId)
                    .HasName("ParentMenuID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasColumnType("bit(1)");

                entity.Property(e => e.ControllerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasColumnType("int(11)");

                entity.Property(e => e.ParentMenuId)
                    .HasColumnName("ParentMenuID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TargetLink).IsUnicode(false);

                entity.HasOne(d => d.ParentMenu)
                    .WithMany(p => p.MstChildmenu)
                    .HasForeignKey(d => d.ParentMenuId)
                    .HasConstraintName("mst_childmenu_ibfk_1");
            });

            modelBuilder.Entity<MstCustprofile>(entity =>
            {
                entity.HasKey(e => e.CustCodeVc);

                entity.ToTable("mst_custprofile", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.DealerBranchCodeVc)
                    .HasName("DealerBranchCode_VC");

                entity.HasIndex(e => e.DealerCodeVc)
                    .HasName("DealerCode_VC");

                entity.HasIndex(e => e.EducationId)
                    .HasName("educationID");

                entity.HasIndex(e => e.LanguagePreference)
                    .HasName("Language_Preference");

                entity.HasIndex(e => e.OfficeVillageCodeVc)
                    .HasName("OfficeVillageCode_VC");

                entity.HasIndex(e => e.Tractorusage)
                    .HasName("tractorusage");

                entity.HasIndex(e => e.VillageCodeVc)
                    .HasName("VillageCode_VC");

                entity.Property(e => e.CustCodeVc)
                    .HasColumnName("CustCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveFlagC)
                    .HasColumnName("ActiveFlag_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.AlternateMobNo).IsUnicode(false);

                entity.Property(e => e.AmcAmountN)
                    .HasColumnName("AmcAmount_N")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.AmcEndDateD).HasColumnName("AmcEndDate_D");

                entity.Property(e => e.AmcStartDateD).HasColumnName("AmcStartDate_D");

                entity.Property(e => e.AreaPrefixVc)
                    .HasColumnName("AreaPrefix_VC")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreditLimitN)
                    .HasColumnName("CreditLimit_N")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.CrmEnrichedStatus).HasColumnType("char(1)");

                entity.Property(e => e.CustAgeI)
                    .HasColumnName("CustAge_I")
                    .IsUnicode(false);

                entity.Property(e => e.CustCategoryCodeVc)
                    .HasColumnName("CustCategoryCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustCoCodeVc)
                    .HasColumnName("CustCoCode_VC")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustDobD)
                    .HasColumnName("CustDob_D")
                    .IsUnicode(false);

                entity.Property(e => e.CustTypeVc)
                    .HasColumnName("CustType_VC")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DealerBranchCodeVc)
                    .HasColumnName("DealerBranchCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DealerCodeVc)
                    .HasColumnName("DealerCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Education)
                    .HasColumnName("education")
                    .IsUnicode(false);

                entity.Property(e => e.EducationId)
                    .HasColumnName("educationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmailIdVc)
                    .HasColumnName("EmailID_VC")
                    .IsUnicode(false);

                entity.Property(e => e.EnrollDateD)
                    .HasColumnName("EnrollDate_D")
                    .IsUnicode(false);

                entity.Property(e => e.FourWheelModelVc)
                    .HasColumnName("FourWheelModel_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalCustCodeVc)
                    .HasColumnName("GlobalCustCode_VC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleteC)
                    .HasColumnName("IsDelete_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.LanguagePreference)
                    .HasColumnName("Language_Preference")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastModifiedD).HasColumnName("LastModified_D");

                entity.Property(e => e.Leasedlandsize)
                    .HasColumnName("leasedlandsize")
                    .IsUnicode(false);

                entity.Property(e => e.MenrollNoVc)
                    .HasColumnName("MEnrollNo_VC")
                    .IsUnicode(false);

                entity.Property(e => e.MobileNoVc)
                    .HasColumnName("MobileNo_VC")
                    .IsUnicode(false);

                entity.Property(e => e.MsLoyaltyPtsVc)
                    .HasColumnName("MsLoyaltyPts_VC")
                    .IsUnicode(false);

                entity.Property(e => e.MsrCategoryVc)
                    .HasColumnName("MsrCategory_VC")
                    .IsUnicode(false);

                entity.Property(e => e.OfficeVillageCodeVc)
                    .HasColumnName("OfficeVillageCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OldCustomerCodeVc)
                    .HasColumnName("OldCustomerCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OldVillageCodeVc)
                    .HasColumnName("OldVillageCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Ownedlandsize)
                    .HasColumnName("ownedlandsize")
                    .IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.PhonenoVc)
                    .HasColumnName("Phoneno_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PincodeVc)
                    .HasColumnName("Pincode_VC")
                    .IsUnicode(false);

                entity.Property(e => e.PreferredAddressVc)
                    .HasColumnName("PreferredAddress_VC")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProfilePicName)
                    .HasColumnName("Profile_PicName")
                    .IsUnicode(false);

                entity.Property(e => e.ProfilePicNameVr)
                    .HasColumnName("Profile_PicName_Vr")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PurchaseDateD)
                    .HasColumnName("PurchaseDate_D")
                    .IsUnicode(false);

                entity.Property(e => e.ReEnrollDateD)
                    .HasColumnName("ReEnrollDate_D")
                    .IsUnicode(false);

                entity.Property(e => e.SalesmanNameVc)
                    .HasColumnName("SalesmanName_VC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TractorEnabledType)
                    .HasColumnName("Tractor_Enabled_TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tractorusage)
                    .HasColumnName("tractorusage")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VillageCodeVc)
                    .HasColumnName("VillageCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.DealerBranchCodeVcNavigation)
                    .WithMany(p => p.MstCustprofile)
                    .HasForeignKey(d => d.DealerBranchCodeVc)
                    .HasConstraintName("mst_custprofile_ibfk_4");

                entity.HasOne(d => d.DealerCodeVcNavigation)
                    .WithMany(p => p.MstCustprofile)
                    .HasForeignKey(d => d.DealerCodeVc)
                    .HasConstraintName("mst_custprofile_ibfk_1");

                entity.HasOne(d => d.EducationNavigation)
                    .WithMany(p => p.MstCustprofile)
                    .HasForeignKey(d => d.EducationId)
                    .HasConstraintName("mst_custprofile_ibfk_6");

                entity.HasOne(d => d.LanguagePreferenceNavigation)
                    .WithMany(p => p.MstCustprofile)
                    .HasForeignKey(d => d.LanguagePreference)
                    .HasConstraintName("mst_custprofile_ibfk_5");

                entity.HasOne(d => d.OfficeVillageCodeVcNavigation)
                    .WithMany(p => p.MstCustprofileOfficeVillageCodeVcNavigation)
                    .HasForeignKey(d => d.OfficeVillageCodeVc)
                    .HasConstraintName("mst_custprofile_ibfk_3");

                entity.HasOne(d => d.TractorusageNavigation)
                    .WithMany(p => p.MstCustprofile)
                    .HasForeignKey(d => d.Tractorusage)
                    .HasConstraintName("mst_custprofile_ibfk_7");

                entity.HasOne(d => d.VillageCodeVcNavigation)
                    .WithMany(p => p.MstCustprofileVillageCodeVcNavigation)
                    .HasForeignKey(d => d.VillageCodeVc)
                    .HasConstraintName("mst_custprofile_ibfk_2");
            });

            modelBuilder.Entity<MstCustprofileLang>(entity =>
            {
                entity.ToTable("mst_custprofile_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.CustCodeVc)
                    .HasName("CustCode_VC");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Add1Vc)
                    .HasColumnName("Add1_VC")
                    .IsUnicode(false);

                entity.Property(e => e.Add2Vc)
                    .HasColumnName("Add2_VC")
                    .IsUnicode(false);

                entity.Property(e => e.Add3Vc)
                    .HasColumnName("Add3_VC")
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.CustCoNameVc)
                    .HasColumnName("CustCoName_VC")
                    .IsUnicode(false);

                entity.Property(e => e.CustCoPrefixVc)
                    .HasColumnName("CustCoPrefix_VC")
                    .IsUnicode(false);

                entity.Property(e => e.CustCodeVc)
                    .IsRequired()
                    .HasColumnName("CustCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustNameVc)
                    .HasColumnName("CustName_VC")
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SalesmanNameVc)
                    .HasColumnName("SalesmanName_VC")
                    .IsUnicode(false);

                entity.HasOne(d => d.CustCodeVcNavigation)
                    .WithMany(p => p.MstCustprofileLang)
                    .HasForeignKey(d => d.CustCodeVc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_custprofile_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstCustprofileLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_custprofile_lang_ibfk_2");
            });

            modelBuilder.Entity<MstDealerbranchhierarchy>(entity =>
            {
                entity.HasKey(e => e.BranchCodeVc);

                entity.ToTable("mst_dealerbranchhierarchy", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.MainDealerCodeVc)
                    .HasName("MainDealerCode_VC");

                entity.Property(e => e.BranchCodeVc)
                    .HasColumnName("BranchCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveFlagC)
                    .HasColumnName("ActiveFlag_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.AssBranchCodeVc)
                    .HasColumnName("AssBranchCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCategoryVc)
                    .HasColumnName("BranchCategory_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchSuffixVc)
                    .HasColumnName("BranchSuffix_VC")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BranchTypeVc)
                    .HasColumnName("BranchType_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByVc)
                    .HasColumnName("CreatedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDtD).HasColumnName("CreatedDt_D");

                entity.Property(e => e.EmailIdVc)
                    .HasColumnName("EmailId_VC")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FaxVc)
                    .HasColumnName("Fax_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsSalesVc)
                    .HasColumnName("isSales_VC")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsServiceVc)
                    .HasColumnName("isService_VC")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsSparesVc)
                    .HasColumnName("isSpares_VC")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsUpdated)
                    .HasColumnName("isUpdated")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MainDealerCodeVc)
                    .HasColumnName("MainDealerCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNoVc)
                    .HasColumnName("MobileNo_VC")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByVc)
                    .HasColumnName("ModifiedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDtD).HasColumnName("ModifiedDt_D");

                entity.Property(e => e.ParentCodeVc)
                    .HasColumnName("ParentCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNoVc)
                    .HasColumnName("PhoneNo_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PincodeVc)
                    .HasColumnName("Pincode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCodeVc)
                    .HasColumnName("SalesCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCodeVc)
                    .HasColumnName("ServiceCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SparesCodeVc)
                    .HasColumnName("SparesCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VillageCodeVc)
                    .HasColumnName("VillageCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.MainDealerCodeVcNavigation)
                    .WithMany(p => p.MstDealerbranchhierarchy)
                    .HasForeignKey(d => d.MainDealerCodeVc)
                    .HasConstraintName("mst_dealerbranchhierarchy_ibfk_1");
            });

            modelBuilder.Entity<MstDealerbranchhierarchyLang>(entity =>
            {
                entity.ToTable("mst_dealerbranchhierarchy_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.BranchCodeVc)
                    .HasName("BranchCode_VC");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Address1Vc)
                    .HasColumnName("Address1_VC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Address2Vc)
                    .HasColumnName("Address2_VC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Address3Vc)
                    .HasColumnName("Address3_VC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCodeVc)
                    .IsRequired()
                    .HasColumnName("BranchCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNameVc)
                    .HasColumnName("BranchName_VC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BranchlLocationVc)
                    .HasColumnName("BranchlLocation_VC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.BranchCodeVcNavigation)
                    .WithMany(p => p.MstDealerbranchhierarchyLang)
                    .HasForeignKey(d => d.BranchCodeVc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_dealerbranchhierarchy_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstDealerbranchhierarchyLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_dealerbranchhierarchy_lang_ibfk_2");
            });

            modelBuilder.Entity<MstDesignation>(entity =>
            {
                entity.HasKey(e => e.DesigcodeVc);

                entity.ToTable("mst_designation", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.DesigcodeVc)
                    .HasColumnName("DESIGCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedByVc)
                    .HasColumnName("CreatedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDtD).HasColumnName("CreatedDt_D");

                entity.Property(e => e.DesigTypeVc)
                    .HasColumnName("DesigType_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesignameVc)
                    .HasColumnName("DESIGNAME_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesigtypeC)
                    .HasColumnName("DESIGTYPE_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.IsDeleteC)
                    .HasColumnName("IsDelete_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ModifiedByVc)
                    .HasColumnName("ModifiedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDtD).HasColumnName("ModifiedDt_D");

                entity.Property(e => e.SectorIdI)
                    .HasColumnName("SectorId_I")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubmitTypeC)
                    .HasColumnName("SubmitType_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.SyncRemarkVc)
                    .HasColumnName("SyncRemark_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SyncStatusC)
                    .HasColumnName("SyncStatus_C")
                    .HasColumnType("char(1)");
            });

            modelBuilder.Entity<MstDistrict>(entity =>
            {
                entity.HasKey(e => e.DistrictCodeVc);

                entity.ToTable("mst_district", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.StateCodeI)
                    .HasName("StateCode_I");

                entity.Property(e => e.DistrictCodeVc)
                    .HasColumnName("DistrictCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.StateCodeI)
                    .HasColumnName("StateCode_I")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.StateCodeINavigation)
                    .WithMany(p => p.MstDistrict)
                    .HasForeignKey(d => d.StateCodeI)
                    .HasConstraintName("mst_district_ibfk_1");
            });

            modelBuilder.Entity<MstDistrictLang>(entity =>
            {
                entity.ToTable("mst_district_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.DistrictCodeVc)
                    .HasName("DistrictCode_VC");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.DistrictCodeVc)
                    .IsRequired()
                    .HasColumnName("DistrictCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictNameVc)
                    .HasColumnName("DistrictName_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictShortNameVc)
                    .HasColumnName("DistrictShortName_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.DistrictCodeVcNavigation)
                    .WithMany(p => p.MstDistrictLang)
                    .HasForeignKey(d => d.DistrictCodeVc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_district_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstDistrictLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_district_lang_ibfk_2");
            });

            modelBuilder.Entity<MstDiyVideo>(entity =>
            {
                entity.HasKey(e => e.DiyId);

                entity.ToTable("mst_diy_video", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.DiyCategory)
                    .HasName("DIY_Category");

                entity.Property(e => e.DiyId)
                    .HasColumnName("DIY_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.DiyCategory)
                    .HasColumnName("DIY_Category")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DiyVideoUrl)
                    .HasColumnName("DIY_VIDEO_URL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.SectoridI)
                    .HasColumnName("SECTORID_I")
                    .HasColumnType("int(4)");

                entity.HasOne(d => d.DiyCategoryNavigation)
                    .WithMany(p => p.MstDiyVideo)
                    .HasForeignKey(d => d.DiyCategory)
                    .HasConstraintName("mst_diy_video_ibfk_1");
            });

            modelBuilder.Entity<MstDiyVideoCategory>(entity =>
            {
                entity.ToTable("mst_diy_video_category", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");
            });

            modelBuilder.Entity<MstDiyVideoCategoryLang>(entity =>
            {
                entity.ToTable("mst_diy_video_category_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.DiyId)
                    .HasName("diyID");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("Category_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.DiyId)
                    .HasColumnName("diyID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Diy)
                    .WithMany(p => p.MstDiyVideoCategoryLang)
                    .HasForeignKey(d => d.DiyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_diy_video_category_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstDiyVideoCategoryLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_diy_video_category_lang_ibfk_2");
            });

            modelBuilder.Entity<MstDiyVideoLang>(entity =>
            {
                entity.ToTable("mst_diy_video_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.DiyId)
                    .HasName("DIY_ID");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.DiyDescription)
                    .HasColumnName("DIY_Description")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DiyId)
                    .HasColumnName("DIY_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DiyName)
                    .HasColumnName("DIY_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VideoPath)
                    .HasColumnName("Video_Path")
                    .IsUnicode(false);

                entity.Property(e => e.VideoTypeId).HasColumnType("int(11)");

                entity.HasOne(d => d.Diy)
                    .WithMany(p => p.MstDiyVideoLang)
                    .HasForeignKey(d => d.DiyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_diy_video_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstDiyVideoLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_diy_video_lang_ibfk_2");
            });

            modelBuilder.Entity<MstDiyVideotypes>(entity =>
            {
                entity.ToTable("mst_diy_videotypes", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.VideoType)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstEducation>(entity =>
            {
                entity.ToTable("mst_education", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.Education)
                    .HasColumnName("education")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");
            });

            modelBuilder.Entity<MstEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeNoVc);

                entity.ToTable("mst_employee", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.EmployeeNoVc)
                    .HasColumnName("EmployeeNo_VC")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("Activeflag_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.AggrTrProgramVc)
                    .HasColumnName("AggrTrProgram_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvgAnnualIncN)
                    .HasColumnName("AvgAnnualInc_N")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.BloodGroupVc)
                    .HasColumnName("BloodGroup_VC")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Caddress1Vc)
                    .HasColumnName("CAddress1_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Caddress2Vc)
                    .HasColumnName("CAddress2_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Caddress3Vc)
                    .HasColumnName("CAddress3_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CdistrictCodeVc)
                    .HasColumnName("CDistrictCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ComTrProgramVc)
                    .HasColumnName("ComTrProgram_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CphoneVc)
                    .HasColumnName("CPhone_VC")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CpinCodeVc)
                    .HasColumnName("CPinCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CplaceVc)
                    .HasColumnName("CPlace_VC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByVc)
                    .HasColumnName("CreatedBy_VC")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDtD).HasColumnName("CreatedDt_D");

                entity.Property(e => e.CriticalTsTrainingVc)
                    .HasColumnName("CriticalTsTraining_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CstateCodeVc)
                    .HasColumnName("CStateCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CtehsilCodeVc)
                    .HasColumnName("CTehsilCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirthD).HasColumnName("DateOfBirth_D");

                entity.Property(e => e.DateOfJoiningD).HasColumnName("DateOfJoining_D");

                entity.Property(e => e.DateOfResigningD).HasColumnName("DateOfResigning_D");

                entity.Property(e => e.DateOfWeddingD).HasColumnName("DateOfWedding_D");

                entity.Property(e => e.DealerBranchCodeVc)
                    .HasColumnName("DealerBranchCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DealerCodeVc)
                    .HasColumnName("DealerCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DealerLedgerRptPass)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DesigcodeC)
                    .HasColumnName("Desigcode_C")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationVc)
                    .HasColumnName("Designation_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EducationVc)
                    .HasColumnName("Education_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EmailVc)
                    .HasColumnName("Email_VC")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmpStarId)
                    .HasColumnName("EmpStarID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmpStatusC)
                    .HasColumnName("EmpStatus_C")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNameVc)
                    .HasColumnName("EmployeeName_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishLangVc)
                    .HasColumnName("EnglishLang_VC")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.FatherNameVc)
                    .HasColumnName("FatherName_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalEmpId).HasColumnType("int(11)");

                entity.Property(e => e.GppinCodeVc)
                    .HasColumnName("GPPinCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HindiLangVc)
                    .HasColumnName("HindiLang_VC")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.IdeaNextUniqueVc)
                    .HasColumnName("IdeaNextUnique_VC")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePathVc)
                    .HasColumnName("ImagePath_VC")
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.IsKyccompleted)
                    .HasColumnName("IsKYCCompleted")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ItiprogramVc)
                    .HasColumnName("ITIProgram_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MmexpN)
                    .HasColumnName("MMExp_N")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.MobileVerifyC)
                    .HasColumnName("MobileVerify_C")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByVc)
                    .HasColumnName("ModifiedBy_VC")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDtD).HasColumnName("ModifiedDt_D");

                entity.Property(e => e.ModuleC)
                    .HasColumnName("Module_C")
                    .HasColumnType("char(3)");

                entity.Property(e => e.NewProdTrProgramVc)
                    .HasColumnName("NewProdTrProgram_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfJobCardSattenQ1I)
                    .HasColumnName("NoOfJobCardSattenQ1_I")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoOfJobCardSattenQ2I)
                    .HasColumnName("NoOfJobCardSattenQ2_I")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoOfJobCardSattenQ3I)
                    .HasColumnName("NoOfJobCardSattenQ3_I")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoOfJobCardSattenQ4I)
                    .HasColumnName("NoOfJobCardSattenQ4_I")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoOfRepeatJobsQ1I)
                    .HasColumnName("NoOfRepeatJobsQ1_I")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoOfRepeatJobsQ3I)
                    .HasColumnName("NoOfRepeatJobsQ3_I")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoofRepeatJobsQ2I)
                    .HasColumnName("NoofRepeatJobsQ2_I")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoofRepeatJobsQ4I)
                    .HasColumnName("NoofRepeatJobsQ4_I")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OtherExpN)
                    .HasColumnName("OtherExp_N")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.OtherTrainingsDtlVc)
                    .HasColumnName("OtherTrainingsDtl_VC")
                    .HasMaxLength(1100)
                    .IsUnicode(false);

                entity.Property(e => e.OtherTrainingsVc)
                    .HasColumnName("OtherTrainings_VC")
                    .HasMaxLength(110)
                    .IsUnicode(false);

                entity.Property(e => e.Paddress1Vc)
                    .HasColumnName("PAddress1_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Paddress2Vc)
                    .HasColumnName("PAddress2_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Paddress3Vc)
                    .HasColumnName("PAddress3_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PdistrictCodeVc)
                    .HasColumnName("PDistrictCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceNameVc)
                    .HasColumnName("PlaceName_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PphoneVc)
                    .HasColumnName("PPhone_VC")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PplaceVc)
                    .HasColumnName("PPlace_VC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PstateCodeVc)
                    .HasColumnName("PStateCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PtehsilCodeVc)
                    .HasColumnName("PTehsilCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RegionalLangVc)
                    .HasColumnName("RegionalLang_VC")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.RevenueQ1N)
                    .HasColumnName("RevenueQ1_N")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.RevenueQ2N)
                    .HasColumnName("RevenueQ2_N")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.RevenueQ3N)
                    .HasColumnName("RevenueQ3_N")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.RevenueQ4N)
                    .HasColumnName("RevenueQ4_N")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.SalPerMnthN)
                    .HasColumnName("SalPerMnth_N")
                    .HasColumnType("decimal(9,0)");

                entity.Property(e => e.SectorIdI)
                    .HasColumnName("SectorId_I")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SexC)
                    .HasColumnName("Sex_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.SkillLevelVc)
                    .HasColumnName("SkillLevel_VC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitTypeC)
                    .HasColumnName("SubmitType_C")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.SyncRemarkVc)
                    .HasColumnName("SyncRemark_VC")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SyncStatusC)
                    .HasColumnName("SyncStatus_C")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfLocationVc)
                    .HasColumnName("TypeOfLocation_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.WorksManagerVc)
                    .HasColumnName("WorksManager_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstEnqType>(entity =>
            {
                entity.HasKey(e => e.EnqTypeId);

                entity.ToTable("mst_enq_type", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.EnqTypeId)
                    .HasColumnName("Enq_type_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");
            });

            modelBuilder.Entity<MstEnqTypeLang>(entity =>
            {
                entity.ToTable("mst_enq_type_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.EnqTypeId)
                    .HasName("Enq_type_ID");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.EnqTypeId)
                    .HasColumnName("Enq_type_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnqTypeName)
                    .HasColumnName("Enq_Type_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.EnqType)
                    .WithMany(p => p.MstEnqTypeLang)
                    .HasForeignKey(d => d.EnqTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_enq_type_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstEnqTypeLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_enq_type_lang_ibfk_2");
            });

            modelBuilder.Entity<MstIpdhCategory>(entity =>
            {
                entity.HasKey(e => e.ImplementCategoryId);

                entity.ToTable("mst_ipdh_category", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.ImplementCategoryId)
                    .HasColumnName("ImplementCategory_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");
            });

            modelBuilder.Entity<MstIpdhCategoryLang>(entity =>
            {
                entity.ToTable("mst_ipdh_category_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ImplementCategoryId)
                    .HasName("ImplementCategory_ID");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ImpCategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImplementCategoryId)
                    .HasColumnName("ImplementCategory_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ImplementCategory)
                    .WithMany(p => p.MstIpdhCategoryLang)
                    .HasForeignKey(d => d.ImplementCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_ipdh_category_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstIpdhCategoryLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_ipdh_category_lang_ibfk_2");
            });

            modelBuilder.Entity<MstIpdhModel>(entity =>
            {
                entity.HasKey(e => e.ModelcodeVc);

                entity.ToTable("mst_ipdh_model", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.IgcodeVc)
                    .HasName("IGCode_VC");

                entity.HasIndex(e => e.ImplementCategoryId)
                    .HasName("ImplementCategory_ID");

                entity.HasIndex(e => e.ManufacturercodeVc)
                    .HasName("MANUFACTURERCODE_VC");

                entity.Property(e => e.ModelcodeVc)
                    .HasColumnName("MODELCODE_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.IgcodeVc)
                    .HasColumnName("IGCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePathVc)
                    .HasColumnName("ImagePath_VC")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePathVersion)
                    .HasColumnName("ImagePath_Version")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImplementCategoryId)
                    .HasColumnName("ImplementCategory_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ManufacturercodeVc)
                    .HasColumnName("MANUFACTURERCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialTypeI)
                    .HasColumnName("MaterialType_I")
                    .HasColumnType("int(4)");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.OldmodelcodeVc)
                    .HasColumnName("OLDMODELCODE_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SectoridI)
                    .HasColumnName("SECTORID_I")
                    .HasColumnType("int(4)");

                entity.Property(e => e.SubCategoryCodeVc)
                    .HasColumnName("SubCategoryCode_VC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ThumpImage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ThumpImageVersion)
                    .HasColumnName("ThumpImage_Version")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IgcodeVcNavigation)
                    .WithMany(p => p.MstIpdhModel)
                    .HasForeignKey(d => d.IgcodeVc)
                    .HasConstraintName("mst_ipdh_model_ibfk_3");

                entity.HasOne(d => d.ImplementCategory)
                    .WithMany(p => p.MstIpdhModel)
                    .HasForeignKey(d => d.ImplementCategoryId)
                    .HasConstraintName("mst_ipdh_model_ibfk_2");

                entity.HasOne(d => d.ManufacturercodeVcNavigation)
                    .WithMany(p => p.MstIpdhModel)
                    .HasForeignKey(d => d.ManufacturercodeVc)
                    .HasConstraintName("mst_ipdh_model_ibfk_1");
            });

            modelBuilder.Entity<MstIpdhModelBenefits>(entity =>
            {
                entity.HasKey(e => e.BenefitsId);

                entity.ToTable("mst_ipdh_model_benefits", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.IpdhModelcodeVc)
                    .HasName("IPDH_MODELCODE_VC");

                entity.Property(e => e.BenefitsId)
                    .HasColumnName("BENEFITS_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.IpdhModelcodeVc)
                    .HasColumnName("IPDH_MODELCODE_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.SectoridI)
                    .HasColumnName("SECTORID_I")
                    .HasColumnType("int(4)");

                entity.HasOne(d => d.IpdhModelcodeVcNavigation)
                    .WithMany(p => p.MstIpdhModelBenefits)
                    .HasForeignKey(d => d.IpdhModelcodeVc)
                    .HasConstraintName("mst_ipdh_model_benefits_ibfk_1");
            });

            modelBuilder.Entity<MstIpdhModelBenefitsLang>(entity =>
            {
                entity.ToTable("mst_ipdh_model_benefits_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.BenefitsId)
                    .HasName("BENEFITS_ID");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.BenefitsId)
                    .HasColumnName("BENEFITS_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BenefitsName)
                    .HasColumnName("BENEFITS_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BenefitsType)
                    .HasColumnName("BENEFITS_TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.FeatureValue)
                    .HasColumnName("FEATURE_VALUE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Benefits)
                    .WithMany(p => p.MstIpdhModelBenefitsLang)
                    .HasForeignKey(d => d.BenefitsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_ipdh_model_benefits_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstIpdhModelBenefitsLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_ipdh_model_benefits_lang_ibfk_2");
            });

            modelBuilder.Entity<MstIpdhModelFeatures>(entity =>
            {
                entity.HasKey(e => e.FeatureId);

                entity.ToTable("mst_ipdh_model_features", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.IpdhModelcodeVc)
                    .HasName("IPDH_MODELCODE_VC");

                entity.Property(e => e.FeatureId)
                    .HasColumnName("FEATURE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.FeatureImageUrl)
                    .HasColumnName("FEATURE_IMAGE_URL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IpdhModelcodeVc)
                    .HasColumnName("IPDH_MODELCODE_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.SectoridI)
                    .HasColumnName("SECTORID_I")
                    .HasColumnType("int(4)");

                entity.HasOne(d => d.IpdhModelcodeVcNavigation)
                    .WithMany(p => p.MstIpdhModelFeatures)
                    .HasForeignKey(d => d.IpdhModelcodeVc)
                    .HasConstraintName("mst_ipdh_model_features_ibfk_1");
            });

            modelBuilder.Entity<MstIpdhModelFeaturesLang>(entity =>
            {
                entity.ToTable("mst_ipdh_model_features_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.FeatureId)
                    .HasName("FEATURE_ID");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.FeatureId)
                    .HasColumnName("FEATURE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FeatureName)
                    .HasColumnName("FEATURE_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FeatureType)
                    .HasColumnName("FEATURE_TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FeatureValue)
                    .HasColumnName("FEATURE_VALUE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.MstIpdhModelFeaturesLang)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_ipdh_model_features_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstIpdhModelFeaturesLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_ipdh_model_features_lang_ibfk_2");
            });

            modelBuilder.Entity<MstIpdhModelLang>(entity =>
            {
                entity.ToTable("mst_ipdh_model_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ModelcodeVc)
                    .HasName("mst_ipdh_model_lang_ibfk_1");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModelcodeVc)
                    .IsRequired()
                    .HasColumnName("MODELCODE_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModelnameVc)
                    .HasColumnName("MODELNAME_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ModelcodeVcNavigation)
                    .WithMany(p => p.MstIpdhModelLang)
                    .HasForeignKey(d => d.ModelcodeVc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_ipdh_model_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstIpdhModelLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_ipdh_model_lang_ibfk_2");
            });

            modelBuilder.Entity<MstIpdhModelSpecification>(entity =>
            {
                entity.HasKey(e => e.SpecificationId);

                entity.ToTable("mst_ipdh_model_specification", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.IpdhModelcodeVc)
                    .HasName("IPDH_MODELCODE_VC");

                entity.Property(e => e.SpecificationId)
                    .HasColumnName("SPECIFICATION_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.IpdhModelcodeVc)
                    .HasColumnName("IPDH_MODELCODE_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.SectoridI)
                    .HasColumnName("SECTORID_I")
                    .HasColumnType("int(4)");

                entity.HasOne(d => d.IpdhModelcodeVcNavigation)
                    .WithMany(p => p.MstIpdhModelSpecification)
                    .HasForeignKey(d => d.IpdhModelcodeVc)
                    .HasConstraintName("mst_ipdh_model_specification_ibfk_1");
            });

            modelBuilder.Entity<MstIpdhModelSpecificationLang>(entity =>
            {
                entity.ToTable("mst_ipdh_model_specification_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.HasIndex(e => e.SpecificationId)
                    .HasName("SPECIFICATION_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpecificationId)
                    .HasColumnName("SPECIFICATION_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpecificationName)
                    .HasColumnName("SPECIFICATION_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SpecificationType)
                    .HasColumnName("SPECIFICATION_TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpecificationValue)
                    .HasColumnName("SPECIFICATION_VALUE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstIpdhModelSpecificationLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_ipdh_model_specification_lang_ibfk_2");

                entity.HasOne(d => d.Specification)
                    .WithMany(p => p.MstIpdhModelSpecificationLang)
                    .HasForeignKey(d => d.SpecificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_ipdh_model_specification_lang_ibfk_1");
            });

            modelBuilder.Entity<MstIpdhModelgroup>(entity =>
            {
                entity.HasKey(e => e.IgcodeVc);

                entity.ToTable("mst_ipdh_modelgroup", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.IgcodeVc)
                    .HasColumnName("IGCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveFlagC)
                    .HasColumnName("ActiveFlag_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedByVc)
                    .HasColumnName("CreatedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDtD).HasColumnName("CreatedDt_D");

                entity.Property(e => e.ModelImgVc)
                    .HasColumnName("ModelImg_VC")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByVc)
                    .HasColumnName("ModifiedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDtD).HasColumnName("ModifiedDt_D");

                entity.Property(e => e.SectorIdI)
                    .HasColumnName("SectorId_I")
                    .HasColumnType("int(4)");
            });

            modelBuilder.Entity<MstIpdhModelgroupLang>(entity =>
            {
                entity.ToTable("mst_ipdh_modelgroup_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.IgcodeVc)
                    .HasName("IGCode_VC");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.IgcodeVc)
                    .IsRequired()
                    .HasColumnName("IGCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IgnameVc)
                    .HasColumnName("IGName_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShortNameVc)
                    .HasColumnName("ShortName_VC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IgcodeVcNavigation)
                    .WithMany(p => p.MstIpdhModelgroupLang)
                    .HasForeignKey(d => d.IgcodeVc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_ipdh_modelgroup_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstIpdhModelgroupLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_ipdh_modelgroup_lang_ibfk_2");
            });

            modelBuilder.Entity<MstLanguage>(entity =>
            {
                entity.ToTable("mst_language", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.LanguageCode)
                    .HasName("LANGUAGE_CODE_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasColumnName("LANGUAGE_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasColumnName("Language_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc).HasColumnName("MODIFIEDBY_VC");

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.TranslateName)
                    .IsRequired()
                    .HasColumnName("Translate_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstMandiCropCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("mst_mandi_crop_category", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");
            });

            modelBuilder.Entity<MstMandiCropCategoryLang>(entity =>
            {
                entity.ToTable("mst_mandi_crop_category_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("CategoryID");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("Category_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MstMandiCropCategoryLang)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_mandi_crop_category_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstMandiCropCategoryLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_mandi_crop_category_lang_ibfk_2");
            });

            modelBuilder.Entity<MstMandiCropList>(entity =>
            {
                entity.HasKey(e => e.CropId);

                entity.ToTable("mst_mandi_crop_list", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("CategoryID");

                entity.Property(e => e.CropId)
                    .HasColumnName("CropID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.CropCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrlVr)
                    .HasColumnName("ImageURL_vr")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MstMandiCropList)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("mst_mandi_crop_list_ibfk_1");
            });

            modelBuilder.Entity<MstMandiCropListLang>(entity =>
            {
                entity.ToTable("mst_mandi_crop_list_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.CropId)
                    .HasName("CropID");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.CropId)
                    .HasColumnName("CropID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CropName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Crop)
                    .WithMany(p => p.MstMandiCropListLang)
                    .HasForeignKey(d => d.CropId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_mandi_crop_list_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstMandiCropListLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_mandi_crop_list_lang_ibfk_2");
            });

            modelBuilder.Entity<MstMandiCropMapping>(entity =>
            {
                entity.ToTable("mst_mandi_crop_mapping", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.MandiId)
                    .HasName("mst_mandi_crop_mapping_ibfk_1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ArrivalDate).HasColumnName("Arrival_Date");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.CropId)
                    .HasColumnName("CropID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MandiId)
                    .HasColumnName("Mandi_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaxPrice).HasColumnName("Max_Price");

                entity.Property(e => e.MinPrice).HasColumnName("Min_Price");

                entity.Property(e => e.ModalPrice).HasColumnName("Modal_Price");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.HasOne(d => d.Mandi)
                    .WithMany(p => p.MstMandiCropMapping)
                    .HasForeignKey(d => d.MandiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_mandi_crop_mapping_ibfk_1");
            });

            modelBuilder.Entity<MstMandiCropMappingLang>(entity =>
            {
                entity.ToTable("mst_mandi_crop_mapping_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.MandiId)
                    .HasName("mst_mandi_crop_mapping_lang_ibfk_1");

                entity.HasIndex(e => e.MappingId)
                    .HasName("mst_mandi_crop_mapping_lang_ibfk_2");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("mst_mandi_crop_mapping_lang_ibfk_3");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("Category_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.CropName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MandiId)
                    .HasColumnName("Mandi_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MappingId)
                    .HasColumnName("Mapping_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Mandi)
                    .WithMany(p => p.MstMandiCropMappingLang)
                    .HasForeignKey(d => d.MandiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_mandi_crop_mapping_lang_ibfk_1");

                entity.HasOne(d => d.Mapping)
                    .WithMany(p => p.MstMandiCropMappingLang)
                    .HasForeignKey(d => d.MappingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_mandi_crop_mapping_lang_ibfk_2");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstMandiCropMappingLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_mandi_crop_mapping_lang_ibfk_3");
            });

            modelBuilder.Entity<MstMandiDistrictMapping>(entity =>
            {
                entity.ToTable("mst_mandi_district_mapping", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.Id)
                    .HasName("ID");

                entity.HasIndex(e => e.MandiDistrictName)
                    .HasName("Mandi_DistrictName");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.DistrictCodeVc)
                    .HasColumnName("DistrictCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MandiDistrictName)
                    .IsRequired()
                    .HasColumnName("Mandi_DistrictName")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MstMandiList>(entity =>
            {
                entity.HasKey(e => e.MandiId);

                entity.ToTable("mst_mandi_list", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.MandiId)
                    .HasColumnName("Mandi_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.DistrictCodeVc)
                    .HasColumnName("DistrictCode_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.StateCodeI)
                    .HasColumnName("StateCode_I")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstMandiListLang>(entity =>
            {
                entity.ToTable("mst_mandi_list_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.MandiId)
                    .HasName("mst_mst_mandi_list_lang_ibfk_1");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("mst_mst_mandi_list_lang_ibfk_2");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.DistrictNameVc)
                    .HasColumnName("DistrictName_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MandiId)
                    .HasColumnName("Mandi_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MandiName)
                    .HasColumnName("Mandi_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StateNameVc)
                    .HasColumnName("StateName_VC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Mandi)
                    .WithMany(p => p.MstMandiListLang)
                    .HasForeignKey(d => d.MandiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_mst_mandi_list_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstMandiListLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_mst_mandi_list_lang_ibfk_2");
            });

            modelBuilder.Entity<MstMandiStateMapping>(entity =>
            {
                entity.ToTable("mst_mandi_state_mapping", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.Id)
                    .HasName("ID");

                entity.HasIndex(e => e.MandiStateName)
                    .HasName("Mandi_StateName");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.MandiStateName)
                    .IsRequired()
                    .HasColumnName("Mandi_StateName")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.StateCodeI)
                    .HasColumnName("StateCode_I")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstMenu>(entity =>
            {
                entity.ToTable("mst_menu", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ParentTitleId)
                    .HasName("ParentTitleID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasColumnType("bit(1)");

                entity.Property(e => e.ControllerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasColumnName("icon")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasColumnType("int(11)");

                entity.Property(e => e.ParentTitleId)
                    .HasColumnName("ParentTitleID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TargetLink)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.ParentTitle)
                    .WithMany(p => p.MstMenu)
                    .HasForeignKey(d => d.ParentTitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_menu_ibfk_1");
            });

            modelBuilder.Entity<MstMenutitle>(entity =>
            {
                entity.ToTable("mst_menutitle", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.OrderNumber)
                    .HasName("OrderNumber")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active).HasColumnType("bit(1)");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasColumnType("int(11)");
            });

            modelBuilder.Entity<MstState>(entity =>
            {
                entity.HasKey(e => e.StateCodeI);

                entity.ToTable("mst_state", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.DefaultLangId)
                    .HasName("DEFAULT_LANG_ID");

                entity.HasIndex(e => e.FallbackLangId)
                    .HasName("FALLBACK_LANG_ID");

                entity.Property(e => e.StateCodeI)
                    .HasColumnName("StateCode_I")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveFlagC)
                    .HasColumnName("ActiveFlag_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedByVc)
                    .HasColumnName("CreatedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDtD).HasColumnName("CreatedDt_D");

                entity.Property(e => e.DefaultLangId)
                    .HasColumnName("DEFAULT_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FallbackLangId)
                    .HasColumnName("FALLBACK_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsBusinessStateC)
                    .HasColumnName("IsBusinessState_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.IsUnionTerritoriC)
                    .HasColumnName("Is_UnionTerritori_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ModifiedByVc)
                    .HasColumnName("ModifiedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDtD).HasColumnName("ModifiedDt_D");

                entity.Property(e => e.StateCodeVc)
                    .HasColumnName("StateCode_VC")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneCodeVc)
                    .HasColumnName("ZoneCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.DefaultLang)
                    .WithMany(p => p.MstStateDefaultLang)
                    .HasForeignKey(d => d.DefaultLangId)
                    .HasConstraintName("mst_state_ibfk_1");

                entity.HasOne(d => d.FallbackLang)
                    .WithMany(p => p.MstStateFallbackLang)
                    .HasForeignKey(d => d.FallbackLangId)
                    .HasConstraintName("mst_state_ibfk_2");
            });

            modelBuilder.Entity<MstStateLang>(entity =>
            {
                entity.ToTable("mst_state_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.HasIndex(e => e.StateCodeI)
                    .HasName("StateCode_I");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StateCodeI)
                    .IsRequired()
                    .HasColumnName("StateCode_I")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StateNameVc)
                    .HasColumnName("StateName_VC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstStateLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_state_lang_ibfk_2");

                entity.HasOne(d => d.StateCodeINavigation)
                    .WithMany(p => p.MstStateLang)
                    .HasForeignKey(d => d.StateCodeI)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_state_lang_ibfk_1");
            });

            modelBuilder.Entity<MstSubmenu>(entity =>
            {
                entity.ToTable("mst_submenu", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ParenMenutId)
                    .HasName("ParenMenutID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasColumnType("bit(1)");

                entity.Property(e => e.ControllerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasColumnType("int(11)");

                entity.Property(e => e.ParenMenutId)
                    .HasColumnName("ParenMenutID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TargetLink)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.ParenMenut)
                    .WithMany(p => p.MstSubmenu)
                    .HasForeignKey(d => d.ParenMenutId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_submenu_ibfk_1");
            });

            modelBuilder.Entity<MstTehsil>(entity =>
            {
                entity.HasKey(e => e.TehsilCodeVc);

                entity.ToTable("mst_tehsil", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.DistrictCodeVc)
                    .HasName("DistrictCode_VC");

                entity.Property(e => e.TehsilCodeVc)
                    .HasColumnName("TehsilCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.DistrictCodeVc)
                    .HasColumnName("DistrictCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.HasOne(d => d.DistrictCodeVcNavigation)
                    .WithMany(p => p.MstTehsil)
                    .HasForeignKey(d => d.DistrictCodeVc)
                    .HasConstraintName("mst_tehsil_ibfk_1");
            });

            modelBuilder.Entity<MstTehsilLang>(entity =>
            {
                entity.ToTable("mst_tehsil_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.HasIndex(e => e.TehsilCodeVc)
                    .HasName("TehsilCode_VC");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TehsilCodeVc)
                    .IsRequired()
                    .HasColumnName("TehsilCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TehsilNameVc)
                    .HasColumnName("TehsilName_VC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TehsilShortNameVc)
                    .HasColumnName("TehsilShortName_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstTehsilLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tehsil_lang_ibfk_2");

                entity.HasOne(d => d.TehsilCodeVcNavigation)
                    .WithMany(p => p.MstTehsilLang)
                    .HasForeignKey(d => d.TehsilCodeVc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tehsil_lang_ibfk_1");
            });

            modelBuilder.Entity<MstTipofthedayCategory>(entity =>
            {
                entity.HasKey(e => e.TipCategoryId);

                entity.ToTable("mst_tipoftheday_category", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.TipCategoryId)
                    .HasColumnName("TipCategory_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");
            });

            modelBuilder.Entity<MstTipofthedayCategoryLang>(entity =>
            {
                entity.ToTable("mst_tipoftheday_category_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.HasIndex(e => e.TipCategoryId)
                    .HasName("TipCategory_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("Category_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipCategoryId)
                    .HasColumnName("TipCategory_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstTipofthedayCategoryLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tipoftheday_category_lang_ibfk_2");

                entity.HasOne(d => d.TipCategory)
                    .WithMany(p => p.MstTipofthedayCategoryLang)
                    .HasForeignKey(d => d.TipCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tipoftheday_category_lang_ibfk_1");
            });

            modelBuilder.Entity<MstTpdhBrand>(entity =>
            {
                entity.HasKey(e => e.BrandcodeVc);

                entity.ToTable("mst_tpdh_brand", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ManufacturercodeVc)
                    .HasName("MANUFACTURERCODE_VC");

                entity.Property(e => e.BrandcodeVc)
                    .HasColumnName("BRANDCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ManufacturercodeVc)
                    .HasColumnName("MANUFACTURERCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.SectoridI)
                    .HasColumnName("SECTORID_I")
                    .HasColumnType("int(4)");

                entity.Property(e => e.SeriescodeVc)
                    .HasColumnName("SERIESCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.ManufacturercodeVcNavigation)
                    .WithMany(p => p.MstTpdhBrand)
                    .HasForeignKey(d => d.ManufacturercodeVc)
                    .HasConstraintName("mst_tpdh_brand_ibfk_1");
            });

            modelBuilder.Entity<MstTpdhBrandLang>(entity =>
            {
                entity.ToTable("mst_tpdh_brand_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.BrandcodeVc)
                    .HasName("BRANDCODE_VC");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.BrandcodeVc)
                    .IsRequired()
                    .HasColumnName("BRANDCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BrandnameVc)
                    .HasColumnName("BRANDNAME_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.BrandcodeVcNavigation)
                    .WithMany(p => p.MstTpdhBrandLang)
                    .HasForeignKey(d => d.BrandcodeVc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_brand_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstTpdhBrandLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_brand_lang_ibfk_2");
            });

            modelBuilder.Entity<MstTpdhDiyMapping>(entity =>
            {
                entity.ToTable("mst_tpdh_diy_mapping", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.DiyId)
                    .HasName("mst_tpdh_diy_mapping_ibfk_1");

                entity.HasIndex(e => e.ModelcodeVc)
                    .HasName("mst_tpdh_diy_mapping_ibfk_3");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("mst_tpdh_diy_mapping_ibfk_2");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.DiyId)
                    .HasColumnName("DIY_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModelcodeVc)
                    .HasColumnName("MODELCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Diy)
                    .WithMany(p => p.MstTpdhDiyMapping)
                    .HasForeignKey(d => d.DiyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_diy_mapping_ibfk_1");

                entity.HasOne(d => d.ModelcodeVcNavigation)
                    .WithMany(p => p.MstTpdhDiyMapping)
                    .HasForeignKey(d => d.ModelcodeVc)
                    .HasConstraintName("mst_tpdh_diy_mapping_ibfk_3");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstTpdhDiyMapping)
                    .HasForeignKey(d => d.MstLangId)
                    .HasConstraintName("mst_tpdh_diy_mapping_ibfk_2");
            });

            modelBuilder.Entity<MstTpdhFiletypes>(entity =>
            {
                entity.ToTable("mst_tpdh_filetypes", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.FileType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");
            });

            modelBuilder.Entity<MstTpdhHp>(entity =>
            {
                entity.HasKey(e => e.HpcodeVc);

                entity.ToTable("mst_tpdh_hp", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.HpcodeVc)
                    .HasColumnName("HPCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.SectoridI)
                    .HasColumnName("SECTORID_I")
                    .HasColumnType("int(4)");
            });

            modelBuilder.Entity<MstTpdhHpLang>(entity =>
            {
                entity.ToTable("mst_tpdh_hp_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.HpcodeVc)
                    .HasName("HPCODE_VC");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.HpcodeVc)
                    .IsRequired()
                    .HasColumnName("HPCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HpnameVc)
                    .HasColumnName("HPNAME_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.HpcodeVcNavigation)
                    .WithMany(p => p.MstTpdhHpLang)
                    .HasForeignKey(d => d.HpcodeVc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_hp_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstTpdhHpLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_hp_lang_ibfk_2");
            });

            modelBuilder.Entity<MstTpdhManufacturer>(entity =>
            {
                entity.HasKey(e => e.MstTpdhManufacturercode);

                entity.ToTable("mst_tpdh_manufacturer", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.MstTpdhManufacturercode)
                    .HasColumnName("MST_TPDH_MANUFACTURERCODE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");
            });

            modelBuilder.Entity<MstTpdhManufacturerLang>(entity =>
            {
                entity.ToTable("mst_tpdh_manufacturer_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.HasIndex(e => e.MstTpdhManufacturercode)
                    .HasName("MST_TPDH_MANUFACTURERCODE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MstTpdhManufacturercode)
                    .IsRequired()
                    .HasColumnName("MST_TPDH_MANUFACTURERCODE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MstTpdhManufacturername)
                    .HasColumnName("MST_TPDH_MANUFACTURERNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstTpdhManufacturerLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_manufacturer_lang_ibfk_2");

                entity.HasOne(d => d.MstTpdhManufacturercodeNavigation)
                    .WithMany(p => p.MstTpdhManufacturerLang)
                    .HasForeignKey(d => d.MstTpdhManufacturercode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_manufacturer_lang_ibfk_1");
            });

            modelBuilder.Entity<MstTpdhModel>(entity =>
            {
                entity.HasKey(e => e.ModelcodeVc);

                entity.ToTable("mst_tpdh_model", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.BrandcodeVc)
                    .HasName("BRANDCODE_VC");

                entity.HasIndex(e => e.HpcodeVc)
                    .HasName("HPCODE_VC");

                entity.HasIndex(e => e.ModelgroupcodeVc)
                    .HasName("MODELGROUPCODE_VC");

                entity.Property(e => e.ModelcodeVc)
                    .HasColumnName("MODELCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.BrandcodeVc)
                    .HasColumnName("BRANDCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.HpcodeVc)
                    .HasColumnName("HPCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialTypeI)
                    .HasColumnName("MaterialType_I")
                    .HasColumnType("int(4)");

                entity.Property(e => e.ModelgroupcodeVc)
                    .HasColumnName("MODELGROUPCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.OldmodelcodeVc)
                    .HasColumnName("OLDMODELCODE_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SectoridI)
                    .HasColumnName("SECTORID_I")
                    .HasColumnType("int(4)");

                entity.HasOne(d => d.BrandcodeVcNavigation)
                    .WithMany(p => p.MstTpdhModel)
                    .HasForeignKey(d => d.BrandcodeVc)
                    .HasConstraintName("mst_tpdh_model_ibfk_3");

                entity.HasOne(d => d.HpcodeVcNavigation)
                    .WithMany(p => p.MstTpdhModel)
                    .HasForeignKey(d => d.HpcodeVc)
                    .HasConstraintName("mst_tpdh_model_ibfk_2");

                entity.HasOne(d => d.ModelgroupcodeVcNavigation)
                    .WithMany(p => p.MstTpdhModel)
                    .HasForeignKey(d => d.ModelgroupcodeVc)
                    .HasConstraintName("mst_tpdh_model_ibfk_1");
            });

            modelBuilder.Entity<MstTpdhModelBenefits>(entity =>
            {
                entity.HasKey(e => e.BenefitsId);

                entity.ToTable("mst_tpdh_model_benefits", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ModelcodeVc)
                    .HasName("MODELCODE_VC");

                entity.Property(e => e.BenefitsId)
                    .HasColumnName("BENEFITS_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModelcodeVc)
                    .HasColumnName("MODELCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.SectoridI)
                    .HasColumnName("SECTORID_I")
                    .HasColumnType("int(4)");

                entity.HasOne(d => d.ModelcodeVcNavigation)
                    .WithMany(p => p.MstTpdhModelBenefits)
                    .HasForeignKey(d => d.ModelcodeVc)
                    .HasConstraintName("mst_tpdh_model_benefits_ibfk_1");
            });

            modelBuilder.Entity<MstTpdhModelBenefitsLang>(entity =>
            {
                entity.ToTable("mst_tpdh_model_benefits_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.BenefitsId)
                    .HasName("BENEFITS_ID");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.BenefitsId)
                    .HasColumnName("BENEFITS_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BenefitsName)
                    .HasColumnName("BENEFITS_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BenefitsType)
                    .HasColumnName("BENEFITS_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BenefitsValue)
                    .HasColumnName("BENEFITS_VALUE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Benefits)
                    .WithMany(p => p.MstTpdhModelBenefitsLang)
                    .HasForeignKey(d => d.BenefitsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_model_benefits_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstTpdhModelBenefitsLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_model_benefits_lang_ibfk_2");
            });

            modelBuilder.Entity<MstTpdhModelDetails>(entity =>
            {
                entity.HasKey(e => e.DetailsId);

                entity.ToTable("mst_tpdh_model_details", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.FileTypeId)
                    .HasName("FileTypeID");

                entity.HasIndex(e => e.ModelcodeVc)
                    .HasName("MODELCODE_VC");

                entity.Property(e => e.DetailsId)
                    .HasColumnName("DETAILS_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.BrochureUrl)
                    .HasColumnName("BROCHURE_URL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.FileTypeId)
                    .HasColumnName("FileTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("IMAGE_URL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImageVersion)
                    .HasColumnName("IMAGE_VERSION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ManualUrl)
                    .HasColumnName("MANUAL_URL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModelcodeVc)
                    .HasColumnName("MODELCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SectoridI)
                    .HasColumnName("SECTORID_I")
                    .HasColumnType("int(11)");

                entity.Property(e => e._360ImageUrl)
                    .HasColumnName("360_IMAGE_URL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.FileType)
                    .WithMany(p => p.MstTpdhModelDetails)
                    .HasForeignKey(d => d.FileTypeId)
                    .HasConstraintName("mst_tpdh_model_details_ibfk_2");

                entity.HasOne(d => d.ModelcodeVcNavigation)
                    .WithMany(p => p.MstTpdhModelDetails)
                    .HasForeignKey(d => d.ModelcodeVc)
                    .HasConstraintName("mst_tpdh_model_details_ibfk_1");
            });

            modelBuilder.Entity<MstTpdhModelFeatures>(entity =>
            {
                entity.HasKey(e => e.FeatureId);

                entity.ToTable("mst_tpdh_model_features", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ModelcodeVc)
                    .HasName("MODELCODE_VC");

                entity.Property(e => e.FeatureId)
                    .HasColumnName("FEATURE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.FeatureImageUrl)
                    .HasColumnName("FEATURE_IMAGE_URL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImageVersion)
                    .HasColumnName("imageVersion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModelcodeVc)
                    .HasColumnName("MODELCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.SectoridI)
                    .HasColumnName("SECTORID_I")
                    .HasColumnType("int(4)");

                entity.HasOne(d => d.ModelcodeVcNavigation)
                    .WithMany(p => p.MstTpdhModelFeatures)
                    .HasForeignKey(d => d.ModelcodeVc)
                    .HasConstraintName("mst_tpdh_model_features_ibfk_1");
            });

            modelBuilder.Entity<MstTpdhModelFeaturesLang>(entity =>
            {
                entity.ToTable("mst_tpdh_model_features_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.FeatureId)
                    .HasName("FEATURE_ID");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.FeatureId)
                    .HasColumnName("FEATURE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FeatureName)
                    .HasColumnName("FEATURE_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FeatureType)
                    .HasColumnName("FEATURE_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FeatureValue)
                    .HasColumnName("FEATURE_VALUE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImageVersion)
                    .HasColumnName("imageVersion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.MstTpdhModelFeaturesLang)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_model_features_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstTpdhModelFeaturesLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_model_features_lang_ibfk_2");
            });

            modelBuilder.Entity<MstTpdhModelLang>(entity =>
            {
                entity.ToTable("mst_tpdh_model_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ModelcodeVc)
                    .HasName("MODELCODE_VC");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModelcodeVc)
                    .IsRequired()
                    .HasColumnName("MODELCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModelnameVc)
                    .HasColumnName("MODELNAME_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ModelcodeVcNavigation)
                    .WithMany(p => p.MstTpdhModelLang)
                    .HasForeignKey(d => d.ModelcodeVc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_model_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstTpdhModelLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_model_lang_ibfk_2");
            });

            modelBuilder.Entity<MstTpdhModelSpecification>(entity =>
            {
                entity.HasKey(e => e.SpecificationId);

                entity.ToTable("mst_tpdh_model_specification", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.SpecificationCategory)
                    .HasName("SPECIFICATION_CATEGORY");

                entity.Property(e => e.SpecificationId)
                    .HasColumnName("SPECIFICATION_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("IMAGE_URL")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.SectoridI)
                    .HasColumnName("SECTORID_I")
                    .HasColumnType("int(4)");

                entity.Property(e => e.SpecificationCategory)
                    .HasColumnName("SPECIFICATION_CATEGORY")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.SpecificationCategoryNavigation)
                    .WithMany(p => p.MstTpdhModelSpecification)
                    .HasForeignKey(d => d.SpecificationCategory)
                    .HasConstraintName("mst_tpdh_model_specification_ibfk_1");
            });

            modelBuilder.Entity<MstTpdhModelSpecificationLang>(entity =>
            {
                entity.ToTable("mst_tpdh_model_specification_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.HasIndex(e => e.SpecificationId)
                    .HasName("SPECIFICATION_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpecificationId)
                    .HasColumnName("SPECIFICATION_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpecificationName)
                    .HasColumnName("SPECIFICATION_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstTpdhModelSpecificationLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_model_specification_lang_ibfk_2");

                entity.HasOne(d => d.Specification)
                    .WithMany(p => p.MstTpdhModelSpecificationLang)
                    .HasForeignKey(d => d.SpecificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_model_specification_lang_ibfk_1");
            });

            modelBuilder.Entity<MstTpdhModelgroup>(entity =>
            {
                entity.HasKey(e => e.ModelgroupcodeVc);

                entity.ToTable("mst_tpdh_modelgroup", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.BrandcodeVc)
                    .HasName("BRANDCODE_VC");

                entity.Property(e => e.ModelgroupcodeVc)
                    .HasColumnName("MODELGROUPCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.BrandcodeVc)
                    .HasColumnName("BRANDCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.SectoridI)
                    .HasColumnName("SECTORID_I")
                    .HasColumnType("int(4)");

                entity.HasOne(d => d.BrandcodeVcNavigation)
                    .WithMany(p => p.MstTpdhModelgroup)
                    .HasForeignKey(d => d.BrandcodeVc)
                    .HasConstraintName("mst_tpdh_modelgroup_ibfk_1");
            });

            modelBuilder.Entity<MstTpdhModelgroupLang>(entity =>
            {
                entity.ToTable("mst_tpdh_modelgroup_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ModelgroupcodeVc)
                    .HasName("MODELGROUPCODE_VC");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModelgroupcodeVc)
                    .IsRequired()
                    .HasColumnName("MODELGROUPCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModelgroupnameVc)
                    .HasColumnName("MODELGROUPNAME_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ModelgroupcodeVcNavigation)
                    .WithMany(p => p.MstTpdhModelgroupLang)
                    .HasForeignKey(d => d.ModelgroupcodeVc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_modelgroup_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstTpdhModelgroupLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_modelgroup_lang_ibfk_2");
            });

            modelBuilder.Entity<MstTpdhSpecification>(entity =>
            {
                entity.HasKey(e => e.SpecificationId);

                entity.ToTable("mst_tpdh_specification", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.SpecificationId)
                    .HasColumnName("SPECIFICATION_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.SpecCategoryId)
                    .HasColumnName("SpecCategoryID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MstTpdhSpecificationCategory>(entity =>
            {
                entity.HasKey(e => e.SpecCategoryId);

                entity.ToTable("mst_tpdh_specification_category", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.SpecCategoryId)
                    .HasColumnName("SpecCategoryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");
            });

            modelBuilder.Entity<MstTpdhSpecificationCategoryLang>(entity =>
            {
                entity.ToTable("mst_tpdh_specification_category_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.HasIndex(e => e.SpecCategoryId)
                    .HasName("SpecCategoryID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpecCategoryId)
                    .HasColumnName("SpecCategoryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpecCategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstTpdhSpecificationCategoryLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_specification_category_lang_ibfk_2");

                entity.HasOne(d => d.SpecCategory)
                    .WithMany(p => p.MstTpdhSpecificationCategoryLang)
                    .HasForeignKey(d => d.SpecCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_specification_category_lang_ibfk_1");
            });

            modelBuilder.Entity<MstTpdhSpecificationLang>(entity =>
            {
                entity.ToTable("mst_tpdh_specification_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.HasIndex(e => e.SpecificationId)
                    .HasName("SPECIFICATION_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpecificationId)
                    .HasColumnName("SPECIFICATION_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpecificationName)
                    .HasColumnName("SPECIFICATION_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstTpdhSpecificationLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_specification_lang_ibfk_2");

                entity.HasOne(d => d.Specification)
                    .WithMany(p => p.MstTpdhSpecificationLang)
                    .HasForeignKey(d => d.SpecificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_tpdh_specification_lang_ibfk_1");
            });

            modelBuilder.Entity<MstTractorusage>(entity =>
            {
                entity.ToTable("mst_tractorusage", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveC)
                    .HasColumnName("Active_C")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.DealerBranchCodeVc)
                    .HasColumnName("DealerBranchCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.RefCodeVc)
                    .HasColumnName("RefCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SectorIdI)
                    .HasColumnName("SectorId_I")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShowSeqVc)
                    .HasColumnName("ShowSeq_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TractorSubUseNameVc)
                    .HasColumnName("TractorSubUseName_VC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TractorSubUseShortNameVc)
                    .HasColumnName("TractorSubUseShortName_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TractorUseCodeVc)
                    .HasColumnName("TractorUseCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Usagename)
                    .HasColumnName("usagename")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstUserAnalyticsMaster>(entity =>
            {
                entity.ToTable("mst_user_analytics_master", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstUserAnalyticsSubMaster>(entity =>
            {
                entity.ToTable("mst_user_analytics_sub_master", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ModuleId)
                    .HasName("ModuleID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubModuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.MstUserAnalyticsSubMaster)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("mst_user_analytics_sub_master_ibfk_1");
            });

            modelBuilder.Entity<MstUserrole>(entity =>
            {
                entity.ToTable("mst_userrole", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active).HasColumnType("bit(1)");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstVehiclType>(entity =>
            {
                entity.ToTable("mst_vehicl_type", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstVillage>(entity =>
            {
                entity.HasKey(e => e.VillageCodeVc);

                entity.ToTable("mst_village", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.TehsilCodeVc)
                    .HasName("TehsilCode_VC");

                entity.Property(e => e.VillageCodeVc)
                    .HasColumnName("VillageCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.BlockCodeVc)
                    .HasColumnName("BlockCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Classification1I)
                    .HasColumnName("Classification1_I")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Classification2I)
                    .HasColumnName("Classification2_I")
                    .HasColumnType("int(4)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.OldVillageCodeVc)
                    .HasColumnName("OldVillageCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PostCodeVc)
                    .HasColumnName("PostCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Rclassification1I)
                    .HasColumnName("Rclassification1_I")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Rclassification2I)
                    .HasColumnName("Rclassification2_I")
                    .HasColumnType("int(4)");

                entity.Property(e => e.SyncRemarkVc)
                    .HasColumnName("SyncRemark_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SyncStatusC)
                    .HasColumnName("SyncStatus_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.TehsilCodeVc)
                    .HasColumnName("TehsilCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.TehsilCodeVcNavigation)
                    .WithMany(p => p.MstVillage)
                    .HasForeignKey(d => d.TehsilCodeVc)
                    .HasConstraintName("mst_village_ibfk_1");
            });

            modelBuilder.Entity<MstVillageLang>(entity =>
            {
                entity.ToTable("mst_village_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.HasIndex(e => e.VillageCodeVc)
                    .HasName("VillageCode_VC");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VillageCodeVc)
                    .IsRequired()
                    .HasColumnName("VillageCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.VillageNameVc)
                    .HasColumnName("VillageName_VC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VillageShortNameVc)
                    .HasColumnName("VillageShortName_VC")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.MstVillageLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_village_lang_ibfk_2");

                entity.HasOne(d => d.VillageCodeVcNavigation)
                    .WithMany(p => p.MstVillageLang)
                    .HasForeignKey(d => d.VillageCodeVc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mst_village_lang_ibfk_1");
            });

            modelBuilder.Entity<MstVillagesalesmanrelation>(entity =>
            {
                entity.ToTable("mst_villagesalesmanrelation", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveFlagC)
                    .HasColumnName("ActiveFlag_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedByVc)
                    .HasColumnName("CreatedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDtD).HasColumnName("CreatedDt_D");

                entity.Property(e => e.DealerBranchCodeVc)
                    .HasColumnName("DealerBranchCode_VC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DealerCodeVc)
                    .HasColumnName("DealerCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocStatusCodeVc)
                    .HasColumnName("DocStatusCode_VC")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByVc)
                    .HasColumnName("ModifiedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDtD).HasColumnName("ModifiedDt_D");

                entity.Property(e => e.SalesmanNoVc)
                    .HasColumnName("SalesmanNo_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SectorIdI)
                    .HasColumnName("SectorId_I")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserIdVc)
                    .HasColumnName("UserId_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VillageNoVc)
                    .HasColumnName("VillageNo_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PsCusttractorDtl>(entity =>
            {
                entity.ToTable("ps_custtractor_dtl", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.CustCodeVc)
                    .HasName("CustCode_VC");

                entity.HasIndex(e => e.DealerBranchCodeVc)
                    .HasName("DealerBranchCode_VC");

                entity.HasIndex(e => e.DealerCodeVc)
                    .HasName("DealerCode_VC");

                entity.HasIndex(e => e.VehicleType)
                    .HasName("Vehicle_Type");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddOnDealerBranchCodeVc)
                    .HasColumnName("AddOn_DealerBranchCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AddOnDealerCodeVc)
                    .HasColumnName("AddOn_DealerCode_vc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AddWarRegAmountN)
                    .HasColumnName("AddWarRegAmount_N")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.AddWarRegDateD).HasColumnName("AddWarRegDate_D");

                entity.Property(e => e.AmcAmountN)
                    .HasColumnName("AmcAmount_N")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.AmcCodeVc)
                    .HasColumnName("AmcCode_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AmcDealerCodeVc)
                    .HasColumnName("AMC_DealerCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AmcEndDateD).HasColumnName("AmcEndDate_D");

                entity.Property(e => e.AmcRegDateD).HasColumnName("AmcRegDate_D");

                entity.Property(e => e.AmcStartDateD).HasColumnName("AmcStartDate_D");

                entity.Property(e => e.AvgHrsPaVc)
                    .HasColumnName("AvgHrsPa_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByVc)
                    .HasColumnName("CreatedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDtD).HasColumnName("CreatedDt_D");

                entity.Property(e => e.CrmEnrichedStatus).HasColumnType("char(1)");

                entity.Property(e => e.CustCodeVc)
                    .HasColumnName("CustCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustTypeVc)
                    .HasColumnName("CustType_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DealerBranchCodeVc)
                    .HasColumnName("DealerBranchCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DealerCodeVc)
                    .HasColumnName("DealerCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DigisenseId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DopD).HasColumnName("Dop_D");

                entity.Property(e => e.DosD).HasColumnName("Dos_D");

                entity.Property(e => e.IsDeleteC)
                    .HasColumnName("IsDelete_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.JobCardNoVc)
                    .HasColumnName("JobCardNo_VC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.KmReadingN)
                    .HasColumnName("KmReading_N")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.LanguagePreference)
                    .HasColumnName("languagePreference")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MasterTypeC)
                    .HasColumnName("MasterType_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ModelCodeVc)
                    .HasColumnName("ModelCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByVc)
                    .HasColumnName("ModifiedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDtD).HasColumnName("ModifiedDt_D");

                entity.Property(e => e.PrmryWarDateD).HasColumnName("PrmryWarDate_D");

                entity.Property(e => e.RegCouponVc)
                    .HasColumnName("RegCoupon_VC")
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.RegDtD).HasColumnName("RegDt_D");

                entity.Property(e => e.RegNoVc)
                    .HasColumnName("RegNo_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SectorIdI)
                    .HasColumnName("SectorId_I")
                    .HasColumnType("int(4)");

                entity.Property(e => e.SerSatLevelB)
                    .HasColumnName("SerSatLevel_B")
                    .HasColumnType("char(1)");

                entity.Property(e => e.SerialNoVc)
                    .HasColumnName("SerialNo_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ServerCustCodeVc)
                    .HasColumnName("ServerCustCode_VC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SmscustStatusC)
                    .HasColumnName("SMSCustStatus_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.SmsdealerStatusC)
                    .HasColumnName("SMSDealerStatus_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.SprSatLevelB)
                    .HasColumnName("SprSatLevel_B")
                    .HasColumnType("char(1)");

                entity.Property(e => e.SrlNoN)
                    .HasColumnName("SrlNo_N")
                    .HasColumnType("int(4)");

                entity.Property(e => e.SubmitTypeC)
                    .HasColumnName("SubmitType_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.TraSatLevelB)
                    .HasColumnName("TraSatLevel_B")
                    .HasColumnType("char(1)");

                entity.Property(e => e.TrackDissatVc)
                    .HasColumnName("TrackDissat_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleType)
                    .HasColumnName("Vehicle_Type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WarrExpiryDateD).HasColumnName("WarrExpiryDate_D");

                entity.Property(e => e.YopVc)
                    .HasColumnName("Yop_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YosVc)
                    .HasColumnName("Yos_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CustCodeVcNavigation)
                    .WithMany(p => p.PsCusttractorDtl)
                    .HasForeignKey(d => d.CustCodeVc)
                    .HasConstraintName("ps_custtractor_dtl_ibfk_2");

                entity.HasOne(d => d.DealerBranchCodeVcNavigation)
                    .WithMany(p => p.PsCusttractorDtl)
                    .HasForeignKey(d => d.DealerBranchCodeVc)
                    .HasConstraintName("ps_custtractor_dtl_ibfk_3");

                entity.HasOne(d => d.DealerCodeVcNavigation)
                    .WithMany(p => p.PsCusttractorDtl)
                    .HasForeignKey(d => d.DealerCodeVc)
                    .HasConstraintName("ps_custtractor_dtl_ibfk_1");

                entity.HasOne(d => d.VehicleTypeNavigation)
                    .WithMany(p => p.PsCusttractorDtl)
                    .HasForeignKey(d => d.VehicleType)
                    .HasConstraintName("ps_custtractor_dtl_ibfk_4");
            });

            modelBuilder.Entity<PsCusttractorDtlLang>(entity =>
            {
                entity.ToTable("ps_custtractor_dtl_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.CustTractorDtlId)
                    .HasName("CustTractor_Dtl_ID");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.CustTractorDtlId)
                    .HasColumnName("CustTractor_Dtl_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CustomTractorName)
                    .HasColumnName("CustomTractor_Name")
                    .IsUnicode(false);

                entity.Property(e => e.FeedBackVc)
                    .HasColumnName("FeedBack_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CustTractorDtl)
                    .WithMany(p => p.PsCusttractorDtlLang)
                    .HasForeignKey(d => d.CustTractorDtlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ps_custtractor_dtl_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.PsCusttractorDtlLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ps_custtractor_dtl_lang_ibfk_2");
            });

            modelBuilder.Entity<SrFreeservicecoupon>(entity =>
            {
                entity.ToTable("sr_freeservicecoupon", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.DealerBranchCodeVc)
                    .HasName("DealerBranchCode_VC");

                entity.HasIndex(e => e.DealerCodeVc)
                    .HasName("DealerCode_VC");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.AddOnInvoiceNoVc)
                    .HasColumnName("AddOnInvoiceNo_vc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Aocode)
                    .HasColumnName("AOCode")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CouponNo).HasColumnType("int(11)");

                entity.Property(e => e.CreatedByVc)
                    .HasColumnName("CreatedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDtD).HasColumnName("CreatedDt_D");

                entity.Property(e => e.Creditno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DealerBranchCodeVc)
                    .HasColumnName("DealerBranchCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DealerCodeVc)
                    .HasColumnName("DealerCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Debitno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNotes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocStatusCode).HasColumnType("char(3)");

                entity.Property(e => e.DocType).HasColumnType("char(2)");

                entity.Property(e => e.ErrorDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorFlag).HasColumnType("char(1)");

                entity.Property(e => e.GstnoVc)
                    .HasColumnName("GSTNo_vc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HoursOperated)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InstallationLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InstalledBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsSigned)
                    .HasColumnName("isSigned")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JobCardNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFsccodeVc)
                    .HasColumnName("LocalFSCCode_VC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByVc)
                    .HasColumnName("ModifiedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDtD).HasColumnName("ModifiedDt_D");

                entity.Property(e => e.Odnno)
                    .HasColumnName("ODNNo")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Plant)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SaprefNo)
                    .HasColumnName("SAPRefNo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SapreplyNote)
                    .HasColumnName("SAPReplyNote")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SectorIdI)
                    .HasColumnName("SectorId_I")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SellingDlrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCouponNo)
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCouponNoSap)
                    .HasColumnName("ServiceCouponNoSAP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServicingDlrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitTypeC)
                    .HasColumnName("SubmitType_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.TaxinvdtDt).HasColumnName("TAXINVDT_Dt");

                entity.Property(e => e.TaxinvnoVc)
                    .HasColumnName("TAXINVNO_VC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TractorSrNo)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.XmlgenerationDate).HasColumnName("XMLGenerationDate");

                entity.HasOne(d => d.DealerBranchCodeVcNavigation)
                    .WithMany(p => p.SrFreeservicecoupon)
                    .HasForeignKey(d => d.DealerBranchCodeVc)
                    .HasConstraintName("sr_freeservicecoupon_ibfk_2");

                entity.HasOne(d => d.DealerCodeVcNavigation)
                    .WithMany(p => p.SrFreeservicecoupon)
                    .HasForeignKey(d => d.DealerCodeVc)
                    .HasConstraintName("sr_freeservicecoupon_ibfk_1");
            });

            modelBuilder.Entity<SrJobcardHdr>(entity =>
            {
                entity.ToTable("sr_jobcard_hdr", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.CustCodeVc)
                    .HasName("CustCode_VC");

                entity.HasIndex(e => e.DealerBranchCodeVc)
                    .HasName("DealerBranchCode_VC");

                entity.HasIndex(e => e.DealerCode)
                    .HasName("DealerCode");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdvComplaintNt)
                    .HasColumnName("AdvComplaint_NT")
                    .IsUnicode(false);

                entity.Property(e => e.AmcdiscVc)
                    .HasColumnName("AMCDisc_vc")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.BroughtByVc)
                    .HasColumnName("BroughtBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.CustCodeVc)
                    .HasColumnName("CustCode_VC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustComplaintNt)
                    .HasColumnName("CustComplaint_NT")
                    .IsUnicode(false);

                entity.Property(e => e.CustomerComplaintsRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DealerBranchCodeVc)
                    .HasColumnName("DealerBranchCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DealerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Estimatedcost).HasColumnType("decimal(10,2)");

                entity.Property(e => e.HoursReadingVc)
                    .HasColumnName("HoursReading_Vc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HrsatTimeofRepairs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleteC)
                    .HasColumnName("IsDelete_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.JcserviceSubTypeC)
                    .HasColumnName("JCServiceSubType_C")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JcserviceTypeC)
                    .HasColumnName("JCServiceType_C")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JcstatusC)
                    .HasColumnName("JCStatus_C")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JobCardCatTypeC)
                    .HasColumnName("JobCardCatType_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.JobCardTypeCodeC)
                    .HasColumnName("JobCardTypeCode_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Jobcardno)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Jobtype)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KmReadingN)
                    .HasColumnName("KmReading_N")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.LabAmt).HasColumnType("decimal(10,2)");

                entity.Property(e => e.LabTax).HasColumnType("decimal(10,2)");

                entity.Property(e => e.LabourAmount).HasColumnType("decimal(10,2)");

                entity.Property(e => e.MiscAmount).HasColumnType("decimal(10,2)");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MsredemptCouponNolabVc)
                    .HasColumnName("MSRedemptCouponNolab_vc")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OilAmount).HasColumnType("decimal(10,2)");

                entity.Property(e => e.OilTax).HasColumnType("decimal(10,2)");

                entity.Property(e => e.PartAmount).HasColumnType("decimal(10,2)");

                entity.Property(e => e.PartAmt).HasColumnType("decimal(10,2)");

                entity.Property(e => e.PartTax).HasColumnType("decimal(10,2)");

                entity.Property(e => e.PersonBroughtVc)
                    .HasColumnName("PersonBrought_VC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PressureFrontLeft)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PressureFrontRight)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PressureRearRight)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PressureRearleft)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PromiseddelryDateD).HasColumnName("promiseddelryDate_d");

                entity.Property(e => e.RedemptCouponDatelabD).HasColumnName("RedemptCouponDatelab_d");

                entity.Property(e => e.ServAppointNoVc)
                    .HasColumnName("ServAppointNo_vc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceEngineerVc)
                    .HasColumnName("ServiceEngineer_VC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceStartDateD).HasColumnName("ServiceStartDate_D");

                entity.Property(e => e.Serviceadvisor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Servicesubtype)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Servicetype)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubletAmount).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Technicianname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotalOilAmount).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Trsrno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CustCodeVcNavigation)
                    .WithMany(p => p.SrJobcardHdr)
                    .HasForeignKey(d => d.CustCodeVc)
                    .HasConstraintName("sr_jobcard_hdr_ibfk_2");

                entity.HasOne(d => d.DealerBranchCodeVcNavigation)
                    .WithMany(p => p.SrJobcardHdr)
                    .HasForeignKey(d => d.DealerBranchCodeVc)
                    .HasConstraintName("sr_jobcard_hdr_ibfk_3");

                entity.HasOne(d => d.DealerCodeNavigation)
                    .WithMany(p => p.SrJobcardHdr)
                    .HasForeignKey(d => d.DealerCode)
                    .HasConstraintName("sr_jobcard_hdr_ibfk_1");
            });

            modelBuilder.Entity<SrMshreeEnrolcustHdr>(entity =>
            {
                entity.ToTable("sr_mshree_enrolcust_hdr", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.Customercode)
                    .HasName("customercode");

                entity.HasIndex(e => e.DealerCode)
                    .HasName("DealerCode");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Activeflag)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByVc)
                    .HasColumnName("CreatedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDtD).HasColumnName("CreatedDt_D");

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Customername)
                    .HasColumnName("customername")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DealerBranchCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DealerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Deliverymasterno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DelvrysmsStatusC)
                    .HasColumnName("DELVRYSmsStatus_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.District)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Docstatuscode)
                    .HasColumnName("docstatuscode")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleteC)
                    .HasColumnName("IsDelete_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Loyaltypts).HasColumnType("decimal(10,0)");

                entity.Property(e => e.MembershipNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModelPurchased)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByVc)
                    .HasColumnName("ModifiedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDtD).HasColumnName("ModifiedDt_D");

                entity.Property(e => e.Mscategory)
                    .HasColumnName("MScategory")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phoneno)
                    .HasColumnName("phoneno")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PointsType).HasColumnType("char(30)");

                entity.Property(e => e.PrevTrModel)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PrevTrsrlNo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReferedByOrToCustCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNoVc)
                    .HasColumnName("ReferenceNo_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralCouponno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferredByOrTo)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ReferredByOrToMembershipNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferredByOrTophoneno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServerCustomerCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SmsStatusC)
                    .HasColumnName("SmsStatus_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Tehsil)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLoyaltypts).HasColumnType("decimal(10,0)");

                entity.Property(e => e.TrsrlNo)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpgradeSmsStatusC)
                    .HasColumnName("UpgradeSmsStatus_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Village)
                    .HasColumnName("village")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.CustomercodeNavigation)
                    .WithMany(p => p.SrMshreeEnrolcustHdr)
                    .HasForeignKey(d => d.Customercode)
                    .HasConstraintName("sr_mshree_enrolcust_hdr_ibfk_2");

                entity.HasOne(d => d.DealerCodeNavigation)
                    .WithMany(p => p.SrMshreeEnrolcustHdr)
                    .HasForeignKey(d => d.DealerCode)
                    .HasConstraintName("sr_mshree_enrolcust_hdr_ibfk_1");
            });

            modelBuilder.Entity<SrMshreeRedemptionDtl>(entity =>
            {
                entity.ToTable("sr_mshree_redemption_dtl", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.Customercode)
                    .HasName("Customercode");

                entity.HasIndex(e => e.DealerCode)
                    .HasName("DealerCode");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedByVc)
                    .HasColumnName("CreatedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDtD).HasColumnName("CreatedDt_D");

                entity.Property(e => e.Customercode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Customername)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DealerBranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DealerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Docstatuscode)
                    .HasColumnName("docstatuscode")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LocalRedemptCodeVc)
                    .HasColumnName("LocalRedemptCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Loyalpts).HasColumnType("decimal(10,0)");

                entity.Property(e => e.Membershipno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByVc)
                    .HasColumnName("ModifiedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDtD).HasColumnName("ModifiedDt_D");

                entity.Property(e => e.Productcode)
                    .HasColumnName("productcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RedCategory)
                    .HasColumnName("Red_category")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RedemptProduct)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RedemptPts).HasColumnType("decimal(10,0)");

                entity.Property(e => e.ReferenceNoVc)
                    .HasColumnName("ReferenceNo_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SmsstatusC)
                    .HasColumnName("SMSStatus_C")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitTypeC)
                    .HasColumnName("SubmitType_C")
                    .HasColumnType("char(1)");

                entity.HasOne(d => d.CustomercodeNavigation)
                    .WithMany(p => p.SrMshreeRedemptionDtl)
                    .HasForeignKey(d => d.Customercode)
                    .HasConstraintName("sr_mshree_redemption_dtl_ibfk_2");

                entity.HasOne(d => d.DealerCodeNavigation)
                    .WithMany(p => p.SrMshreeRedemptionDtl)
                    .HasForeignKey(d => d.DealerCode)
                    .HasConstraintName("sr_mshree_redemption_dtl_ibfk_1");
            });

            modelBuilder.Entity<TblAdminusers>(entity =>
            {
                entity.ToTable("tbl_adminusers", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.RoleId)
                    .HasName("RoleID");

                entity.HasIndex(e => e.Username)
                    .HasName("username")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active).HasColumnType("bit(1)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblAdminusers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("tbl_adminusers_ibfk_1");
            });

            modelBuilder.Entity<TblBanners>(entity =>
            {
                entity.HasKey(e => e.BannerId);

                entity.ToTable("tbl_banners", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ActionType)
                    .HasName("Action_Type");

                entity.HasIndex(e => e.BannerOrNotification)
                    .HasName("BannerOrNotification");

                entity.HasIndex(e => e.Category)
                    .HasName("Category");

                entity.Property(e => e.BannerId)
                    .HasColumnName("BANNER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActionSubType)
                    .HasColumnName("Action_SubType")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActionType)
                    .HasColumnName("Action_Type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActionTypeTarget)
                    .HasColumnName("ActionType_Target")
                    .IsUnicode(false);

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ApplicableProducts)
                    .HasColumnName("Applicable_Products")
                    .IsUnicode(false);

                entity.Property(e => e.ApplicableStates)
                    .HasColumnName("Applicable_States")
                    .IsUnicode(false);

                entity.Property(e => e.BannerImage)
                    .HasColumnName("Banner_Image")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BannerOrNotification).HasColumnType("int(11)");

                entity.Property(e => e.Category).HasColumnType("int(11)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.ValidFrom).HasColumnName("Valid_From");

                entity.Property(e => e.ValidTo).HasColumnName("Valid_To");

                entity.HasOne(d => d.ActionTypeNavigation)
                    .WithMany(p => p.TblBanners)
                    .HasForeignKey(d => d.ActionType)
                    .HasConstraintName("tbl_banners_ibfk_3");

                entity.HasOne(d => d.BannerOrNotificationNavigation)
                    .WithMany(p => p.TblBanners)
                    .HasForeignKey(d => d.BannerOrNotification)
                    .HasConstraintName("tbl_banners_ibfk_1");

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.TblBanners)
                    .HasForeignKey(d => d.Category)
                    .HasConstraintName("tbl_banners_ibfk_2");
            });

            modelBuilder.Entity<TblBannersLang>(entity =>
            {
                entity.ToTable("tbl_banners_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.BannerId)
                    .HasName("BANNER_ID");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.BannerId)
                    .HasColumnName("BANNER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BannerTitle)
                    .HasColumnName("BANNER_Title")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NotificationText)
                    .HasColumnName("Notification_Text")
                    .IsUnicode(false);

                entity.HasOne(d => d.Banner)
                    .WithMany(p => p.TblBannersLang)
                    .HasForeignKey(d => d.BannerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_banners_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.TblBannersLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_banners_lang_ibfk_2");
            });

            modelBuilder.Entity<TblBannersLocationMapping>(entity =>
            {
                entity.ToTable("tbl_banners_location_mapping", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.BannerId)
                    .HasName("BANNER_ID");

                entity.HasIndex(e => e.DistrictCodeVc)
                    .HasName("DistrictCode_VC");

                entity.HasIndex(e => e.StateCodeI)
                    .HasName("StateCode_I");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BannerId)
                    .HasColumnName("BANNER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DistrictCodeVc)
                    .HasColumnName("DistrictCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StateCodeI)
                    .HasColumnName("StateCode_I")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Banner)
                    .WithMany(p => p.TblBannersLocationMapping)
                    .HasForeignKey(d => d.BannerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_banners_location_mapping_ibfk_1");

                entity.HasOne(d => d.DistrictCodeVcNavigation)
                    .WithMany(p => p.TblBannersLocationMapping)
                    .HasForeignKey(d => d.DistrictCodeVc)
                    .HasConstraintName("tbl_banners_location_mapping_ibfk_3");

                entity.HasOne(d => d.StateCodeINavigation)
                    .WithMany(p => p.TblBannersLocationMapping)
                    .HasForeignKey(d => d.StateCodeI)
                    .HasConstraintName("tbl_banners_location_mapping_ibfk_2");
            });

            modelBuilder.Entity<TblBannersModelMapping>(entity =>
            {
                entity.ToTable("tbl_banners_model_mapping", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.BannerId)
                    .HasName("BANNER_ID");

                entity.HasIndex(e => e.ModelcodeVc)
                    .HasName("MODELCODE_VC");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BannerId)
                    .HasColumnName("BANNER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModelcodeVc)
                    .HasColumnName("MODELCODE_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Banner)
                    .WithMany(p => p.TblBannersModelMapping)
                    .HasForeignKey(d => d.BannerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_banners_model_mapping_ibfk_1");

                entity.HasOne(d => d.ModelcodeVcNavigation)
                    .WithMany(p => p.TblBannersModelMapping)
                    .HasForeignKey(d => d.ModelcodeVc)
                    .HasConstraintName("tbl_banners_model_mapping_ibfk_2");
            });

            modelBuilder.Entity<TblCutomerCropMapping>(entity =>
            {
                entity.ToTable("tbl_cutomer_crop_mapping", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.CropId)
                    .HasName("CropID");

                entity.HasIndex(e => e.CustCodeVc)
                    .HasName("CustCode_VC");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.CropId)
                    .HasColumnName("CropID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CustCodeVc)
                    .HasColumnName("CustCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.HasOne(d => d.Crop)
                    .WithMany(p => p.TblCutomerCropMapping)
                    .HasForeignKey(d => d.CropId)
                    .HasConstraintName("tbl_cutomer_crop_mapping_ibfk_1");

                entity.HasOne(d => d.CustCodeVcNavigation)
                    .WithMany(p => p.TblCutomerCropMapping)
                    .HasForeignKey(d => d.CustCodeVc)
                    .HasConstraintName("tbl_cutomer_crop_mapping_ibfk_2");
            });

            modelBuilder.Entity<TblCutomerMandiMapping>(entity =>
            {
                entity.ToTable("tbl_cutomer_mandi_mapping", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.CustCodeVc)
                    .HasName("CustCode_VC");

                entity.HasIndex(e => e.MandiId)
                    .HasName("Mandi_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.CustCodeVc)
                    .HasColumnName("CustCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MandiId)
                    .HasColumnName("Mandi_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.HasOne(d => d.CustCodeVcNavigation)
                    .WithMany(p => p.TblCutomerMandiMapping)
                    .HasForeignKey(d => d.CustCodeVc)
                    .HasConstraintName("tbl_cutomer_mandi_mapping_ibfk_2");

                entity.HasOne(d => d.Mandi)
                    .WithMany(p => p.TblCutomerMandiMapping)
                    .HasForeignKey(d => d.MandiId)
                    .HasConstraintName("tbl_cutomer_mandi_mapping_ibfk_1");
            });

            modelBuilder.Entity<TblDevicetoken>(entity =>
            {
                entity.ToTable("tbl_devicetoken", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.CustCodeVc)
                    .HasName("CustCode_VC");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveFlagC)
                    .HasColumnName("ActiveFlag_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.CustCodeVc)
                    .HasColumnName("CustCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasColumnName("Device_ID")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceToken)
                    .HasColumnName("Device_Token")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Os)
                    .HasColumnName("OS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Osversion)
                    .HasColumnName("OSversion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CustCodeVcNavigation)
                    .WithMany(p => p.TblDevicetoken)
                    .HasForeignKey(d => d.CustCodeVc)
                    .HasConstraintName("tbl_devicetoken_ibfk_1");
            });

            modelBuilder.Entity<TblDiyVideoModelmapping>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("tbl_diy_video_modelmapping", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.DiyId)
                    .HasName("DIY_ID");

                entity.HasIndex(e => e.ModelcodeVc)
                    .HasName("MODELCODE_VC");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.MappingId)
                    .HasColumnName("MappingID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.DiyId)
                    .HasColumnName("DIY_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModelcodeVc)
                    .HasColumnName("MODELCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SectoridI)
                    .HasColumnName("SECTORID_I")
                    .HasColumnType("int(4)");

                entity.HasOne(d => d.Diy)
                    .WithMany(p => p.TblDiyVideoModelmapping)
                    .HasForeignKey(d => d.DiyId)
                    .HasConstraintName("tbl_diy_video_modelmapping_ibfk_2");

                entity.HasOne(d => d.ModelcodeVcNavigation)
                    .WithMany(p => p.TblDiyVideoModelmapping)
                    .HasForeignKey(d => d.ModelcodeVc)
                    .HasConstraintName("tbl_diy_video_modelmapping_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.TblDiyVideoModelmapping)
                    .HasForeignKey(d => d.MstLangId)
                    .HasConstraintName("tbl_diy_video_modelmapping_ibfk_3");
            });

            modelBuilder.Entity<TblEnquiry>(entity =>
            {
                entity.HasKey(e => e.EnqId);

                entity.ToTable("tbl_enquiry", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.CustCodeVc)
                    .HasName("CustCode_VC");

                entity.HasIndex(e => e.DealerBranchCodeVc)
                    .HasName("DealerBranchCode_VC");

                entity.HasIndex(e => e.DealerCodeVc)
                    .HasName("DealerCode_VC");

                entity.HasIndex(e => e.EnqTypeId)
                    .HasName("ENQ_TYPE_ID");

                entity.HasIndex(e => e.IntrestedInIpdhModelcodeVc)
                    .HasName("tbl_enquiry_ibfk_5");

                entity.HasIndex(e => e.IntrestedInTpdhModelcodeVc)
                    .HasName("tbl_enquiry_ibfk_4");

                entity.HasIndex(e => e.IpdhModelcodeVc)
                    .HasName("IPDH_MODELCODE_VC");

                entity.HasIndex(e => e.ReferralVillageCodeVc)
                    .HasName("Referral_VillageCode_VC");

                entity.HasIndex(e => e.TpdhModelcodeVc)
                    .HasName("TPDH_MODELCODE_VC");

                entity.HasIndex(e => e.VillageCodeVc)
                    .HasName("VillageCode_VC");

                entity.Property(e => e.EnqId)
                    .HasColumnName("ENQ_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.CustCodeVc)
                    .HasColumnName("CustCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DealerBranchCodeVc)
                    .HasColumnName("DealerBranchCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DealerCodeVc)
                    .HasColumnName("DealerCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EnqRemarks)
                    .HasColumnName("ENQ_REMARKS")
                    .IsUnicode(false);

                entity.Property(e => e.EnqStatus)
                    .HasColumnName("ENQ_STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EnqTicketId)
                    .HasColumnName("ENQ_TICKET_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EnqTypeId)
                    .HasColumnName("ENQ_TYPE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntrestedIn)
                    .HasColumnName("Intrested_IN")
                    .HasColumnType("int(1)");

                entity.Property(e => e.IntrestedInIpdhModelcodeVc)
                    .HasColumnName("Intrested_IN_IPDH_MODELCODE_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IntrestedInTpdhModelcodeVc)
                    .HasColumnName("Intrested_IN_TPDH_MODELCODE_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IpdhModelcodeVc)
                    .HasColumnName("IPDH_MODELCODE_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Isrcavailable)
                    .HasColumnName("ISRCAvailable")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ManufacturercodeVc)
                    .HasColumnName("MANUFACTURERCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.ProductNimplement)
                    .HasColumnName("ProductNImplement")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReferralMobileNoVc)
                    .HasColumnName("Referral_MobileNo_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralName)
                    .HasColumnName("Referral_NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralVillageCodeVc)
                    .HasColumnName("Referral_VillageCode_VC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TpdhModelcodeVc)
                    .HasColumnName("TPDH_MODELCODE_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tractorbrand)
                    .HasColumnName("tractorbrand")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VillageCodeVc)
                    .HasColumnName("VillageCode_VC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.YearOfManufacture)
                    .HasColumnName("Year_OF_MANUFACTURE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.CustCodeVcNavigation)
                    .WithMany(p => p.TblEnquiry)
                    .HasForeignKey(d => d.CustCodeVc)
                    .HasConstraintName("tbl_enquiry_ibfk_2");

                entity.HasOne(d => d.DealerBranchCodeVcNavigation)
                    .WithMany(p => p.TblEnquiry)
                    .HasForeignKey(d => d.DealerBranchCodeVc)
                    .HasConstraintName("tbl_enquiry_ibfk_8");

                entity.HasOne(d => d.DealerCodeVcNavigation)
                    .WithMany(p => p.TblEnquiry)
                    .HasForeignKey(d => d.DealerCodeVc)
                    .HasConstraintName("tbl_enquiry_ibfk_3");

                entity.HasOne(d => d.EnqType)
                    .WithMany(p => p.TblEnquiry)
                    .HasForeignKey(d => d.EnqTypeId)
                    .HasConstraintName("tbl_enquiry_ibfk_1");

                entity.HasOne(d => d.IntrestedInIpdhModelcodeVcNavigation)
                    .WithMany(p => p.TblEnquiry)
                    .HasForeignKey(d => d.IntrestedInIpdhModelcodeVc)
                    .HasConstraintName("tbl_enquiry_ibfk_5");

                entity.HasOne(d => d.IntrestedInTpdhModelcodeVcNavigation)
                    .WithMany(p => p.TblEnquiry)
                    .HasForeignKey(d => d.IntrestedInTpdhModelcodeVc)
                    .HasConstraintName("tbl_enquiry_ibfk_4");
            });

            modelBuilder.Entity<TblEnquiryImageMapping>(entity =>
            {
                entity.ToTable("tbl_enquiry_image_mapping", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.EnqId)
                    .HasName("ENQ_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.EnqId)
                    .HasColumnName("ENQ_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImagePath).IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.HasOne(d => d.Enq)
                    .WithMany(p => p.TblEnquiryImageMapping)
                    .HasForeignKey(d => d.EnqId)
                    .HasConstraintName("tbl_enquiry_image_mapping_ibfk_1");
            });

            modelBuilder.Entity<TblNotificationTracker>(entity =>
            {
                entity.ToTable("tbl_notification_tracker", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.CustCodeVc)
                    .HasName("CustCode_VC");

                entity.HasIndex(e => e.NotificationId)
                    .HasName("NotificationID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.CustCodeVc)
                    .IsRequired()
                    .HasColumnName("CustCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.NotificationId)
                    .HasColumnName("NotificationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReadStatus).HasColumnType("tinyint(1)");

                entity.HasOne(d => d.CustCodeVcNavigation)
                    .WithMany(p => p.TblNotificationTracker)
                    .HasForeignKey(d => d.CustCodeVc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_notification_tracker_ibfk_1");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.TblNotificationTracker)
                    .HasForeignKey(d => d.NotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_notification_tracker_ibfk_2");
            });

            modelBuilder.Entity<TblOtptransactions>(entity =>
            {
                entity.ToTable("tbl_otptransactions", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.CustCodeVc)
                    .HasName("CustCode_VC");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveFlagC)
                    .HasColumnName("ActiveFlag_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.CustCodeVc)
                    .HasColumnName("CustCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Otp)
                    .HasColumnName("OTP")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UsedOn).HasColumnName("used_on");

                entity.HasOne(d => d.CustCodeVcNavigation)
                    .WithMany(p => p.TblOtptransactions)
                    .HasForeignKey(d => d.CustCodeVc)
                    .HasConstraintName("tbl_otptransactions_ibfk_1");
            });

            modelBuilder.Entity<TblTipoftheday>(entity =>
            {
                entity.HasKey(e => e.TipId);

                entity.ToTable("tbl_tipoftheday", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("CategoryID");

                entity.Property(e => e.TipId)
                    .HasColumnName("TipID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.ValidFrom).HasColumnName("Valid_from");

                entity.Property(e => e.ValidThru).HasColumnName("Valid_thru");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblTipoftheday)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("tbl_tipoftheday_ibfk_1");
            });

            modelBuilder.Entity<TblTipofthedayLang>(entity =>
            {
                entity.ToTable("tbl_tipoftheday_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.HasIndex(e => e.TipId)
                    .HasName("TipID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipId)
                    .HasColumnName("TipID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipText)
                    .HasColumnName("Tip_Text")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TipTitle)
                    .HasColumnName("Tip_Title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.TblTipofthedayLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_tipoftheday_lang_ibfk_2");

                entity.HasOne(d => d.Tip)
                    .WithMany(p => p.TblTipofthedayLang)
                    .HasForeignKey(d => d.TipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_tipoftheday_lang_ibfk_1");
            });

            modelBuilder.Entity<TblTipofthedayLocationMapping>(entity =>
            {
                entity.ToTable("tbl_tipoftheday_location_mapping", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.DistrictCodeVc)
                    .HasName("DistrictCode_VC");

                entity.HasIndex(e => e.StateCodeI)
                    .HasName("StateCode_I");

                entity.HasIndex(e => e.TipId)
                    .HasName("TipID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DistrictCodeVc)
                    .HasColumnName("DistrictCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StateCodeI)
                    .HasColumnName("StateCode_I")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipId)
                    .HasColumnName("TipID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.DistrictCodeVcNavigation)
                    .WithMany(p => p.TblTipofthedayLocationMapping)
                    .HasForeignKey(d => d.DistrictCodeVc)
                    .HasConstraintName("tbl_tipoftheday_location_mapping_ibfk_3");

                entity.HasOne(d => d.StateCodeINavigation)
                    .WithMany(p => p.TblTipofthedayLocationMapping)
                    .HasForeignKey(d => d.StateCodeI)
                    .HasConstraintName("tbl_tipoftheday_location_mapping_ibfk_2");

                entity.HasOne(d => d.Tip)
                    .WithMany(p => p.TblTipofthedayLocationMapping)
                    .HasForeignKey(d => d.TipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_tipoftheday_location_mapping_ibfk_1");
            });

            modelBuilder.Entity<TblTpdhModelImagesMapping>(entity =>
            {
                entity.ToTable("tbl_tpdh_model_images_mapping", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ModelcodeVc)
                    .HasName("MODELCODE_VC");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ImagePath)
                    .HasColumnName("Image_Path")
                    .IsUnicode(false);

                entity.Property(e => e.ImageVersion)
                    .HasColumnName("Image_Version")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModelcodeVc)
                    .HasColumnName("MODELCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.HasOne(d => d.ModelcodeVcNavigation)
                    .WithMany(p => p.TblTpdhModelImagesMapping)
                    .HasForeignKey(d => d.ModelcodeVc)
                    .HasConstraintName("tbl_tpdh_model_images_mapping_ibfk_1");
            });

            modelBuilder.Entity<TblTpdhModelSpecificationMapping>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("tbl_tpdh_model_specification_mapping", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ModelcodeVc)
                    .HasName("MODELCODE_VC");

                entity.HasIndex(e => e.SpecificationId)
                    .HasName("SPECIFICATION_ID");

                entity.Property(e => e.MappingId)
                    .HasColumnName("MAPPING_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModelcodeVc)
                    .HasColumnName("MODELCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.SectoridI)
                    .HasColumnName("SECTORID_I")
                    .HasColumnType("int(4)");

                entity.Property(e => e.SpecificationId)
                    .HasColumnName("SPECIFICATION_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ModelcodeVcNavigation)
                    .WithMany(p => p.TblTpdhModelSpecificationMapping)
                    .HasForeignKey(d => d.ModelcodeVc)
                    .HasConstraintName("tbl_tpdh_model_specification_mapping_ibfk_2");

                entity.HasOne(d => d.Specification)
                    .WithMany(p => p.TblTpdhModelSpecificationMapping)
                    .HasForeignKey(d => d.SpecificationId)
                    .HasConstraintName("tbl_tpdh_model_specification_mapping_ibfk_1");
            });

            modelBuilder.Entity<TblTpdhModelSpecificationMappingLang>(entity =>
            {
                entity.ToTable("tbl_tpdh_model_specification_mapping_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.MappingId)
                    .HasName("MAPPING_ID");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.MappingId)
                    .HasColumnName("MAPPING_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpecificationValue)
                    .HasColumnName("SPECIFICATION_VALUE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Mapping)
                    .WithMany(p => p.TblTpdhModelSpecificationMappingLang)
                    .HasForeignKey(d => d.MappingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_tpdh_model_specification_mapping_lang_ibfk_3");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.TblTpdhModelSpecificationMappingLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_tpdh_model_specification_mapping_lang_ibfk_2");
            });

            modelBuilder.Entity<TblTpdhSpecificationModelmappingLang>(entity =>
            {
                entity.ToTable("tbl_tpdh_specification_modelmapping_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.ModelcodeVc)
                    .HasName("MODELCODE_VC");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.HasIndex(e => e.SpecificationId)
                    .HasName("SPECIFICATION_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModelcodeVc)
                    .IsRequired()
                    .HasColumnName("MODELCODE_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpecificationId)
                    .HasColumnName("SPECIFICATION_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpecificationValue)
                    .HasColumnName("SPECIFICATION_VALUE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModelcodeVcNavigation)
                    .WithMany(p => p.TblTpdhSpecificationModelmappingLang)
                    .HasForeignKey(d => d.ModelcodeVc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_tpdh_specification_modelmapping_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.TblTpdhSpecificationModelmappingLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_tpdh_specification_modelmapping_lang_ibfk_3");

                entity.HasOne(d => d.Specification)
                    .WithMany(p => p.TblTpdhSpecificationModelmappingLang)
                    .HasForeignKey(d => d.SpecificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_tpdh_specification_modelmapping_lang_ibfk_2");
            });

            modelBuilder.Entity<TblUserAnalytics>(entity =>
            {
                entity.ToTable("tbl_user_analytics", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.CustomerCodeVc)
                    .HasColumnName("CustomerCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasColumnName("DeviceID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Duration).HasColumnType("int(11)");

                entity.Property(e => e.ModelCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Osversion)
                    .HasColumnName("OSVersion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubModuleId)
                    .HasColumnName("SubModuleID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TblVersionController>(entity =>
            {
                entity.ToTable("tbl_version_controller", "dev_encrypted_generalcustomerapp");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.ModuleName)
                    .HasColumnName("Module_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Version).HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Tdealermaster>(entity =>
            {
                entity.HasKey(e => e.DealerCode);

                entity.ToTable("tdealermaster", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.Aocode)
                    .HasName("AOCode");

                entity.HasIndex(e => e.DistrictCodeVc)
                    .HasName("DistrictCode_VC");

                entity.HasIndex(e => e.StateCodeI)
                    .HasName("StateCode_I");

                entity.Property(e => e.DealerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aocode)
                    .HasColumnName("AOCode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCodeVc)
                    .HasColumnName("BranchCode_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryCodeVc)
                    .HasColumnName("CategoryCode_VC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByVc)
                    .HasColumnName("CreatedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDtD).HasColumnName("CreatedDt_D");

                entity.Property(e => e.DealerBranchCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DealerPhoto)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DealerType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DealerTypeVc)
                    .HasColumnName("dealerType_vc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictCodeVc)
                    .HasColumnName("DistrictCode_VC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MahindraShree).HasColumnType("char(3)");

                entity.Property(e => e.ModifiedByVc)
                    .HasColumnName("ModifiedBy_VC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDtD).HasColumnName("ModifiedDt_D");

                entity.Property(e => e.PinCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectorIdI)
                    .HasColumnName("SectorId_I")
                    .HasColumnType("int(4)");

                entity.Property(e => e.StateCodeI)
                    .HasColumnName("StateCode_I")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.TelOff1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelOff2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeofofficeI)
                    .HasColumnName("typeofoffice_i")
                    .HasColumnType("int(4)");

                entity.HasOne(d => d.AocodeNavigation)
                    .WithMany(p => p.Tdealermaster)
                    .HasForeignKey(d => d.Aocode)
                    .HasConstraintName("tdealermaster_ibfk_3");

                entity.HasOne(d => d.DistrictCodeVcNavigation)
                    .WithMany(p => p.Tdealermaster)
                    .HasForeignKey(d => d.DistrictCodeVc)
                    .HasConstraintName("tdealermaster_ibfk_2");

                entity.HasOne(d => d.StateCodeINavigation)
                    .WithMany(p => p.Tdealermaster)
                    .HasForeignKey(d => d.StateCodeI)
                    .HasConstraintName("tdealermaster_ibfk_1");
            });

            modelBuilder.Entity<TdealermasterLang>(entity =>
            {
                entity.ToTable("tdealermaster_lang", "dev_encrypted_generalcustomerapp");

                entity.HasIndex(e => e.DealerCode)
                    .HasName("DealerCode");

                entity.HasIndex(e => e.MstLangId)
                    .HasName("MST_LANG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveflagC)
                    .HasColumnName("ACTIVEFLAG_C")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Addr1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Addr2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Addr3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Addr4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyVc)
                    .HasColumnName("CREATEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtD).HasColumnName("CREATEDDT_D");

                entity.Property(e => e.DealerCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DealerLoc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DealerName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DealerTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.District)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedbyVc)
                    .HasColumnName("MODIFIEDBY_VC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieddtD).HasColumnName("MODIFIEDDT_D");

                entity.Property(e => e.MstLangId)
                    .HasColumnName("MST_LANG_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.DealerCodeNavigation)
                    .WithMany(p => p.TdealermasterLang)
                    .HasForeignKey(d => d.DealerCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tdealermaster_lang_ibfk_1");

                entity.HasOne(d => d.MstLang)
                    .WithMany(p => p.TdealermasterLang)
                    .HasForeignKey(d => d.MstLangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tdealermaster_lang_ibfk_2");
            });
        }
    }
}
