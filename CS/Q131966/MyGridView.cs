using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;

namespace Q131966 {
    public class MyGridView :GridView {
        public MyGridView(GridControl control) : base(control) { }
        public MyGridView() : this(null) { }

        protected override string ViewName { get { return "MyGridView"; } }

        protected override string GenerateColumnName(string fieldName) {
            string s = base.GenerateColumnName(fieldName);
            return s.Replace("col", string.Empty);
        }
    }

    public class MyGridInfoRegistrator : GridInfoRegistrator {
        public MyGridInfoRegistrator() : base() { }

        public override string ViewName { get { return "MyGridView"; } }

        public override BaseView CreateView(GridControl grid) { return new MyGridView(grid); }
    }

    public class MyGridControl : GridControl {
        public MyGridControl() : base() { }

        protected override void RegisterAvailableViewsCore(InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridInfoRegistrator());
        }
    }
}
