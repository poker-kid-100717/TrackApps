import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

interface Interview {
  Id: number
  Company: string;
  Position: string;
  Interviewer: string;
  InterviewDate: string;
  ContactNumber: string;
  Round: number;
  FollowUp: boolean;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  public interviews: Interview[] = [];

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getInterviews();
  }

  getInterviews() {
    this.http.get<Interview[]>('/interviews').subscribe(
      (result) => {
        this.interviews = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  title = 'trackapps.client';
}
