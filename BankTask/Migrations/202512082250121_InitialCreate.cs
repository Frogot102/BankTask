namespace BankTask.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "AVERS_DWH_NSO_CLIENT",  
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    CLIENT_ACC = c.String(maxLength: 25),
                    DATE_BEGIN = c.DateTime(nullable: false),
                    DATE_END = c.DateTime(),
                    IKUSNUM = c.Int(nullable: false),
                    AGGREMENT_NUM = c.String(maxLength: 50),
                    AGGREMENT_DATE = c.DateTime(),
                    ACC_N068 = c.String(maxLength: 25),
                    ACC_47426 = c.String(maxLength: 25),
                    IS_ACTIVE = c.Boolean(nullable: false),
                    CREATE_USER = c.String(maxLength: 250),
                    CREATE_DATE = c.DateTime(nullable: false),
                    UPDATE_USER = c.String(maxLength: 250),
                    UPDATE_DATE = c.DateTime(),
                    NOTE = c.String(maxLength: 250),
                    ERR_MESSAGE = c.String(maxLength: 1000),
                    CLIENT_ACC_DOP = c.String(maxLength: 25),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "AVERS_DWH_NSO_REQUESTS",  
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    CLIENT_ACC = c.String(maxLength: 100),
                    CREATE_DATE = c.DateTime(nullable: false),
                    SUMM = c.String(maxLength: 20),
                    ADDAGGREMENT_NUM = c.String(maxLength: 20),
                    PRC_STR = c.String(maxLength: 250),
                    DATE_BEGIN = c.DateTime(nullable: false),
                    DATE_END = c.DateTime(),
                    DAYS_COUNT = c.String(maxLength: 10),
                    PRC_JS_CALC = c.Int(),
                    PRC_NUM = c.Int(),
                    DATE_BREAK = c.DateTime(),
                    IS_ENDED = c.Int(),
                    ADDAGGREMENT_DATE = c.DateTime(),
                    IKUSNUM = c.Int(nullable: false),
                    CREATE_USER = c.String(maxLength: 250),
                    UPDATE_USER = c.String(maxLength: 250),
                    UPDATE_DATE = c.DateTime(),
                    NOTE = c.String(maxLength: 250),
                    ERR_MESSAGE = c.String(maxLength: 1000),
                    NSO_CLIENT_ID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AVERS_DWH_NSO_CLIENT", t => t.NSO_CLIENT_ID)  
                .Index(t => t.NSO_CLIENT_ID);
        }

        public override void Down()
        {
            DropForeignKey("AVERS_DWH_NSO_REQUESTS", "NSO_CLIENT_ID", "AVERS_DWH_NSO_CLIENT");
            DropIndex("AVERS_DWH_NSO_REQUESTS", new[] { "NSO_CLIENT_ID" });
            DropTable("AVERS_DWH_NSO_REQUESTS");
            DropTable("AVERS_DWH_NSO_CLIENT");
        }
    }
}