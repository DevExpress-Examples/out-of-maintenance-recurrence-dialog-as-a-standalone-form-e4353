<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128553436/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4353)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/AppointmentRecurrenceFormExample/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/AppointmentRecurrenceFormExample/Controllers/HomeController.vb))
* [Index.cshtml](./CS/AppointmentRecurrenceFormExample/Views/Home/Index.cshtml)
* [RecurrenceFormInfo.cshtml](./CS/AppointmentRecurrenceFormExample/Views/Home/RecurrenceFormInfo.cshtml)
<!-- default file list end -->
# Recurrence Dialog as a Standalone Form


<p>This project demonstrates how you can use the <a href="http://documentation.devexpress.com/#AspNet/clsDevExpressWebMvcAppointmentRecurrenceFormExtensiontopic"><u>AppointmentRecurrenceFormExtension</u></a> class instance in your application to display a recurrence form that facilitates creating a recurrence rule by the end-user.  The recurrence rule is encapsulated into the <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraSchedulerRecurrenceInfotopic"><u>RecurrenceInfo</u></a> object, which can be obtained  in the controller code via the <strong>AppointmentRecurrenceFormExtension.GetValue</strong> method.<br />
The <strong>Bind</strong> method of the AppointmentRecurrenceFormExtension is used to bind it to the <strong>R</strong><strong>e</strong><strong>currenceInfo</strong> object. After the form is instantiated and displayed,  the end-user can click the controls on the form to specify recurrence rule.  When the end-user has finished making changes and clicks  <strong>Apply</strong><strong>,</strong><strong> </strong><strong> </strong>the<strong> </strong>controller creates a recurrent appointment with a pattern that follows the recurrence rule specified by the recurrence form. After that the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXtraSchedulerRecurrenceInfo_ToXmltopic854"><u>RecurrenceInfo.ToXml</u></a> method is used to obtain an xml string that describes the rule. The resulting string is displayed in the browser.</p>

<br/>


