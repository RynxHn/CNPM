using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PMQL
{
    class Process
    {
        string connStr = "Data Source=DESKTOP-059PDRG;" +
            "Initial Catalog=CNPM;Integrated Security=True";
        protected SqlConnection conn;
        public void openConnect()
        {
            conn = new SqlConnection(connStr);
            conn.Open();
        }
        public void closeConnect()
        {
            conn.Close();
        }
        //người mua
        public DataTable Load_NM()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM NguoiMua";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public bool Them_NM(string ma_nm, string ten_nm, string stk_steam)
        {
            bool ktthem;
            openConnect();
            string sql = "Insert into NguoiMua(ma_nm, ten_nm, stk_steam) values(@ma_nm, @ten_nm, @stk_steam)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_nm", ma_nm);
            cmd.Parameters.AddWithValue("@ten_nm", ten_nm);
            cmd.Parameters.AddWithValue("@stk_steam", stk_steam);
            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }
        public bool CheckMaNM(string ma_nm)
        {
            bool kq = false;
            openConnect();
            string sql = "SELECT * FROM NguoiMua WHERE ma_nm = @ma_nm";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_nm", ma_nm);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
                kq = true;
            closeConnect();
            return kq;
        }
        public bool Sua_NM(string ma_nm, string ten_nm, string stk_steam)
        {
            bool ktsua;
            openConnect();
            string sql = "Update NguoiMua SET ten_nm = @ten_nm, stk_steam = @stk_steam WHERE ma_nm = @ma_nm";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_nm", ma_nm);
            cmd.Parameters.AddWithValue("@ten_nm", ten_nm);
            cmd.Parameters.AddWithValue("@stk_steam", stk_steam);
            try
            {
                cmd.ExecuteNonQuery();
                ktsua = true;
            }
            catch
            {
                ktsua = false;
            }
            closeConnect();
            return ktsua;
        }
        public bool Xoa_NM_by_name_stk(string ten_nm, string stk_steam)
        {
            bool ktxoa;
            openConnect();
            string sql = "DELETE FROM NguoiMua WHERE ten_nm = @ten_nm OR stk_steam = @stk_steam";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ten_nm", ten_nm);
            cmd.Parameters.AddWithValue("@stk_steam", stk_steam);
            try
            {
                cmd.ExecuteNonQuery();
                ktxoa = true;
            }
            catch
            {
                ktxoa = false;
            }
            closeConnect();
            return ktxoa;
        }
        public DataTable Load_TimNM(string ma_nm, string ten_nm, string stk_steam)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM NguoiMua WHERE ma_nm = @ma_nm OR ten_nm = @ten_nm OR stk_steam = @stk_steam";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_nm", ma_nm);
            cmd.Parameters.AddWithValue("@ten_nm", ten_nm);
            cmd.Parameters.AddWithValue("@stk_steam", stk_steam);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        //người bán
        public DataTable Load_NB()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM NguoiBan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public bool Them_NB(string ma_nb, string ten_nb, string stk_steam)
        {
            bool ktthem;
            openConnect();
            string sql = "Insert into NguoiBan(ma_nb, ten_nb, stk_steam) values(@ma_nb, @ten_nb, @stk_steam)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_nb", ma_nb);
            cmd.Parameters.AddWithValue("@ten_nb", ten_nb);
            cmd.Parameters.AddWithValue("@stk_steam", stk_steam);
            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }
        public bool CheckMaNB(string ma_nb)
        {
            bool kq = false;
            openConnect();
            string sql = "SELECT * FROM NguoiBan WHERE ma_nb = @ma_nb";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_nb", ma_nb);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
                kq = true;
            closeConnect();
            return kq;
        }
        public bool Sua_NB(string ma_nb, string ten_nb, string stk_steam)
        {
            bool ktsua;
            openConnect();
            string sql = "Update NguoiBan SET ten_nb = @ten_nb, stk_steam = @stk_steam WHERE ma_nb = @ma_nb";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_nb", ma_nb);
            cmd.Parameters.AddWithValue("@ten_nb", ten_nb);
            cmd.Parameters.AddWithValue("@stk_steam", stk_steam);
            try
            {
                cmd.ExecuteNonQuery();
                ktsua = true;
            }
            catch
            {
                ktsua = false;
            }
            closeConnect();
            return ktsua;
        }
        public bool Xoa_NB_by_name_stk(string ten_nb, string stk_steam)
        {
            bool ktxoa;
            openConnect();
            string sql = "DELETE FROM NguoiBan WHERE ten_nb = @ten_nb OR stk_steam = @stk_steam";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ten_nb", ten_nb);
            cmd.Parameters.AddWithValue("@stk_steam", stk_steam);
            try
            {
                cmd.ExecuteNonQuery();
                ktxoa = true;
            }
            catch
            {
                ktxoa = false;
            }
            closeConnect();
            return ktxoa;
        }
        public DataTable Load_TimNB(string ma_nb, string ten_nb, string stk_steam)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM NguoiBan WHERE ma_nb = @ma_nb OR ten_nb = @ten_nb OR stk_steam = @stk_steam";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_nb", ma_nb);
            cmd.Parameters.AddWithValue("@ten_nb", ten_nb);
            cmd.Parameters.AddWithValue("@stk_steam", stk_steam);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        //vật phẩm
        public DataTable Load_VP()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM VatPham";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public bool Them_VP(string ma_vp, string ten_vp, string gia, string loai, string dohiem)
        {
            bool ktthem;
            openConnect();
            string sql = "Insert into VatPham(ma_vp, ten_vp, gia, loai, dohiem) values(@ma_vp, @ten_vp, @gia, @loai, @dohiem)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_vp", ma_vp);
            cmd.Parameters.AddWithValue("@ten_vp", ten_vp);
            cmd.Parameters.AddWithValue("@gia", gia);
            cmd.Parameters.AddWithValue("@loai", loai);
            cmd.Parameters.AddWithValue("@dohiem", dohiem);
            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }
        public bool CheckMaVP(string ma_vp)
        {
            bool kq = false;
            openConnect();
            string sql = "SELECT * FROM VatPham WHERE ma_vp = @ma_vp";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_vp", ma_vp);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
                kq = true;
            closeConnect();
            return kq;
        }
        public bool Sua_VP(string ma_vp, string ten_vp, string gia, string loai, string dohiem)
        {
            bool ktsua;
            openConnect();
            string sql = "Update VatPham SET ten_vp = @ten_vp, gia = @gia, loai = @loai, dohiem = @dohiem WHERE ma_vp = @ma_vp";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_vp", ma_vp);
            cmd.Parameters.AddWithValue("@ten_vp", ten_vp);
            cmd.Parameters.AddWithValue("@gia", gia);
            cmd.Parameters.AddWithValue("@loai", loai);
            cmd.Parameters.AddWithValue("@dohiem", dohiem);
            try
            {
                cmd.ExecuteNonQuery();
                ktsua = true;
            }
            catch
            {
                ktsua = false;
            }
            closeConnect();
            return ktsua;
        }
        public bool Xoa_VP_by_id_name(string ma_vp, string ten_vp)
        {
            bool ktxoa;
            openConnect();
            string sql = "DELETE FROM VatPham WHERE ma_vp = @ma_vp AND ten_vp = @ten_vp";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_vp", ma_vp);
            cmd.Parameters.AddWithValue("@ten_vp", ten_vp);
            try
            {
                cmd.ExecuteNonQuery();
                ktxoa = true;
            }
            catch
            {
                ktxoa = false;
            }
            closeConnect();
            return ktxoa;
        }
        public DataTable Load_TimVP(string ma_vp, string ten_vp, string gia, string loai, string dohiem)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM VatPham WHERE ma_vp = @ma_vp OR ten_vp = @ten_vp OR gia = @gia OR loai = @loai OR dohiem = @dohiem";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_vp", ma_vp);
            cmd.Parameters.AddWithValue("@ten_vp", ten_vp);
            cmd.Parameters.AddWithValue("@gia", gia);
            cmd.Parameters.AddWithValue("@loai", loai);
            cmd.Parameters.AddWithValue("@dohiem", dohiem);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        ////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////
        //mod
        public DataTable Load_Mod()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM Moderator";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public bool Them_Mod(string ma_mod, string ten_mod, string sdt, string diachi, string capbac)
        {
            bool ktthem;
            openConnect();
            string sql = "Insert into Moderator(ma_mod, ten_mod, sdt, diachi, capbac) values(@ma_mod, @ten_mod, @sdt, @diachi, @capbac)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_mod", ma_mod);
            cmd.Parameters.AddWithValue("@ten_mod", ten_mod);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@capbac", capbac);
            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }
        public bool CheckMaMod(string ma_mod)
        {
            bool kq = false;
            openConnect();
            string sql = "SELECT * FROM Moderator WHERE ma_mod = @ma_mod";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_mod", ma_mod);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
                kq = true;
            closeConnect();
            return kq;
        }
        public bool Sua_Mod(string ma_mod, string ten_mod, string sdt, string diachi, string capbac)
        {
            bool ktsua;
            openConnect();
            string sql = "Update Moderator SET ten_mod = @ten_mod, sdt = @sdt, diachi = @diachi, capbac = @capbac WHERE ma_mod = @ma_mod";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_mod", ma_mod);
            cmd.Parameters.AddWithValue("@ten_mod", ten_mod);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@capbac", capbac);
            try
            {
                cmd.ExecuteNonQuery();
                ktsua = true;
            }
            catch
            {
                ktsua = false;
            }
            closeConnect();
            return ktsua;
        }
        public bool Xoa_Mod_by_name_sdt(string ten_mod, string sdt)
        {
            bool ktxoa;
            openConnect();
            string sql = "DELETE FROM Moderator WHERE ten_mod = @ten_mod AND sdt = @sdt";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ten_mod", ten_mod);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            try
            {
                cmd.ExecuteNonQuery();
                ktxoa = true;
            }
            catch
            {
                ktxoa = false;
            }
            closeConnect();
            return ktxoa;
        }
        public DataTable Load_TimMod(string ma_mod, string ten_mod, string sdt, string diachi, string capbac)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM Moderator WHERE ma_mod = @ma_mod OR ten_mod = @ten_mod OR sdt = @sdt OR diachi = @diachi OR capbac = @capbac";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_mod", ma_mod);
            cmd.Parameters.AddWithValue("@ten_mod", ten_mod);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@capbac", capbac);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        ////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////
        //thanh toán
        public DataTable Load_HD()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM HoaDon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public bool Them_HD(string ma_hd, string ten_vp, string ten_nm, string ten_nb, string gia, string pttt, string ngd)
        {
            bool ktthem;
            openConnect();
            string sql = "Insert into HoaDon(ma_hd, ten_vp, ten_nm, ten_nb, gia, pttt, ngd) values(@ma_hd, @ten_vp, @ten_nm, @ten_nb, @gia, @pttt, @ngd)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma_hd", ma_hd);
            cmd.Parameters.AddWithValue("@ten_vp", ten_vp);
            cmd.Parameters.AddWithValue("@ten_nm", ten_nm);
            cmd.Parameters.AddWithValue("@ten_nb", ten_nb);
            cmd.Parameters.AddWithValue("@gia", gia);
            cmd.Parameters.AddWithValue("@pttt", pttt);
            cmd.Parameters.AddWithValue("@ngd", ngd);
            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }
        //////////////////////////////////////////////
        public DataTable Load_nameNM()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT ten_nm FROM NguoiMua";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_nameNB()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT ten_nb FROM NguoiBan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_name_priceVP()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT ten_vp,gia FROM VatPham";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
    }
}
