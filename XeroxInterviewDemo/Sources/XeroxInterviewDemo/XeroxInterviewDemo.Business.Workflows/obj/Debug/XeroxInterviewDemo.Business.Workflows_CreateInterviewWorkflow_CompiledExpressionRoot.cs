namespace XeroxInterviewDemo.Business.Workflows {
    
    #line 24 "C:\dev\VSProjects\MySources\XeroxInterviewDemo\Sources\XeroxInterviewDemo\XeroxInterviewDemo.Business.Workflows\CreateInterviewWorkflow.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\dev\VSProjects\MySources\XeroxInterviewDemo\Sources\XeroxInterviewDemo\XeroxInterviewDemo.Business.Workflows\CreateInterviewWorkflow.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 25 "C:\dev\VSProjects\MySources\XeroxInterviewDemo\Sources\XeroxInterviewDemo\XeroxInterviewDemo.Business.Workflows\CreateInterviewWorkflow.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\dev\VSProjects\MySources\XeroxInterviewDemo\Sources\XeroxInterviewDemo\XeroxInterviewDemo.Business.Workflows\CreateInterviewWorkflow.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\dev\VSProjects\MySources\XeroxInterviewDemo\Sources\XeroxInterviewDemo\XeroxInterviewDemo.Business.Workflows\CreateInterviewWorkflow.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\dev\VSProjects\MySources\XeroxInterviewDemo\Sources\XeroxInterviewDemo\XeroxInterviewDemo.Business.Workflows\CreateInterviewWorkflow.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 26 "C:\dev\VSProjects\MySources\XeroxInterviewDemo\Sources\XeroxInterviewDemo\XeroxInterviewDemo.Business.Workflows\CreateInterviewWorkflow.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 27 "C:\dev\VSProjects\MySources\XeroxInterviewDemo\Sources\XeroxInterviewDemo\XeroxInterviewDemo.Business.Workflows\CreateInterviewWorkflow.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 28 "C:\dev\VSProjects\MySources\XeroxInterviewDemo\Sources\XeroxInterviewDemo\XeroxInterviewDemo.Business.Workflows\CreateInterviewWorkflow.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 29 "C:\dev\VSProjects\MySources\XeroxInterviewDemo\Sources\XeroxInterviewDemo\XeroxInterviewDemo.Business.Workflows\CreateInterviewWorkflow.xaml"
    using XeroxInterviewDemo.Business;
    
    #line default
    #line hidden
    
    #line 30 "C:\dev\VSProjects\MySources\XeroxInterviewDemo\Sources\XeroxInterviewDemo\XeroxInterviewDemo.Business.Workflows\CreateInterviewWorkflow.xaml"
    using XeroxInterviewDemo.Business.Objects;
    
    #line default
    #line hidden
    
    #line 31 "C:\dev\VSProjects\MySources\XeroxInterviewDemo\Sources\XeroxInterviewDemo\XeroxInterviewDemo.Business.Workflows\CreateInterviewWorkflow.xaml"
    using XeroxInterviewDemo.Business.Validations;
    
    #line default
    #line hidden
    
    #line 32 "C:\dev\VSProjects\MySources\XeroxInterviewDemo\Sources\XeroxInterviewDemo\XeroxInterviewDemo.Business.Workflows\CreateInterviewWorkflow.xaml"
    using XeroxInterviewDemo.Business.Workbenchs;
    
    #line default
    #line hidden
    
    #line 1 "C:\dev\VSProjects\MySources\XeroxInterviewDemo\Sources\XeroxInterviewDemo\XeroxInterviewDemo.Business.Workflows\CreateInterviewWorkflow.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class CreateInterviewWorkflow : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = CreateInterviewWorkflow_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CreateInterviewWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                CreateInterviewWorkflow_TypedDataContext2_ForReadOnly valDataContext0 = ((CreateInterviewWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CreateInterviewWorkflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new CreateInterviewWorkflow_TypedDataContext2(locations, activityContext, true);
                }
                CreateInterviewWorkflow_TypedDataContext2 refDataContext1 = ((CreateInterviewWorkflow_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<XeroxInterviewDemo.Business.Workbenchs.IWorkbench>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CreateInterviewWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                CreateInterviewWorkflow_TypedDataContext2_ForReadOnly valDataContext2 = ((CreateInterviewWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CreateInterviewWorkflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new CreateInterviewWorkflow_TypedDataContext2(locations, activityContext, true);
                }
                CreateInterviewWorkflow_TypedDataContext2 refDataContext3 = ((CreateInterviewWorkflow_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext3.GetLocation<XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness>>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CreateInterviewWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                CreateInterviewWorkflow_TypedDataContext2_ForReadOnly valDataContext4 = ((CreateInterviewWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CreateInterviewWorkflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new CreateInterviewWorkflow_TypedDataContext2(locations, activityContext, true);
                }
                CreateInterviewWorkflow_TypedDataContext2 refDataContext5 = ((CreateInterviewWorkflow_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<bool>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CreateInterviewWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                CreateInterviewWorkflow_TypedDataContext2_ForReadOnly valDataContext6 = ((CreateInterviewWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CreateInterviewWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                CreateInterviewWorkflow_TypedDataContext2_ForReadOnly valDataContext7 = ((CreateInterviewWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CreateInterviewWorkflow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new CreateInterviewWorkflow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                CreateInterviewWorkflow_TypedDataContext3_ForReadOnly valDataContext8 = ((CreateInterviewWorkflow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CreateInterviewWorkflow_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new CreateInterviewWorkflow_TypedDataContext3(locations, activityContext, true);
                }
                CreateInterviewWorkflow_TypedDataContext3 refDataContext9 = ((CreateInterviewWorkflow_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext9.GetLocation<string[]>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CreateInterviewWorkflow_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new CreateInterviewWorkflow_TypedDataContext3(locations, activityContext, true);
                }
                CreateInterviewWorkflow_TypedDataContext3 refDataContext10 = ((CreateInterviewWorkflow_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext10.GetLocation<int>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CreateInterviewWorkflow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new CreateInterviewWorkflow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                CreateInterviewWorkflow_TypedDataContext3_ForReadOnly valDataContext11 = ((CreateInterviewWorkflow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CreateInterviewWorkflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new CreateInterviewWorkflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                CreateInterviewWorkflow_TypedDataContext4_ForReadOnly valDataContext12 = ((CreateInterviewWorkflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CreateInterviewWorkflow_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new CreateInterviewWorkflow_TypedDataContext4(locations, activityContext, true);
                }
                CreateInterviewWorkflow_TypedDataContext4 refDataContext13 = ((CreateInterviewWorkflow_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext13.GetLocation<string>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                CreateInterviewWorkflow_TypedDataContext2_ForReadOnly valDataContext0 = new CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                CreateInterviewWorkflow_TypedDataContext2 refDataContext1 = new CreateInterviewWorkflow_TypedDataContext2(locations, true);
                return refDataContext1.GetLocation<XeroxInterviewDemo.Business.Workbenchs.IWorkbench>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                CreateInterviewWorkflow_TypedDataContext2_ForReadOnly valDataContext2 = new CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                CreateInterviewWorkflow_TypedDataContext2 refDataContext3 = new CreateInterviewWorkflow_TypedDataContext2(locations, true);
                return refDataContext3.GetLocation<XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness>>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                CreateInterviewWorkflow_TypedDataContext2_ForReadOnly valDataContext4 = new CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                CreateInterviewWorkflow_TypedDataContext2 refDataContext5 = new CreateInterviewWorkflow_TypedDataContext2(locations, true);
                return refDataContext5.GetLocation<bool>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                CreateInterviewWorkflow_TypedDataContext2_ForReadOnly valDataContext6 = new CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                CreateInterviewWorkflow_TypedDataContext2_ForReadOnly valDataContext7 = new CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                CreateInterviewWorkflow_TypedDataContext3_ForReadOnly valDataContext8 = new CreateInterviewWorkflow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                CreateInterviewWorkflow_TypedDataContext3 refDataContext9 = new CreateInterviewWorkflow_TypedDataContext3(locations, true);
                return refDataContext9.GetLocation<string[]>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                CreateInterviewWorkflow_TypedDataContext3 refDataContext10 = new CreateInterviewWorkflow_TypedDataContext3(locations, true);
                return refDataContext10.GetLocation<int>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                CreateInterviewWorkflow_TypedDataContext3_ForReadOnly valDataContext11 = new CreateInterviewWorkflow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                CreateInterviewWorkflow_TypedDataContext4_ForReadOnly valDataContext12 = new CreateInterviewWorkflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                CreateInterviewWorkflow_TypedDataContext4 refDataContext13 = new CreateInterviewWorkflow_TypedDataContext4(locations, true);
                return refDataContext13.GetLocation<string>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "new DefaultWorkbench()") 
                        && (CreateInterviewWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "workbench") 
                        && (CreateInterviewWorkflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new InterviewBusinessObject(workbench)") 
                        && (CreateInterviewWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interviewBusinessObject") 
                        && (CreateInterviewWorkflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "InterviewBusiness") 
                        && (CreateInterviewWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "result") 
                        && (CreateInterviewWorkflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "interviewBusinessObject") 
                        && (CreateInterviewWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "result") 
                        && (CreateInterviewWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new string [interviewBusinessObject.Validator.CreatingValidator.ValidationMessage" +
                            "s.Count]") 
                        && (CreateInterviewWorkflow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ValidationErrors") 
                        && (CreateInterviewWorkflow_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "i") 
                        && (CreateInterviewWorkflow_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "interviewBusinessObject.Validator.CreatingValidator.ValidationMessages") 
                        && (CreateInterviewWorkflow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "validationMessage.ToString ()") 
                        && (CreateInterviewWorkflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ValidationErrors[i]") 
                        && (CreateInterviewWorkflow_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new CreateInterviewWorkflow_TypedDataContext2(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new CreateInterviewWorkflow_TypedDataContext2(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new CreateInterviewWorkflow_TypedDataContext2(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new CreateInterviewWorkflow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new CreateInterviewWorkflow_TypedDataContext3(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new CreateInterviewWorkflow_TypedDataContext3(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new CreateInterviewWorkflow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new CreateInterviewWorkflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new CreateInterviewWorkflow_TypedDataContext4(locationReferences).@__Expr13GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class CreateInterviewWorkflow_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public CreateInterviewWorkflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class CreateInterviewWorkflow_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public CreateInterviewWorkflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class CreateInterviewWorkflow_TypedDataContext1 : CreateInterviewWorkflow_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public CreateInterviewWorkflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string[] ValidationErrors {
                get {
                    return ((string[])(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected XeroxInterviewDemo.Business.InterviewBusiness InterviewBusiness {
                get {
                    return ((XeroxInterviewDemo.Business.InterviewBusiness)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 0)].Name != "ValidationErrors") 
                            || (locationReferences[(offset + 0)].Type != typeof(string[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "InterviewBusiness") 
                            || (locationReferences[(offset + 1)].Type != typeof(XeroxInterviewDemo.Business.InterviewBusiness)))) {
                    return false;
                }
                return CreateInterviewWorkflow_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class CreateInterviewWorkflow_TypedDataContext1_ForReadOnly : CreateInterviewWorkflow_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public CreateInterviewWorkflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string[] ValidationErrors {
                get {
                    return ((string[])(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected XeroxInterviewDemo.Business.InterviewBusiness InterviewBusiness {
                get {
                    return ((XeroxInterviewDemo.Business.InterviewBusiness)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 0)].Name != "ValidationErrors") 
                            || (locationReferences[(offset + 0)].Type != typeof(string[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "InterviewBusiness") 
                            || (locationReferences[(offset + 1)].Type != typeof(XeroxInterviewDemo.Business.InterviewBusiness)))) {
                    return false;
                }
                return CreateInterviewWorkflow_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class CreateInterviewWorkflow_TypedDataContext2 : CreateInterviewWorkflow_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool result;
            
            public CreateInterviewWorkflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected XeroxInterviewDemo.Business.Workbenchs.IWorkbench workbench {
                get {
                    return ((XeroxInterviewDemo.Business.Workbenchs.IWorkbench)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            protected XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness> interviewBusinessObject {
                get {
                    return ((XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness>)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 66 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<XeroxInterviewDemo.Business.Workbenchs.IWorkbench>> expression = () => 
          workbench;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public XeroxInterviewDemo.Business.Workbenchs.IWorkbench @__Expr1Get() {
                
                #line 66 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                return 
          workbench;
                
                #line default
                #line hidden
            }
            
            public XeroxInterviewDemo.Business.Workbenchs.IWorkbench ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(XeroxInterviewDemo.Business.Workbenchs.IWorkbench value) {
                
                #line 66 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                
          workbench = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(XeroxInterviewDemo.Business.Workbenchs.IWorkbench value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 78 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness>>> expression = () => 
          interviewBusinessObject;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness> @__Expr3Get() {
                
                #line 78 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                return 
          interviewBusinessObject;
                
                #line default
                #line hidden
            }
            
            public XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness> ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness> value) {
                
                #line 78 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                
          interviewBusinessObject = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness> value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 90 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          result;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr5Get() {
                
                #line 90 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                return 
          result;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(bool value) {
                
                #line 90 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                
          result = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.result = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.result);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 2)].Name != "workbench") 
                            || (locationReferences[(offset + 2)].Type != typeof(XeroxInterviewDemo.Business.Workbenchs.IWorkbench)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "interviewBusinessObject") 
                            || (locationReferences[(offset + 3)].Type != typeof(XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "result") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                return CreateInterviewWorkflow_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class CreateInterviewWorkflow_TypedDataContext2_ForReadOnly : CreateInterviewWorkflow_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool result;
            
            public CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected XeroxInterviewDemo.Business.Workbenchs.IWorkbench workbench {
                get {
                    return ((XeroxInterviewDemo.Business.Workbenchs.IWorkbench)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            protected XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness> interviewBusinessObject {
                get {
                    return ((XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness>)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 71 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<XeroxInterviewDemo.Business.Workbenchs.IWorkbench>> expression = () => 
          new DefaultWorkbench();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public XeroxInterviewDemo.Business.Workbenchs.IWorkbench @__Expr0Get() {
                
                #line 71 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                return 
          new DefaultWorkbench();
                
                #line default
                #line hidden
            }
            
            public XeroxInterviewDemo.Business.Workbenchs.IWorkbench ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 83 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness>>> expression = () => 
          new InterviewBusinessObject(workbench);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness> @__Expr2Get() {
                
                #line 83 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                return 
          new InterviewBusinessObject(workbench);
                
                #line default
                #line hidden
            }
            
            public XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness> ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 99 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<XeroxInterviewDemo.Business.InterviewBusiness>> expression = () => 
        InterviewBusiness;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public XeroxInterviewDemo.Business.InterviewBusiness @__Expr4Get() {
                
                #line 99 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                return 
        InterviewBusiness;
                
                #line default
                #line hidden
            }
            
            public XeroxInterviewDemo.Business.InterviewBusiness ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 95 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness>>> expression = () => 
          interviewBusinessObject;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness> @__Expr6Get() {
                
                #line 95 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                return 
          interviewBusinessObject;
                
                #line default
                #line hidden
            }
            
            public XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness> ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 105 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          result;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr7Get() {
                
                #line 105 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                return 
          result;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            protected override void GetValueTypeValues() {
                this.result = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 2)].Name != "workbench") 
                            || (locationReferences[(offset + 2)].Type != typeof(XeroxInterviewDemo.Business.Workbenchs.IWorkbench)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "interviewBusinessObject") 
                            || (locationReferences[(offset + 3)].Type != typeof(XeroxInterviewDemo.Business.Objects.IBusinessObject<XeroxInterviewDemo.Business.InterviewBusiness>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "result") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                return CreateInterviewWorkflow_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class CreateInterviewWorkflow_TypedDataContext3 : CreateInterviewWorkflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int i;
            
            public CreateInterviewWorkflow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 116 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string[]>> expression = () => 
                ValidationErrors;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string[] @__Expr9Get() {
                
                #line 116 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                return 
                ValidationErrors;
                
                #line default
                #line hidden
            }
            
            public string[] ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(string[] value) {
                
                #line 116 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                
                ValidationErrors = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(string[] value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 128 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                i;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr10Get() {
                
                #line 128 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                return 
                i;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(int value) {
                
                #line 128 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                
                i = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.i = ((int)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.i);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "i") 
                            || (locationReferences[(offset + 5)].Type != typeof(int)))) {
                    return false;
                }
                return CreateInterviewWorkflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class CreateInterviewWorkflow_TypedDataContext3_ForReadOnly : CreateInterviewWorkflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int i;
            
            public CreateInterviewWorkflow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 121 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string[]>> expression = () => 
                new string [interviewBusinessObject.Validator.CreatingValidator.ValidationMessages.Count];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string[] @__Expr8Get() {
                
                #line 121 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                return 
                new string [interviewBusinessObject.Validator.CreatingValidator.ValidationMessages.Count];
                
                #line default
                #line hidden
            }
            
            public string[] ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 138 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<XeroxInterviewDemo.Business.Validations.ValidationMessage>>> expression = () => 
                interviewBusinessObject.Validator.CreatingValidator.ValidationMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IEnumerable<XeroxInterviewDemo.Business.Validations.ValidationMessage> @__Expr11Get() {
                
                #line 138 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                return 
                interviewBusinessObject.Validator.CreatingValidator.ValidationMessages;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IEnumerable<XeroxInterviewDemo.Business.Validations.ValidationMessage> ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            protected override void GetValueTypeValues() {
                this.i = ((int)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "i") 
                            || (locationReferences[(offset + 5)].Type != typeof(int)))) {
                    return false;
                }
                return CreateInterviewWorkflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class CreateInterviewWorkflow_TypedDataContext4 : CreateInterviewWorkflow_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public CreateInterviewWorkflow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected XeroxInterviewDemo.Business.Validations.ValidationMessage validationMessage {
                get {
                    return ((XeroxInterviewDemo.Business.Validations.ValidationMessage)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 148 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    ValidationErrors[i];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr13Get() {
                
                #line 148 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                return 
                    ValidationErrors[i];
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(string value) {
                
                #line 148 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                
                    ValidationErrors[i] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 7))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 7);
                }
                expectedLocationsCount = 7;
                if (((locationReferences[(offset + 6)].Name != "validationMessage") 
                            || (locationReferences[(offset + 6)].Type != typeof(XeroxInterviewDemo.Business.Validations.ValidationMessage)))) {
                    return false;
                }
                return CreateInterviewWorkflow_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class CreateInterviewWorkflow_TypedDataContext4_ForReadOnly : CreateInterviewWorkflow_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public CreateInterviewWorkflow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CreateInterviewWorkflow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected XeroxInterviewDemo.Business.Validations.ValidationMessage validationMessage {
                get {
                    return ((XeroxInterviewDemo.Business.Validations.ValidationMessage)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 153 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    validationMessage.ToString ();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr12Get() {
                
                #line 153 "C:\DEV\VSPROJECTS\MYSOURCES\XEROXINTERVIEWDEMO\SOURCES\XEROXINTERVIEWDEMO\XEROXINTERVIEWDEMO.BUSINESS.WORKFLOWS\CREATEINTERVIEWWORKFLOW.XAML"
                return 
                    validationMessage.ToString ();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 7))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 7);
                }
                expectedLocationsCount = 7;
                if (((locationReferences[(offset + 6)].Name != "validationMessage") 
                            || (locationReferences[(offset + 6)].Type != typeof(XeroxInterviewDemo.Business.Validations.ValidationMessage)))) {
                    return false;
                }
                return CreateInterviewWorkflow_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
