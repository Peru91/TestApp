export class User {

 UserProfileID: number; 
 FirstName: string; 
 MiddleName: string; 
 LastName: string; 
 Gender: string; 
 Email: string; 
 Password: any[]; 
 Salt: string;
 RoleID: number;
  Status: boolean;
 CreatedDate?: Date;
 CreatedBy?: number;
 ModifiedBy?: number; 
 ModifiedDate?: Date;
 DeletedBy?: number; 
 DeletedDate?: Date

}
