import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { ComponentFixture, TestBed } from '@angular/core/testing';
import { AppComponent } from './app.component';

describe('AppComponent', () => {
  let component: AppComponent;
  let fixture: ComponentFixture<AppComponent>;
  let httpMock: HttpTestingController;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AppComponent],
      imports: [HttpClientTestingModule]
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppComponent);
    component = fixture.componentInstance;
    httpMock = TestBed.inject(HttpTestingController);
  });

  afterEach(() => {
    httpMock.verify();
  });

  it('should create the app', () => {
    expect(component).toBeTruthy();
  });

  it('should retrieve interviews forecasts from the server', () => {
    const mockInterviews = [

      { Id: 1, Company: 'Test', InterviewDate: '11-20-2024', Interviewer: 'Test', Position: 'Software Engineer', ContactNumber: '619-569-6149', Round: 1, FollowUp: true },

    ];

    component.ngOnInit();

    const req = httpMock.expectOne('/interviews');
    expect(req.request.method).toEqual('GET');
    req.flush(mockInterviews);

    expect(component.interviews).toEqual(mockInterviews);
  });
});
