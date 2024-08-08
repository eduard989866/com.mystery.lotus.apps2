using GYUikoqwlebh;
using GYpqoiwheui;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace FTyuikqlwe.odjhuqwopoe
{
    public class BUioqwboeoIBo : BasCreen
    {
        [FormerlySerializedAs("profileName")] [SerializeField] private Text KJHUqwneOIJK;
        [FormerlySerializedAs("profilePhoto")] [SerializeField] private Image KJHuqwneOI;
        [FormerlySerializedAs("photoMask")] [SerializeField] private RectTransform JIowqeP;
        private UsewcFwqeVver _usewcFwqeVver;
        private LvfeqxWwsq _lvfeqxWwsq;

        public void IOjpqwejp(
            LvfeqxWwsq lvfeqxWwsq,
            UsewcFwqeVver usewcFwqeVver
        )
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            _lvfeqxWwsq = lvfeqxWwsq;
            _usewcFwqeVver = usewcFwqeVver;
        }

        public void JIOPpqjwePO()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            VolMangr.NHGUIdoqwe();
            _cvfw.ChdeDeqv<Jhubhqjwkqwe, OGbdqpwoek>(
                new OGbdqpwoek() { qwihegbijver = _lvfeqxWwsq.JIOpJIOHpnwqe }
            );
            // _canvas.ChangeScreen<GameScreen, GamePayload>(new GamePayload { SelectedLevel = _levelSavesManager.LastLevelIndex });
        }

        public override void MJIOnqwpeHUO()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            KJHUqwneOIJK.text = PlayerPrefs.HasKey(NBUioqwheIP.OOIHgwyqiue) 
                ? PlayerPrefs.GetString(NBUioqwheIP.OOIHgwyqiue) 
                : "Name";
            KJHuqwneOI.sprite = _usewcFwqeVver.NuihHUIhqwe;
            KJHuqwneOI.SetNativeSize();
            
            var okjqwpoejoiv = JIowqeP.rect.height / KJHuqwneOI.rectTransform.rect.height / 
                                KJHuqwneOI.transform.localScale.y;
            var JIOwnqeopnv = JIowqeP.rect.width / KJHuqwneOI.rectTransform.rect.width
                / KJHuqwneOI.transform.localScale.x;

            if (okjqwpoejoiv < .9 && JIOwnqeopnv < .9) 
                KJHuqwneOI.transform.localScale *= Mathf.Max(okjqwpoejoiv, JIOwnqeopnv);
            
            KJHuqwneOI.color = new Color(255, 255, 255, KJHuqwneOI.sprite is null ? 0 : 255);
            
            base.MJIOnqwpeHUO();
        }
        
        public void Njdknk()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            VolMangr.NHGUIdoqwe();
            Application.Quit();
        }
    }
}