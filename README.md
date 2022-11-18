# Sitecore.RemoveContactFromList

The tool to remove contact (by E-Mail) from the contact list (by list ID). EXM, Email Experience Manager

## How to deploy

Copy `RemoveFromGlobalOptOut.aspx` and `RemoveFromGlobalOptOut.aspx.cs` files to the `sitecore/admin` folder of the website root.
It will be compiled in runtime, so no DLL deployment and app pool restart needed.

## How to use

Have an E-Mail address of the contact you would like to remove and the ID of the contact list (can be copied from URL in List Manager)
