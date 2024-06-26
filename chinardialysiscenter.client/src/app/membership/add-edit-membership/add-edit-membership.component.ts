import { Component, OnInit, Input } from '@angular/core';
import { ApiserviceService } from '../../../../src/app/apiservice.service';

@Component({
  selector: 'app-add-edit-membership',
  templateUrl: './add-edit-membership.component.html',
  styleUrl: './add-edit-membership.component.css'
})
export class AddEditMembershipComponent implements OnInit {
  constructor(private service: ApiserviceService) { }

  @Input() member: any;
  MemberId = 0;
  FirstName = "";
  LastName = "";
  MobileNo = "";
  WhatsappNo = "";
  CNIC = "";
  Address = "";
  MembershipDate = "";

  ngOnInit(): void {

    this.MemberId = this.member.MemberId;
    this.FirstName = this.member.FirstName;
    this.LastName = this.member.LastName;
    this.MobileNo = this.member.MobileNo;
    this.WhatsappNo = this.member.WhatsappNo;
    this.CNIC = this.member.CNIC;
    this.Address = this.member.Address;
    this.MembershipDate = this.member.MembershipDate;
  }

  addMember() {
    var member = {
      MemberId: this.MemberId,
      FirstName: this.FirstName,
      LastName: this.LastName,
      MobileNo: this.MobileNo,
      WhatsappNo: this.WhatsappNo,
      CNIC: this.CNIC,
      Address: this.Address,
      MembershipDate: this.MembershipDate,
    };
    this.service.addMembership(member).subscribe(res => {
      alert(res.toString());
    });
  }

  updateMember() {
    var member = {
      MemberId: this.MemberId,
      FirstName: this.FirstName,
      LastName: this.LastName,
      MobileNo: this.MobileNo,
      WhatsappNo: this.WhatsappNo,
      CNIC: this.CNIC,
      Address: this.Address,
      MembershipDate: this.MembershipDate,
    };
    this.service.updateMembership(member).subscribe(res => {
      alert(res.toString());
    });
  }
}
